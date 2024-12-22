using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui1
{
    public partial class f_loader_image : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public f_loader_image()
        {
            InitializeComponent();

            label2.Text = "Hi.. "+f_user_login.g_user_name;

            textBox1.Select();
            


        }



       

        Timer tmr;

        private void f_loader_image_Shown(object sender, EventArgs e)

        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();


            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 7000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;

        }

        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

           
            //hide this form

            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                // Wait 50 milliseconds.  
                System.Threading.Thread.Sleep(50);
                
                // Report progress.  
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar  
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value == 15)
            {
                label3.Text = "> Setup Loaded";
            }
            if (progressBar1.Value == 35)
            {
                label4.Text = "> Database Loaded";
            }
            if (progressBar1.Value == 65)
            {
                label5.Text = "> Ready to go..";
            }
            if (progressBar1.Value == 100)
            {
                label6.Text = "> Done!";
            }

            // Set the text.  
            label1.Text = "Loading... Please, Wait.... " + e.ProgressPercentage.ToString() + "%";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void f_loader_image_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string userid = f_user_login.g_user_id;
            string user_type = f_user_login.g_user_type;
            if (e.KeyCode == Keys.F10)
            {
                if (progressBar1.Value <= 75)
                {
                    if (user_type == "M")
                    {

                        f_super_admin_control_panel sacp = new f_super_admin_control_panel();
                        sacp.Show();

                        
                    }
                }

            }
        }
    }
}
