using FluentMigrator;

namespace CICP.Migrations.CicpDB
{
    [Migration(20160707161600)]
    public class CicpDB_20160707_161600_AlterMobileUserTable : Migration
    {
        public override void Up()
        {
            Alter.Table("MobileUser")
                .AddColumn("ipaddress").AsString(200).Nullable();
        }

        public override void Down()
        {
        }
    }

}