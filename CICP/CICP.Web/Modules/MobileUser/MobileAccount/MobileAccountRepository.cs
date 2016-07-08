

namespace CICP.MobileUser.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using MyRow = Entities.MobileAccountRow;

    public class MobileAccountRepository
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

        public static string CheckPhone(string Phone)
        {
            string dianxin = @"^1[3578][01379]\d{8}$";
            string liantong = @"^1[34578][01256]\d{8}$";
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            if (Regex.IsMatch(Phone, dianxin) || Regex.IsMatch(Phone, liantong) || Regex.IsMatch(Phone, yidong))
            {
                return Phone;
            }
            else
            {
                throw new ValidationError("手机号码格式不正确");
            }   
        }
       
	    public static string CheckIDCard(string Id)
	    {  
	        if (Id.Length == 18)  
	        {  
	            bool check = CheckIDCard18(Id);
                if (!check)
                    throw new ValidationError("身份证格式不正确");
                return Id;
	        }  
	        else if (Id.Length == 15)  
	        {  
	            bool check = CheckIDCard15(Id);
                if (!check)
                    throw new ValidationError("身份证格式不正确");
                return Id;
            }  
	        else  
	        {
                throw new ValidationError("身份证格式不正确");
            }  
	    }  

	    public static bool CheckIDCard18(string Id)
	    {  
	        long n = 0;  
	        if (long.TryParse(Id.Remove(17), out n) == false || n<Math.Pow(10, 16) || long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out n) == false)  
	        {  
	            return false;//数字验证  
	        }  
	        string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";  
	        if (address.IndexOf(Id.Remove(2)) == -1)  
	        {  
	            return false;//省份验证  
	        }  
	        string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");  
	        DateTime time = new DateTime();  
	        if (DateTime.TryParse(birth, out time) == false)  
	        {  
	            return false;//生日验证  
	        }  
	        string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');  
	        string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');  
	        char[] Ai = Id.Remove(17).ToCharArray();  
	        int sum = 0;  
	        for (int i = 0; i< 17; i++)  
	        {  
	            sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());  
	        }  
	        int y = -1;  
	        Math.DivRem(sum, 11, out y);  
	        if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())  
	        {  
	            return false;//校验码验证  
	        }  
	            return true;//符合GB11643-1999标准  
	        }  

	    public static bool CheckIDCard15(string Id)
	    {  
	        long n = 0;  
	        if (long.TryParse(Id, out n) == false || n<Math.Pow(10, 14))  
	        {  
	            return false;//数字验证  
	        }  
	        string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";  
	        if (address.IndexOf(Id.Remove(2)) == -1)  
	        {  
	            return false;//省份验证  
	        }  
	        string birth = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-");  
	        DateTime time = new DateTime();  
	        if (DateTime.TryParse(birth, out time) == false)  
	        {  
	            return false;//生日验证  
	        }  
	        return true;//符合15位身份证标准  
	    }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            protected override void ValidateRequest()
            {
                base.ValidateRequest();

                if (IsUpdate)
                {
                    if (Row.Idnumber != Old.Idnumber)
                        Row.Idnumber = CheckIDCard(Row.Idnumber);
                    if (Row.Name != Old.Name)
                        Row.Name = Row.Name;
                    if (Row.Tel != Old.Tel)
                        Row.Tel = CheckPhone(Row.Tel);
                    if (Row.Orderno != Old.Orderno)
                        Row.Orderno = Row.Orderno;
                }

                if (IsCreate)
                {
                    Row.Name = Row.Name;
                    Row.Idnumber = CheckIDCard(Row.Idnumber);
                    Row.Tel = CheckPhone(Row.Tel);
                    Row.Orderno = Row.Orderno;
                }
            }

            protected override void AfterSave()
            {
                base.AfterSave();

                BatchGenerationUpdater.OnCommit(this.UnitOfWork, fld.GenerationKey);
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}