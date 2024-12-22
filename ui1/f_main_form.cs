using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Ui1
{
    public partial class f_main_form : Form
    {
      
        public static string PreviousPage = "";
        public static string userid =  f_user_login.g_user_id;
        public static string companyid = f_user_login.g_company_id;
        public static string locationid = f_user_login.g_location_id;


        public static string companycode =  f_user_login.g_company_code;

        public string locationcode =   f_user_login.g_location_code;

        public static string company = f_user_login.g_company_name;

        public static string username = f_user_login.g_user_name;
       
        public string locationname = f_user_login.g_location_name;

        public static string form_code = "";
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataTable TableRecords = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);


        public f_main_form()
        {
            dt.Rows.Clear();
            InitializeComponent();
        
                        textBox2.Visible = true;

            this.Text = "Company: " + company + "-" + "[" + companycode + "]" + " > Location: " + locationname + " > Logged User: " + username + "-" + "[" + userid + "]" + "  > Date: " + System.DateTime.Now + " > " + "Version: 2023.0925";
            con.Open();

            SqlCommand com = new SqlCommand("SP_MENU_MAPPED_007", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id", userid);
            com.Parameters.AddWithValue("@i_company_id", companyid);
            com.Parameters.AddWithValue("@i_location_id", locationid);
            SqlDataAdapter da = new SqlDataAdapter(com);

            dt.Clear();
            da.Fill(dt);


            f_loader_image mf = new f_loader_image();
            mf.ShowDialog();


            PopulateTreeView(treeView1.Nodes, 0, dt);

            this.treeView1.ExpandAll();

            textBox2.Select();
            con.Close();

        }
        protected void PopulateTreeView(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {
            TableRecords = folders;
            foreach (DataRow folder in folders.Rows)
            {
                if (Convert.ToInt32(folder["t_parent_id"]) == parentID)
                {
                    String key = folder["t_module_id"].ToString();
                    String text = folder["t_module_name"].ToString() + "-[" + folder["t_module_id"].ToString() + "]";
                    TreeNodeCollection newParentNode = parentNode.Add(key, text).Nodes;
                    PopulateTreeView(newParentNode, Convert.ToInt32(folder["t_module_id"]), folders);
                }

            }



        }

        private void BindTreeView(DataTable dataTable)
        {
            int i = 0;
            treeView1.Nodes.Clear();
            while (i < dataTable.Rows.Count)
            {
                DataRow row = dataTable.Rows[i];
                string department = row.Field<string>(0) ?? "";
                TreeNode departmentNode = treeView1.Nodes.Add(department);
                while (i < dataTable.Rows.Count && row.Field<string>(0) == department)
                {
                    string name = row.Field<string>(1) ?? "";
                    departmentNode.Nodes.Add(name);
                    while (i < dataTable.Rows.Count && row.Field<string>(0) == department && name == row.Field<string>(1))
                    {
                        if (++i < dataTable.Rows.Count)
                            row = dataTable.Rows[i];
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            c.Panel1Collapsed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Panel1Collapsed = false;
        }
        private void Logo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

       

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

            
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string formName = "";
            string Pagename = "";
            string tablepagename = "";
            string menuid = "";
            string pagenavigation = "";
            string menu_name = "";
            int menu_with_index = 0;
            int form_start_code = 0;
            int form_end_code = 0;
         
            TreeNode node1 = treeView1.SelectedNode;
            if (node1 != null)
            {
                Pagename = node1.Text;
                int length = Pagename.Length;
                menu_with_index = Pagename.IndexOf('-');
                form_start_code = Pagename.IndexOf('[');
                form_end_code = Pagename.IndexOf(']');
                form_start_code = form_start_code + 1;
                form_end_code = form_end_code - form_start_code;
              
                form_code = Pagename.Substring(form_start_code, form_end_code);
                menu_name = Pagename.Substring(0, menu_with_index);

            }

            for (int i = 0; i < TableRecords.Rows.Count; i++)
            {
                tablepagename = TableRecords.Rows[i]["t_module_name"].ToString();
                menuid = TableRecords.Rows[i]["t_module_id"].ToString();
                pagenavigation = TableRecords.Rows[i]["t_form_mapped"].ToString();

                if (tablepagename == menu_name)
                {

                    i = TableRecords.Rows.Count + 1;
                }
            }

            if (pagenavigation != "")
            {
                formName = pagenavigation;
                formName = Assembly.GetEntryAssembly().GetName().Name + "." + formName;
                Type type = Type.GetType(formName);
                if (formName == "NOT_MAPPED")
                {

                }
                else
                {
                    Form form = (Form)Activator.CreateInstance(type);

                    if (form != null)
                    {
                        if (pagenavigation == "Company")
                        { 
                        }
                        else
                        {
                            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
                            form.WindowState = FormWindowState.Normal;

                            form.Show();
                            form.BringToFront();
                        }


                    }
                }

            }

            if (PreviousPage != "")
            {

            }

            PreviousPage = formName;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }
         

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            //DataTable menuDataTable = new DataTable();
            //string Inputfile = textBox2.Text.ToString();
            //string _userid = userid.ToString();
            //con.Open();
            //SqlCommand com = new SqlCommand("sp_MenuSearch", con);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@Searchtext", Inputfile);
            //com.Parameters.AddWithValue("@userid", _userid);
            //SqlDataAdapter da = new SqlDataAdapter(com);
            //da.Fill(menuDataTable);
            //treeView1.Nodes.Clear();
            //PopulateTreeView(treeView1.Nodes, 0, menuDataTable);
            //treeView1.ExpandAll();
            //con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void f_main_form_Shown(object sender, EventArgs e)
        {
        }
         
    }
}
