using FluentMigrator;

namespace CICP.Migrations.CicpDB
{
    [Migration(20160708155500)]
    public class CicpDB_20160708_155500_CreateResultTable : Migration
    {
        public override void Up()
        {
            Create.Table("Result")
                .WithColumn("UserID").AsInt32().NotNullable()
                .WithColumn("Username").AsString(100).NotNullable()
                .WithColumn("idnumber").AsString(200).NotNullable().ForeignKey("FK_MobileAccount_idnumber","MobileAccount","idnumber")
                .WithColumn("data").AsString(500).NotNullable()
                .WithColumn("msg").AsString(200).NotNullable()
                .WithColumn("success").AsString(200).NotNullable();
        }

        public override void Down()
        {
        }
    }

}