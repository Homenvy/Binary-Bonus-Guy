namespace ForexTrading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RowUpdates050714 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Forexes", "RowID", c => c.Int(nullable: false));
            AddColumn("dbo.Forexes", "BonusType", c => c.String());
            AddColumn("dbo.Binaries", "RowID", c => c.Int(nullable: false));
            AddColumn("dbo.Binaries", "BonusType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Binaries", "BonusType");
            DropColumn("dbo.Binaries", "RowID");
            DropColumn("dbo.Forexes", "BonusType");
            DropColumn("dbo.Forexes", "RowID");
        }
    }
}
