namespace BankingRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Admin_Id = c.Int(nullable: false, identity: true),
                        Admin_Name = c.String(),
                        Admin_password = c.String(),
                        Admin_address = c.String(),
                        Admin_mobile = c.String(),
                    })
                .PrimaryKey(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Branch_Id = c.Int(nullable: false, identity: true),
                        Branch_Location = c.String(),
                    })
                .PrimaryKey(t => t.Branch_Id);
            
            CreateTable(
                "dbo.BranchManagers",
                c => new
                    {
                        Manager_Id = c.Int(nullable: false, identity: true),
                        Manager_Name = c.String(),
                        Manager_password = c.String(),
                        Manager_address = c.String(),
                        Manager_mobile = c.String(),
                        Manager_Salary = c.Double(nullable: false),
                        Manager_Balance = c.Double(nullable: false),
                        Manager_LastPaymentDate = c.String(),
                        Manager_TotalPayment = c.Double(nullable: false),
                        Manager_branch = c.String(),
                    })
                .PrimaryKey(t => t.Manager_Id);
            
            CreateTable(
                "dbo.Cashiers",
                c => new
                    {
                        Cashier_Id = c.Int(nullable: false, identity: true),
                        Cashier_Name = c.String(),
                        Cashier_password = c.String(),
                        Cashier_address = c.String(),
                        Cashier_mobile = c.String(),
                        Cashier_Salary = c.Double(nullable: false),
                        Cashier_LastPaymentDate = c.String(),
                        Cashier_TotalPayment = c.Double(nullable: false),
                        Cashier_Balance = c.Double(nullable: false),
                        Cashier_branch = c.String(),
                    })
                .PrimaryKey(t => t.Cashier_Id);
            
            CreateTable(
                "dbo.CheckBooks",
                c => new
                    {
                        Check_id = c.Int(nullable: false, identity: true),
                        Check_User_name = c.String(),
                        Check_apply_Date = c.String(),
                        Check_status = c.String(),
                        Check_fixed_Date = c.String(),
                    })
                .PrimaryKey(t => t.Check_id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Expense_Id = c.Int(nullable: false, identity: true),
                        Expense_name = c.String(),
                        Expense_date = c.String(),
                        Expense_amount = c.String(),
                    })
                .PrimaryKey(t => t.Expense_Id);
            
            CreateTable(
                "dbo.HROfficers",
                c => new
                    {
                        HR_acc_Id = c.Int(nullable: false, identity: true),
                        HR_name = c.String(),
                        HR_password = c.String(),
                        HR_address = c.String(),
                        HR_mobile = c.String(),
                        HR_Salary = c.Double(nullable: false),
                        HR_LastPaymentDate = c.String(),
                        HR_TotalPayment = c.Double(nullable: false),
                        HR_Balance = c.Double(nullable: false),
                        HR_branch = c.String(),
                    })
                .PrimaryKey(t => t.HR_acc_Id);
            
            CreateTable(
                "dbo.LInfoes",
                c => new
                    {
                        Loan_Id = c.Int(nullable: false, identity: true),
                        User_acc_no = c.Int(nullable: false),
                        LOfficer_Id = c.Int(nullable: false),
                        Loan_Amount = c.Double(nullable: false),
                        AmountTo_Pay = c.Double(nullable: false),
                        Interest_Rate = c.Double(nullable: false),
                        Loan_Amount_Paid = c.Double(nullable: false),
                        Loan_Date = c.String(),
                        Loan_Deadline = c.String(),
                        Loan_Branch = c.String(),
                        Manager_Approval = c.String(),
                        MD_Approval = c.String(),
                        Status = c.String(),
                        LoanCause = c.String(),
                    })
                .PrimaryKey(t => t.Loan_Id);
            
            CreateTable(
                "dbo.LoanOfficers",
                c => new
                    {
                        LOfficer_Id = c.Int(nullable: false, identity: true),
                        LOfficer_name = c.String(),
                        LOfficer_Password = c.String(),
                        LOfficer_address = c.String(),
                        LOfficer_mobile = c.String(),
                        LOfficer_Salary = c.Double(nullable: false),
                        LOfficer_LastPaymentDate = c.String(),
                        LOfficer_TotalPayment = c.Double(nullable: false),
                        LOfficer_Balance = c.Double(nullable: false),
                        LOfficer_branch = c.String(),
                    })
                .PrimaryKey(t => t.LOfficer_Id);
            
            CreateTable(
                "dbo.Logininfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Login_acc_no = c.Int(nullable: false),
                        Login_Name = c.String(),
                        Login_Password = c.String(),
                        Login_type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MDirectors",
                c => new
                    {
                        MD_Id = c.Int(nullable: false, identity: true),
                        MD_name = c.String(),
                        MD_password = c.String(),
                        MD_address = c.String(),
                        MD_Salary = c.Double(nullable: false),
                        MD_Balance = c.Double(nullable: false),
                        MD_mobile = c.String(),
                    })
                .PrimaryKey(t => t.MD_Id);
            
            CreateTable(
                "dbo.Officers",
                c => new
                    {
                        Officer_Id = c.Int(nullable: false, identity: true),
                        Officer_Name = c.String(),
                        Officer_password = c.String(),
                        Officer_address = c.String(),
                        Officer_mobile = c.String(),
                        Officer_Salary = c.Double(nullable: false),
                        Officer_LastPaymentDate = c.String(),
                        Officer_TotalPayment = c.Double(nullable: false),
                        Officer_Balance = c.Double(nullable: false),
                        Officer_branch = c.String(),
                    })
                .PrimaryKey(t => t.Officer_Id);
            
            CreateTable(
                "dbo.TOfficers",
                c => new
                    {
                        TO_accId = c.Int(nullable: false, identity: true),
                        TO_name = c.String(),
                        TO_password = c.String(),
                        TO_address = c.String(),
                        TO_mobile = c.String(),
                        TO_Salary = c.String(),
                        TO_LastPaymentDate = c.String(),
                        TO_TotalPayment = c.Double(nullable: false),
                        TO_Balance = c.String(),
                        TO_branch = c.String(),
                    })
                .PrimaryKey(t => t.TO_accId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Tr_Id = c.Int(nullable: false, identity: true),
                        Tr_Through = c.String(),
                        Tr_EmpType = c.String(),
                        Tr_AccName = c.String(),
                        Tr_Type = c.String(),
                        Tr_Amount = c.Double(nullable: false),
                        Tr_Date = c.String(),
                        Tr_Branch = c.String(),
                    })
                .PrimaryKey(t => t.Tr_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        User_acc_no = c.Int(nullable: false, identity: true),
                        User_Name = c.String(),
                        User_password = c.String(),
                        User_address = c.String(),
                        User_mobile = c.String(),
                        User_balance = c.Double(nullable: false),
                        User_acc_type = c.String(),
                        Deadline = c.String(),
                    })
                .PrimaryKey(t => t.User_acc_no);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.TOfficers");
            DropTable("dbo.Officers");
            DropTable("dbo.MDirectors");
            DropTable("dbo.Logininfoes");
            DropTable("dbo.LoanOfficers");
            DropTable("dbo.LInfoes");
            DropTable("dbo.HROfficers");
            DropTable("dbo.Expenses");
            DropTable("dbo.CheckBooks");
            DropTable("dbo.Cashiers");
            DropTable("dbo.BranchManagers");
            DropTable("dbo.Branches");
            DropTable("dbo.Admins");
        }
    }
}
