namespace Databasteknik10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookLoans",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        LoanId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        BookLoan_BookId = c.Int(),
                        BookLoan_LoanId = c.Int(),
                    })
                .PrimaryKey(t => new { t.BookId, t.LoanId })
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.BookLoans", t => new { t.BookLoan_BookId, t.BookLoan_LoanId })
                .ForeignKey("dbo.Loans", t => t.LoanId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.LoanId)
                .Index(t => new { t.BookLoan_BookId, t.BookLoan_LoanId });
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        ISBN = c.String(),
                        Pages = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoanDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loans", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.BookLoans", "LoanId", "dbo.Loans");
            DropForeignKey("dbo.BookLoans", new[] { "BookLoan_BookId", "BookLoan_LoanId" }, "dbo.BookLoans");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BookLoans", "BookId", "dbo.Books");
            DropIndex("dbo.Loans", new[] { "CustomerId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropIndex("dbo.BookLoans", new[] { "BookLoan_BookId", "BookLoan_LoanId" });
            DropIndex("dbo.BookLoans", new[] { "LoanId" });
            DropIndex("dbo.BookLoans", new[] { "BookId" });
            DropTable("dbo.Loans");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.BookLoans");
        }
    }
}
