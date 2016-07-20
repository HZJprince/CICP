using FluentMigrator;

namespace CICP.Migrations.CicpDB
{
    [Migration(20160720154200)]
    public class CicpDB_20160720_154200_CreateResultTable : Migration
    {
        public override void Up()
        {
            Create.Table("RongTuo")
                .WithColumn("Version").AsString(50).PrimaryKey()
                .WithColumn("UserID").AsInt32().NotNullable()
                .WithColumn("Username").AsString(100).NotNullable()
                .WithColumn("idnumber").AsString(200).NotNullable().ForeignKey("FK_MobileAccount_idnumber_new", "MobileAccount", "idnumber")
                .WithColumn("respCode").AsString(500).NotNullable()
                .WithColumn("respDesc").AsString(500).NotNullable()
                .WithColumn("msg").AsString(200).NotNullable()
                .WithColumn("success").AsString(200).NotNullable();
        }

        public override void Down()
        {
        }
    }

}