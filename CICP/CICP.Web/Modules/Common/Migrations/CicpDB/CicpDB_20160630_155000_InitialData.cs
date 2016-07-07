using FluentMigrator;

namespace CICP.Migrations.CicpDB
{
    [Migration(20160630155000)]
    public class CicpDB_20160630_155000_InitialData : Migration
    {
        public override void Up()
        {
            Create.Table("MobileUser")
                .WithColumn("username").AsString(50).PrimaryKey().NotNullable()
                .WithColumn("password").AsString(200).NotNullable();

            Create.Table("MobileAccount")
                .WithColumn("name").AsString(200).Nullable()
                .WithColumn("tel").AsString(200).Nullable()
                .WithColumn("idnumber").AsString(200).PrimaryKey().Nullable()
                .WithColumn("orderno").AsString(1000);
        }

        public override void Down()
        {
        }
    }

}