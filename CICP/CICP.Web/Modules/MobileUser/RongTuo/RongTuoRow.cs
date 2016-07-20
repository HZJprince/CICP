

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

    [ConnectionKey("Cicp"), DisplayName("RongTuo"), InstanceName("RongTuo"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class RongTuoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Version"), Size(50), PrimaryKey, QuickSearch, NotNull]
        public String Version
        {
            get { return Fields.Version[this]; }
            set { Fields.Version[this] = value; }
        }

        [DisplayName("User Id"), Column("UserID"), NotNull]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("Username"), Size(100), NotNull]
        public String Username
        {
            get { return Fields.Username[this]; }
            set { Fields.Username[this] = value; }
        }

        [DisplayName("Idnumber"), Column("idnumber"), Size(200), NotNull, ForeignKey("[dbo].[MobileAccount]", "idnumber"), LeftJoin("jIdnumber"), TextualField("IdnumberName")]
        public String Idnumber
        {
            get { return Fields.Idnumber[this]; }
            set { Fields.Idnumber[this] = value; }
        }

        [DisplayName("Resp Code"), Column("respCode"), Size(500), NotNull]
        public String RespCode
        {
            get { return Fields.RespCode[this]; }
            set { Fields.RespCode[this] = value; }
        }

        [DisplayName("Resp Desc"), Column("respDesc"), Size(500), NotNull]
        public String RespDesc
        {
            get { return Fields.RespDesc[this]; }
            set { Fields.RespDesc[this] = value; }
        }

        [DisplayName("Msg"), Column("msg"), Size(200), NotNull]
        public String Msg
        {
            get { return Fields.Msg[this]; }
            set { Fields.Msg[this] = value; }
        }

        [DisplayName("Success"), Column("success"), Size(200), NotNull]
        public String Success
        {
            get { return Fields.Success[this]; }
            set { Fields.Success[this] = value; }
        }

        [DisplayName("Idnumber Name"), Expression("jIdnumber.[name]")]
        public String IdnumberName
        {
            get { return Fields.IdnumberName[this]; }
            set { Fields.IdnumberName[this] = value; }
        }

        [DisplayName("Idnumber Tel"), Expression("jIdnumber.[tel]")]
        public String IdnumberTel
        {
            get { return Fields.IdnumberTel[this]; }
            set { Fields.IdnumberTel[this] = value; }
        }

        [DisplayName("Idnumber Orderno"), Expression("jIdnumber.[orderno]")]
        public String IdnumberOrderno
        {
            get { return Fields.IdnumberOrderno[this]; }
            set { Fields.IdnumberOrderno[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Version; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Version; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RongTuoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Version;
            public Int32Field UserId;
            public StringField Username;
            public StringField Idnumber;
            public StringField RespCode;
            public StringField RespDesc;
            public StringField Msg;
            public StringField Success;

            public StringField IdnumberName;
            public StringField IdnumberTel;
            public StringField IdnumberOrderno;

            public RowFields()
                : base("[dbo].[RongTuo]")
            {
                LocalTextPrefix = "MobileUser.RongTuo";
            }
        }
    }
}