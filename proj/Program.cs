using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
            //Application.Run(new Insert_Update_Delete_Disconnected()); //DELAYED
            //Application.Run(new Search_Admin_Election()); 
            //Application.Run(new Shows_Info()); 
            //Application.Run(new Master_Detail());  
            //Application.Run(new crystal()); 
            //Application.Run(new GUI());
            //Application.Run(new VOTING());
            //Application.Run(new Candidate_Participate());
            //Application.Run(new Result());
        }
    }
}
