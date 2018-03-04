namespace BookAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addServices : DbMigration
    {
        public override void Up()
        {
            Sql($"INSERT INTO ServiceProvided(ID,Name,Price,Description,ServiceTime) VALUES (1,'Threading',8,'Eyebrows Threading',{new TimeSpan(0,10,0)})");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM ServiceProvided WHERE ID in (1)");
        }
    }
}
