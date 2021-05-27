namespace MVCMovies2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieNine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Actions", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Actions");
        }
    }
}
