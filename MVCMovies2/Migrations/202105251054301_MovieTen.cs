namespace MVCMovies2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTen : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Actions");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Actions", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
