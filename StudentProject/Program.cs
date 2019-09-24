using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        
              class DeveloperCollection
        {
            static void Main()
            {
                Developer d1 = new Developer();
                d1.firstName = "Peter";
                d1.lastName = "Johnson";
                d1.phoneExtension = 000;
                d1.gender = "male";

                Console.WriteLine(d1.ToString());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }


        
       
        }
    }
}
