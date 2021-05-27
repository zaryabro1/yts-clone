namespace MVCMovies2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieFourteen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieCover", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieCover");
        }
    }
}
