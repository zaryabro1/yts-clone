namespace MVCMovies2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTwelve : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "MovieCover");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieCover", c => c.Binary());
        }
    }
}
