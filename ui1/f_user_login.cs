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
 


namespace Ui1
{
    public partial class f_user_login : Form
    {
        public static string g_user_id = "default User Id";
        public static string g_user_code = "default User Code";
        public static string g_user_name = "default User Name";


        public static string g_company_id = "default Company Id";
        public static string g_company_code = "default Company Code";
        public static string g_company_name = "default Company Name";


        public static string g_location_id = "default Location Id";
        public static string g_location_code = "default Location Code";
        public static string g_location_name = "default Location Name";


        public static string g_user_type = "default User Type";

        public static string g_Password = "";
        public static string PreviousPage = "";

        public static string g_menu_id = "default User Id";

        DataTable TableRecords = new DataTable();
        DataTable dt_company_code = new DataTable();
        DataTable dt_location_code = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        DataTable dt = new DataTable();
        public f_user_login()
        {
            InitializeComponent();
            tb_password.Enabled = false;
        }


        // INPUT EVENTS

        private void tb_userid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SP_USER_CHECK_001();
            }
        }

        void SP_USER_CHECK_001()
        {
            int user_count = 0;
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand com = new SqlCommand("SP_USER_CHECK_001", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id", tb_userid.Text);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                user_count = Convert.ToInt32(dt.Rows[i]["o_user_count"]);
                g_user_id = tb_userid.Text;
                g_user_code = (dt.Rows[i]["o_user_code"].ToString());
                g_user_name = (dt.Rows[i]["o_user_name"].ToString());

                l_UserId.Text = g_user_id;
                l_UserCode.Text = (dt.Rows[i]["o_user_code"].ToString());
                l_UserName.Text = (dt.Rows[i]["o_user_name"].ToString());
                g_user_type = (dt.Rows[i]["o_user_type"].ToString());
            }

            if (user_count <= 0)
            {
                l_user_check.ForeColor = Color.Red;
                l_user_check.Text = "No";
            }
            else
            {
                l_user_check.ForeColor = Color.Green;
                l_user_check.Text = "Ok";
                tb_userid.Enabled = false;
                tb_password.Enabled = true;
                tb_password.Select();
                l_UserId.Text = tb_userid.Text;

            }
           con.Close();
        }



        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SP_PASSWORD_CHECK_002();
            }
        }
       
        void SP_PASSWORD_CHECK_002()
        {
            int user_count = 0;
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand com = new SqlCommand("SP_PASSWORD_CHECK_002", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id", tb_userid.Text);
            com.Parameters.AddWithValue("@i_password", tb_password.Text);

            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                user_count = Convert.ToInt32(dt.Rows[i]["o_user_count"]);
            }

            if (user_count <= 0)
            {
                l_password_check.ForeColor = Color.Red;
                l_password_check.Text = "No";
            }
            else
            {
                l_password_check.ForeColor = Color.Green;
                l_password_check.Text = "Ok";
                tb_password.Enabled = false;
                g_Password = "your password verified.";
                SP_COMPANY_MAPPED_003();
            }
            con.Close();
        }

        void SP_COMPANY_MAPPED_003()
        {
            string getuser = tb_userid.Text;
            string getpassword = tb_password.Text;
            con.Close();
            con.Open();
            SqlCommand com = new SqlCommand("SP_COMPANY_MAPPED_003", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id", tb_userid.Text);
            com.Parameters.AddWithValue("@i_user_password", tb_password.Text);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {

                c_companyname.ValueMember = "o_company_id";
                c_companyname.DisplayMember = "o_company_name";
                c_companyname.DataSource = dt;
                c_companyname.Enabled = true;
                c_companyname.Select();
                l_company_check.ForeColor = Color.Green;
                l_company_check.Text = "Ok";

            }
            else
            {
                l_company_check.ForeColor = Color.Red;
                l_company_check.Text = "No";
            }

            con.Close();
        }



        private void c_companyname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (c_companyname.DataSource != null || c_companyname.Text != "")
                {
                    c_locationname.Enabled = true;
                    SP_LOCATION_MAPPED_004();
                    c_companyname.Enabled = false;

                }
            }
        }

        void SP_LOCATION_MAPPED_004()
        {

            if (c_companyname.DataSource != null || c_companyname.Text != null || c_companyname.Text != "")
            {
                string company_id = c_companyname.SelectedValue.ToString();
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("SP_LOCATION_MAPPED_004", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i_company_id", company_id);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    c_locationname.DisplayMember = "o_location_name";
                    c_locationname.ValueMember = "o_location_id";
                    c_locationname.DataSource = dt;
                    c_locationname.Select();

                    l_CompanyId.Text = c_companyname.SelectedValue.ToString();

                    SqlCommand com2 = new SqlCommand("SP_GET_COMPANY_CODE_005", con);
                    com2.CommandType = CommandType.StoredProcedure;
                    com2.Parameters.AddWithValue("@i_company_id", l_CompanyId.Text);
                    SqlDataAdapter da1 = new SqlDataAdapter(com2);
                    da1.Fill(dt_company_code);

                    if (dt_company_code.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_company_code.Rows.Count; i++)
                        {
                            l_CompanyCode.Text = dt_company_code.Rows[i]["o_company_code"].ToString();
                        }
                    }

                    l_CompanyId.Text = c_companyname.SelectedValue.ToString();
                    l_CompanyName.Text = c_companyname.Text;
                    g_company_id = l_CompanyId.Text;
                    g_company_code = l_CompanyCode.Text;
                    g_company_name = l_CompanyName.Text;
                    l_location_check.ForeColor = Color.Green;
                    l_location_check.Text = "Ok";
                }
                else
                {
                    l_location_check.ForeColor = Color.Red;
                    l_location_check.Text = "No";
                }
                con.Close();
            }
        }





       private void c_locationname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l_LocationId.Text = c_locationname.SelectedValue.ToString();
                l_LocationName.Text = c_locationname.Text;

                con.Open();
                SqlCommand com = new SqlCommand("SP_GET_LOCATION_CODE_006", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i_location_id", l_LocationId.Text);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt_location_code);
                if (dt_location_code.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_location_code.Rows.Count; i++)
                    {
                        l_LocationCode.Text = dt_location_code.Rows[i]["o_location_code"].ToString();
                    }
                }
                g_location_id = l_LocationId.Text;
                g_location_code = l_LocationCode.Text;
                g_location_name = l_LocationName.Text;
                con.Close();
                c_locationname.Enabled = false;
                
            }
        }
      
       



        // SUPPORT FUNCTIONS

        protected void PopulateTreeView_Menu(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {
            TableRecords = folders;
            foreach (DataRow folder in folders.Rows)
            {
                if (Convert.ToInt32(folder["t_parent_id"]) == parentID)
                {
                    String key = folder["t_module_id"].ToString();
                    String text = folder["t_module_name"].ToString() + "-[" + folder["t_module_id"].ToString() + "]";
                    TreeNodeCollection newParentNode = parentNode.Add(key, text).Nodes;
                    PopulateTreeView_Menu(newParentNode, Convert.ToInt32(folder["t_module_id"]), folders);
                }

            }
        }
       
        
        // BUTTON EVENTS
       
        private void b_login_Click(object sender, EventArgs e)
        {

            if (c_companyname.Text != "" && c_locationname.Text != "" && c_companyname.SelectedValue != "" && c_locationname.SelectedValue != "")
            {
                g_user_id = tb_userid.Text;
                g_company_code = c_companyname.SelectedValue.ToString();
                g_company_name = c_companyname.Text.ToString();
                int g_company_index = g_company_name.IndexOf('-');
                g_company_name = g_company_name.Substring(0, g_company_index);
                g_location_code = c_locationname.SelectedValue.ToString();
                g_location_name = c_locationname.Text;
                g_location_id = l_LocationId.Text;
                this.Hide();
                f_main_form fmf = new f_main_form();
                fmf.Show();

            }
            else
            {
                MessageBox.Show("Please fill the Mandatory Fields", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            tb_userid.Enabled = true;
            l_user_check.Text = "";
            l_password_check.Text = "";
            l_company_check.Text = "";
            l_location_check.Text = "";


            tb_userid.Text = "";
            tb_password.Text = "";

            c_companyname.DataSource = null;
            c_locationname.DataSource = null;
            l_UserId.Text = "";
            l_UserCode.Text = "";
            l_UserName.Text = "";
            l_CompanyId.Text = "";
            l_CompanyCode.Text = "";
            l_CompanyName.Text = "";
            l_LocationId.Text = "";
            l_LocationCode.Text = "";
            l_LocationName.Text = "";
            g_user_id = "";
            g_user_code = "";
            g_user_name = "";
            g_company_id = "";
            g_company_code = "";
            g_company_name = "";
            g_location_id = "";
            g_location_code = "";
            g_location_name = "";

            tb_userid.Select();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tree_menu_list_AfterCollapse(object sender, TreeViewEventArgs e)
        {

        }

        private void tree_menu_list_AfterExpand(object sender, TreeViewEventArgs e)
        {

        }

        private void tree_menu_list_DoubleClick(object sender, EventArgs e)
        {

        }

       

    

         

        
    }


}
