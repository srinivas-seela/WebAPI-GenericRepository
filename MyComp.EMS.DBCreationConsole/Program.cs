using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyComp.EMS.Data;

namespace MyComp.EMS.DBCreationConsole
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                //Database.SetInitializer(new DBCreation());
                EMSDBContext context = new EMSDBContext();
                context.Database.Initialize(true);
                Console.WriteLine("DB Creation Successfull");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }            
            Console.ReadKey();
        }
    }
}
