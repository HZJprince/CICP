

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

    [ConnectionKey("Cicp"), DisplayName("MobileAccount"), InstanceName("MobileAccount"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class MobileAccountRow : Row, IIdRow, INameRow
    {
        [DisplayName("Name"), Column("name"), Size(200), QuickSearch, NotNull]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Tel"), Column("tel"), Size(200), NotNull]
        public String Tel
        {
            get { return Fields.Tel[this]; }
            set { Fields.Tel[this] = value; }
        }

        [DisplayName("Idnumber"), Column("idnumber"), Size(200), PrimaryKey, NotNull]
        public String Idnumber
        {
            get { return Fields.Idnumber[this]; }
            set { Fields.Idnumber[this] = value; }
        }

        [DisplayName("Orderno"), Column("orderno"), Size(1000)]
        public String Orderno
        {
            get { return Fields.Orderno[this]; }
            set { Fields.Orderno[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Idnumber; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MobileAccountRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Name;
            public StringField Tel;
            public StringField Idnumber;
            public StringField Orderno;

            public RowFields()
                : base("[dbo].[MobileAccount]")
            {
                LocalTextPrefix = "MobileUser.MobileAccount";
            }
        }
    }
}