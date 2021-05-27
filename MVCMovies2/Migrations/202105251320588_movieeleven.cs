namespace MVCMovies2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieeleven : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieCover", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieCover");
        }
    }
}
