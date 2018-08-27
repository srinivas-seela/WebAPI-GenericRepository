using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyComp.EMS.Data;
using MyComp.EMS.Data.Entities;

namespace MyComp.EMS.DBCreationConsole
{
    public class DBCreation : DropCreateDatabaseAlways<EMSDBContext>
    {
        protected override void Seed(EMSDBContext context)
        {
            var verticals = new List<Vertical>
            {
                new Vertical() { VerticalName = "Insurance", CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true },
                new Vertical() { VerticalName = "BFS", CreatedBy = "Admin",CreatedDate = DateTime.Now, LastUpdatedBy = "Admin", LastedUpdatedDate = DateTime.Now , ActiveStatus = true},
                new Vertical() { VerticalName = "FMCG", CreatedBy = "Admin",CreatedDate = DateTime.Now, LastUpdatedBy = "Admin", LastedUpdatedDate = DateTime.Now , ActiveStatus = true},
                new Vertical() { VerticalName = "HealthCare", CreatedBy = "Admin",CreatedDate = DateTime.Now, LastUpdatedBy = "Admin", LastedUpdatedDate = DateTime.Now , ActiveStatus = true},
                new Vertical() { VerticalName = "Automotive", CreatedBy = "Admin",CreatedDate = DateTime.Now, LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true}
            };

            verticals.ForEach(b => context.Verticals.Add(b));
            context.SaveChanges();
            var accounts = new List<Account>
            {
                new Account() { AccountName = "Allstate Inc." , VerticalID = 1,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true },
                new Account() { AccountName = "ClaimForce Inc." , VerticalID = 1,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now, ActiveStatus = true  },
                new Account() { AccountName = "Amex Inc." , VerticalID = 2,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true},                
                new Account() { AccountName = "Pepsi Co.Ltd." , VerticalID = 3,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true },
                new Account() { AccountName = "Humana Inc." , VerticalID = 4,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true },
                new Account() { AccountName = "Ford Motors" , VerticalID = 5,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true }                
            };
            accounts.ForEach(b => context.Accounts.Add(b));
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project() { ProjectName ="ClaimForce Refactor",ProjectExecutionLocation ="Mumbai" ,
                                ProjectStartDate = Convert.ToDateTime("01-Aug-2017") , ProjectEndDate = Convert.ToDateTime("20-Dec-2018"),
                                BillabilityCount = 6 , AccountID = 2,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now, ActiveStatus = true },

                new Project() { ProjectName ="Humana Refactor",ProjectExecutionLocation ="Mumbai" ,
                                ProjectStartDate = Convert.ToDateTime("01-Aug-2017") , ProjectEndDate = Convert.ToDateTime("20-Dec-2018"),
                                BillabilityCount = 16, AccountID = 5 ,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now , ActiveStatus = true},

                new Project() { ProjectName ="Ford GBS",ProjectExecutionLocation ="Pune" ,
                                ProjectStartDate = Convert.ToDateTime("01-Aug-2017") , ProjectEndDate = Convert.ToDateTime("20-Dec-2018"),
                                BillabilityCount = 26 , AccountID = 6,CreatedBy = "Admin", CreatedDate = DateTime.Now,LastUpdatedBy ="Admin" , LastedUpdatedDate = DateTime.Now, ActiveStatus = true },
            };

            projects.ForEach(b => context.Projects.Add(b));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
