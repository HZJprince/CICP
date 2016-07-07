

namespace CICP.MobileUser.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Cicp"), DisplayName("MobileUser"), InstanceName("MobileUser"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class MobileUserRow : Row, IIdRow, INameRow
    {
        [DisplayName("Username"), Column("username"), Size(50), PrimaryKey, QuickSearch]
        public String Username
        {
            get { return Fields.Username[this]; }
            set { Fields.Username[this] = value; }
        }

        [DisplayName("Password"), Column("password"), Size(200), NotNull]
        public String Password
        {
            get { return Fields.Password[this]; }
            set { Fields.Password[this] = value; }
        }

        [DisplayName("Confirm Password"), Size(50), SetFieldFlags(FieldFlags.ClientSide)]
        public String PasswordConfirm
        {
            get { return Fields.PasswordConfirm[this]; }
            set { Fields.PasswordConfirm[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Username; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Username; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MobileUserRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Username;
            public StringField Password;
            public StringField PasswordConfirm;

            public RowFields()
                : base("[dbo].[MobileUser]")
            {
                LocalTextPrefix = "MobileUser.MobileUser";
            }
        }
    }
}