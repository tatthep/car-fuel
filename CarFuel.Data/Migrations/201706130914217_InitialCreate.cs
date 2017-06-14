namespace CarFuel.Data.Migrations {
  using System;
  using System.Data.Entity.Migrations;

  public partial class InitialCreate : DbMigration {
    public override void Up() {
      CreateTable(
          "dbo.Cars",
          c => new {
            Id = c.Guid(nullable: false),
            Name = c.String(),
            PlateNo = c.String(),
            Make = c.String(),
            Model = c.String(),
            Year = c.Int(nullable: false),
            EngineSizeCC = c.Int(nullable: false),
            DateAdded = c.DateTime(nullable: false),
            OwnerId = c.String(),
          })
          .PrimaryKey(t => t.Id);

    }

    public override void Down() {
      DropTable("dbo.Cars");
    }
  }
}
