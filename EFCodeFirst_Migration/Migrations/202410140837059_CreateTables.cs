namespace EFCodeFirst_Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .Index(t => t.Credits);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID });
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        SignUpDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropIndex("dbo.Enrollments", new[] { "CourseID" });
            DropIndex("dbo.Courses", new[] { "Credits" });
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Courses");
            CreateIndex("dbo.OrderDetails", "ProductID");
            CreateIndex("dbo.OrderDetails", "OrderID");
            CreateIndex("dbo.Orders", "CustomerID");
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders", "OrderID", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
        }
    }
}
