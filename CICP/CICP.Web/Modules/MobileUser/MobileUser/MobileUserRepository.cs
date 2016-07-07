

namespace CICP.MobileUser.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Security.Cryptography;
    using System.Web.Security;
    using System.Text;
    using MyRow = Entities.MobileUserRow;

    public class MobileUserRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        public static string ValidatePassword(string username, string password, bool isNewUser)
        {
            password = password.TrimToNull();

            if (password == null ||
                password.Length < 6/*Membership.MinRequiredPasswordLength*/)
                throw new ValidationError("PasswordLength", "Password",
                    String.Format(Texts.Validation.MinRequiredPasswordLength, 6));

            return password;
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            private string password;

            public static MyRow GetUser(IDbConnection connection, BaseCriteria filter)
            {
                var row = new MyRow();
                if (new SqlQuery().From(row)
                    .Select(
                        fld.Username,
                        fld.Password)
                    .Where(filter)
                    .GetFirst(connection))
                {
                    return row;
                }

                return null;
            }

            private static bool IsInvariantLetter(Char c)
            {
                return (c >= 'A' && c <= 'Z') ||
                    (c >= 'a' && c <= 'z');
            }

            private static bool IsDigit(Char c)
            {
                return (c >= '0' && c <= '9');
            }

            private static bool IsValidEmailChar(Char c)
            {
                return IsInvariantLetter(c) ||
                    IsDigit(c) ||
                    c == '.' ||
                    c == '_' ||
                    c == '@';
            }

            public static bool IsValidUsername(string name)
            {
                if (name == null ||
                    name.Length < 0)
                    return false;

                var c = name[0];
                if (!IsInvariantLetter(c))
                    return false;

                for (var i = 1; i < name.Length - 1; i++)
                {
                    c = name[i];
                    if (!IsValidEmailChar(c))
                        return false;
                }

                return true;
            }

            public static string ValidateUsername(IDbConnection connection, string username)
            {
                username = username.TrimToNull();

                if (username == null)
                    throw DataValidation.RequiredError(fld.Username.Name, fld.Username.Title);

                if (!IsValidUsername(username))
                    throw new ValidationError("InvalidUsername", "Username",
                        "Usernames should start with letters, only contain letters and numbers!");

                var existing = GetUser(connection,
                    new Criteria(fld.Username) == username |
                    new Criteria(fld.Username) == username.Replace('I', 'İ'));

                if (existing != null && username != existing.Username)
                    throw new ValidationError("UniqueViolation", "Username",
                        "A user with same name exists. Please choose another!");

                return username;
            }

            protected override void ValidateRequest()
            {
                base.ValidateRequest();

                if (IsUpdate)
                {
                    if (Row.IsAssigned(fld.Password) && !Row.Password.IsEmptyOrNull())
                        password = Row.Password = ValidatePassword(Old.Username, Row.Password, false);

                    if (Row.Username != Old.Username)
                        Row.Username = MySaveHandler.ValidateUsername(this.Connection, Row.Username);
                }

                if (IsCreate)
                {
                    this.Row.Username = ValidateUsername(this.Connection, this.Row.Username);
                    password = ValidatePassword(Row.Username, Row.Password, true);
                }
            }

            protected override void SetInternalFields()
            {
                base.SetInternalFields();

                if (IsCreate || !Row.Password.IsEmptyOrNull())
                {
                    Row.Password = CalculateMD5Hash(password);
                }
            }

            protected override void AfterSave()
            {
                base.AfterSave();

                BatchGenerationUpdater.OnCommit(this.UnitOfWork, fld.GenerationKey);
            }
        }

        public static string CalculateMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            string psw = BitConverter.ToString(s).Replace("-", "");
            return psw;
        }

        //private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}