namespace SuperHeroes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondaryMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuperHeroes", "SecondaryAbility", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SuperHeroes", "SecondaryAbility");
        }
    }
}
