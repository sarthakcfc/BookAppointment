namespace BookAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertServices : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ServiceProvided(Name,Price,Description,ServiceTime) VALUES ('Threading',8,'Eyebrows Threading','0:10:0')");
        }
        
        public override void Down()
        {
            Sql($"DELETE FROM ServiceProvided WHERE Name like 'Threading'");
        }
    }
}
