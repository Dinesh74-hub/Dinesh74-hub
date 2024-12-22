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
    public partial class f_user_menu_mapped : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        DataTable g_user = new DataTable();
        DataTable g_menus = new DataTable();
        DataTable g_user_menu = new DataTable();
        DataTable g_menu_id = new DataTable();
        DataTable g_AllMenus = new DataTable();
        DataTable g_MappedMenus = new DataTable();
        DataTable dt_active_menus = new DataTable();
        DataTable dt_GetCompany = new DataTable();
        DataTable dt_GetLocation = new DataTable();
        DataTable dt = new DataTable();
        DataTable g_company = new DataTable();

        string g_userselected = "";
        public static string UserID1 = f_user_login.g_user_id;
        public f_user_menu_mapped()
        {
            InitializeComponent();
            SP_GET_USER_014();
            //SP_GET_COMPANY_009();
            //SP_GET_LOCATION_010();
            c_user_name.Select();
            //b_get_active_menu.Enabled = false;
        }
        private void SP_GET_COMPANY_009()
        {
            dt_GetCompany.Rows.Clear();
            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_COMPANY_009", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_GetCompany);
            c_company_name.ValueMember = "o_company_id";
            c_company_name.DisplayMember = "o_company_name";
            c_company_name.DataSource = dt_GetCompany;
            con.Close();
        }
        private void SP_GET_LOCATION_010()
        {
            dt_GetLocation.Rows.Clear();
            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_LOCATION_010", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_GetLocation);
            c_location_id.ValueMember = "o_location_id";
            c_location_id.DisplayMember = "o_location_name";
            c_location_id.DataSource = dt_GetLocation;
            con.Close();
        }
        private void SP_GET_USER_014()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_USER_014", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(g_user);
            c_user_name.DisplayMember = "o_user_name";
            c_user_name.ValueMember = "o_user_id";
            c_user_name.DataSource = g_user;
            

            con.Close();
            //SP_USER_MENU_020();

            g_menu_id.Clear();
            g_menu_id.Columns.Add("module_id");
            g_menu_id.Columns.Add("menu_id");
            g_menu_id.Columns.Add("submenu_id");
            l_message_log.Visible = false;
        }
        protected void PopulateTreeView(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {

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

        protected void PopulateTreeView1(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {

            foreach (DataRow folder in folders.Rows)
            {
                if (Convert.ToInt32(folder["t_parent_id"]) == parentID)
                {
                    String key = folder["t_module_id"].ToString();
                    String text = folder["t_module_name"].ToString() + "-[" + folder["t_module_id"].ToString() + "]";

                    String menu_active = "0";
                    menu_active = folder["t_active"].ToString();
                    TreeNodeCollection newParentNode = parentNode.Add(key, text).Nodes;
                    PopulateTreeView1(newParentNode, Convert.ToInt32(folder["t_module_id"]), folders);
                    if (menu_active == "1")
                    {
                        treeView2.Nodes[0].Nodes[1].Nodes[0].Checked = true;
                    }
                    else
                    {
                        //treeView2.Nodes[1].Nodes[1].Checked = false;
                    }


                }

            }

        }

        protected string getCheckedNodes(TreeNodeCollection tnc)
        {
            StringBuilder sb = new StringBuilder();

            foreach (TreeNode tn in tnc)
            {
                if (tn.Checked)
                {
                    string res = tn.FullPath;
                    //menu_with_index = Pagename.IndexOf('-');
                    int g_module_start_index = res.IndexOf('[');
                    int g_module_end_index = res.IndexOf(']');
                    int newmoduleindex = g_module_end_index + 1;
                    int length = res.Length;
                    int length1 = length - g_module_end_index;
                    int rechar = length1 - 1;
                    int g_module_start_index1 = g_module_start_index + 1;
                    int g_module_end_index1 = g_module_end_index - g_module_start_index1;

                    if (g_module_end_index1 != 0)
                    {
                        string value1 = res.Substring(g_module_start_index1, g_module_end_index1);
                        if (newmoduleindex != 0)
                        {
                            string remaining1 = res.Substring(newmoduleindex, rechar);

                            int g_main_menu_start_index = remaining1.IndexOf('[');
                            int g_main_menu_end_index = remaining1.IndexOf(']');
                            int g_main_menu_start_index1 = g_main_menu_start_index + 1;
                            int g_sub_menu_end_index = g_main_menu_end_index + 1;
                            int length2 = remaining1.Length;
                            int length3 = length2 - g_sub_menu_end_index;


                            if (length3 != 0)
                            {
                                string remaining2 = remaining1.Substring(g_sub_menu_end_index, length3);
                                int g_main_menu_end_index1 = g_main_menu_end_index - g_main_menu_start_index1;
                                if (g_main_menu_end_index1 != 0)
                                {
                                    string value2 = remaining1.Substring(g_main_menu_start_index1, g_main_menu_end_index1);
                                    int g_sub_menu_start_index = remaining2.IndexOf('[');
                                    int g_sub_menu_end_index1 = remaining2.IndexOf(']');
                                    g_sub_menu_start_index = g_sub_menu_start_index + 1;
                                    g_sub_menu_end_index1 = g_sub_menu_end_index1 - g_sub_menu_start_index;

                                    string value3 = remaining2.Substring(g_sub_menu_start_index, g_sub_menu_end_index1);
                                    string submenuid = value3;
                                    bool contains = g_menu_id.AsEnumerable().Any(row => submenuid == row.Field<String>("submenu_id"));
                                    if (contains == false)
                                    {
                                        DataRow menu_id = g_menu_id.NewRow();
                                        menu_id["module_id"] = value1.ToString();
                                        menu_id["menu_id"] = value2.ToString();
                                        menu_id["submenu_id"] = value3.ToString();
                                        g_menu_id.Rows.Add(menu_id);
                                    }

                                    if (res.Length > 0)
                                        sb.AppendLine(res);
                                }
                            }
                        }
                    }
                }
                string childRes = getCheckedNodes(tn.Nodes);
                if (childRes.Length > 0)
                    sb.AppendLine(childRes);
            }

            return sb.ToString();
        }

        private void CheckAllChildNodes1(TreeNode treeNodeAdv)
        {
            foreach (TreeNode nd in treeNodeAdv.Nodes)
            {
                nd.Checked = treeNodeAdv.Checked;
            }
        }

        private void UncheckChildNodes1(TreeNode treeNodeAdv)
        {
            foreach (TreeNode nd in treeNodeAdv.Nodes)
            {
                nd.Checked = treeNodeAdv.Checked;
            }
        }

        private void SP_USER_MENU_020()
        {
            g_menus.Rows.Clear();
            g_userselected = "";
            g_userselected = c_user_name.SelectedValue.ToString();
            string companyid = c_company_name.SelectedValue.ToString();
            string locationid = c_location_id.SelectedValue.ToString();
            SqlCommand com2 = new SqlCommand("SP_USER_MENU_020", con);
            com2.CommandType = CommandType.StoredProcedure;
     
            com2.Parameters.AddWithValue("@user_id", g_userselected);
            com2.Parameters.AddWithValue("@company_id", companyid);
            com2.Parameters.AddWithValue("@location_id", locationid);
            SqlDataAdapter da2 = new SqlDataAdapter(com2);


            da2.Fill(g_menus);

            if (g_menus.Rows.Count > 0)
            {
                tree_menu_list.Nodes.Clear();
                PopulateTreeView(tree_menu_list.Nodes, 0, g_menus);
                this.tree_menu_list.ExpandAll();
                treeView2.Nodes.Clear();
            }
            else
            {
                tree_menu_list.Nodes.Clear();
                treeView2.Nodes.Clear();
                //TreeView2();                
            }
        }

        
        private void b_getmenu_Click(object sender, EventArgs e)
        {
            dt_active_menus.Rows.Clear();
            treeView2.Nodes.Clear();
            string _user_id = c_user_name.SelectedValue.ToString();

            con.Open();
            SqlCommand com = new SqlCommand("SP_USER_MENU_MAPPED_ACTIVE_022", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user_id", _user_id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_active_menus);


            dgv_user_menu_permissions.DataSource = dt_active_menus;
            dgv_user_menu_permissions.Columns[0].ReadOnly = true;
            dgv_user_menu_permissions.Columns[1].ReadOnly = true;
            dgv_user_menu_permissions.Columns[2].ReadOnly = true;
            dgv_user_menu_permissions.Columns[3].ReadOnly = true;
            dgv_user_menu_permissions.Columns[4].ReadOnly = true;
            dgv_user_menu_permissions.Columns[5].ReadOnly = false;
            dgv_user_menu_permissions.Columns[6].ReadOnly = true;
            dgv_user_menu_permissions.Columns[7].ReadOnly = true;

            con.Close();
        }

        private void b_transfer_Click(object sender, EventArgs e)
        {

        }

        private void b_update_Click(object sender, EventArgs e)
        {
            string userid = c_user_name.SelectedValue.ToString();
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgv_user_menu_permissions.Rows.Count - 1; i++)
            {

                int _module_id = Convert.ToInt32(dgv_user_menu_permissions.Rows[i].Cells[0].Value.ToString());
                string _menu_type = dgv_user_menu_permissions.Rows[i].Cells[1].Value.ToString();
                string _module_name = dgv_user_menu_permissions.Rows[i].Cells[2].Value.ToString();
                int _parent_id = Convert.ToInt32(dgv_user_menu_permissions.Rows[i].Cells[3].Value.ToString());
                string _form_mapped = dgv_user_menu_permissions.Rows[i].Cells[4].Value.ToString();
                string active = (dgv_user_menu_permissions.Rows[i].Cells[5].Value.ToString());
                int _company_id = Convert.ToInt32(dgv_user_menu_permissions.Rows[i].Cells[6].Value.ToString());
                int _location_id = Convert.ToInt32(dgv_user_menu_permissions.Rows[i].Cells[7].Value.ToString());

                if (active != "")
                {
                    int _active = Convert.ToInt32(active);
                    con.Open();
                    SqlCommand com = new SqlCommand("SP_UPDATE_MENU_MAPPED_021", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@i_module_id", _module_id);
                    com.Parameters.AddWithValue("@i_menu_type", _menu_type);
                    com.Parameters.AddWithValue("@i_module_name", _module_name);
                    com.Parameters.AddWithValue("@i_parent_id", _parent_id);
                    com.Parameters.AddWithValue("@i_form_mapped", _form_mapped);
                    com.Parameters.AddWithValue("@i_active", _active);
                    com.Parameters.AddWithValue("@i_company_id", _company_id);
                    com.Parameters.AddWithValue("@i_location_id", _location_id);
                    com.Parameters.AddWithValue("@i_user_id", userid);
                    com.ExecuteNonQuery();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Check   Active Id", "Menu Mapped", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Cursor.Current = Cursors.Arrow;
            l_message_log.Visible = true;
            l_message_log.Text = "Successfully Updated";
        }

        private void c_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            g_company.Rows.Clear();
            string userid=c_user_name.SelectedValue.ToString();
            if (e.KeyCode == Keys.Enter)
            { 
                //b_get_active_menu.PerformClick(); 
                con.Open();
                SqlCommand com = new SqlCommand("SP_USER_MAPPED_COMPANY_LIST", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i_user_id",userid);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(g_company);

                c_company_name.DisplayMember = "o_company_name";
                c_company_name.ValueMember = "o_company_id";
                c_company_name.DataSource = g_company;
                con.Close();

                c_company_name.Select();
                c_user_name.Enabled = false;
                c_company_name.Enabled = true;
                c_location_id.Enabled = true;

            
            }
        }

        private void tree_menu_list_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count != 0)
            {
                if (e.Node.Checked)
                {
                    CheckAllChildNodes1(e.Node);
                }
                else
                {
                    UncheckChildNodes1(e.Node);
                }
            }
        }

        private void b_get_active_menu_Click(object sender, EventArgs e)
        {
            dt_active_menus.Rows.Clear();
            treeView2.Nodes.Clear();
            string _user_id = c_user_name.SelectedValue.ToString();
            string companyid = c_company_name.SelectedValue.ToString();
            string locationid = c_location_id.SelectedValue.ToString();

            con.Open();
            SqlCommand com = new SqlCommand("SP_USER_MENU_MAPPED_ACTIVE_022", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id", _user_id);
            com.Parameters.AddWithValue("@i_company_id", companyid);
            com.Parameters.AddWithValue("@i_location_id", locationid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_active_menus);


            dgv_user_menu_permissions.DataSource = dt_active_menus;
            dgv_user_menu_permissions.Columns[0].ReadOnly = true;
            dgv_user_menu_permissions.Columns[1].ReadOnly = true;
            dgv_user_menu_permissions.Columns[2].ReadOnly = true;
            dgv_user_menu_permissions.Columns[3].ReadOnly = true;
            dgv_user_menu_permissions.Columns[4].ReadOnly = true;
            dgv_user_menu_permissions.Columns[5].ReadOnly = false;
            dgv_user_menu_permissions.Columns[6].ReadOnly = true;
            dgv_user_menu_permissions.Columns[7].ReadOnly = true;

            con.Close();
            l_message_log.Text = "";
        }

        private void b_transfer_Click_1(object sender, EventArgs e)
        {
            string userselectedvalue = c_user_name.SelectedValue.ToString();
            string companyid = c_company_name.SelectedValue.ToString();
            string locationid = c_location_id.SelectedValue.ToString();

            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_MENU_DETAILS_016", con);
            com.CommandType = CommandType.StoredProcedure;
           // com.Parameters.AddWithValue("@i_user_id", userselectedvalue);
            com.Parameters.AddWithValue("@i_company_id", companyid);
            com.Parameters.AddWithValue("@i_location_id", locationid);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);


            for (int j = 0; j < ds.Tables.Count; j++)
            {
                DataTable dt = ds.Tables[j];

                if (j == 0)
                {
                    for (int k = 0; k < dt.Rows.Count; k++)
                    {
                        int i_modul_id = Convert.ToInt32(dt.Rows[k]["o_module_id"].ToString());
                        string i_modul_code = dt.Rows[k]["o_module_code"].ToString();
                        string i_modul_name = dt.Rows[k]["o_module_name"].ToString();
                        int i_parent = Convert.ToInt32(dt.Rows[k]["o_parent"].ToString());
                        string i_modul_form_mapped = dt.Rows[k]["o_module_form_mapped"].ToString();
                        int i_module_active = Convert.ToInt32(dt.Rows[k]["o_module_active"].ToString());
                        int i_company_id = Convert.ToInt32(dt.Rows[k]["o_company_id"].ToString());
                        int i_location_id = Convert.ToInt32(dt.Rows[k]["o_location_id"].ToString());

                        SqlCommand com1 = new SqlCommand("SP_USER_MODULE_MAPPED_INSERT_017", con);
                        com1.CommandType = CommandType.StoredProcedure;
                        com1.Parameters.AddWithValue("@i_modul_id", i_modul_id);
                        com1.Parameters.AddWithValue("@i_modul_code", i_modul_code);
                        com1.Parameters.AddWithValue("@i_module_name", i_modul_name);
                        com1.Parameters.AddWithValue("@i_parent", i_parent);
                        com1.Parameters.AddWithValue("@i_module_form_mapped", i_modul_form_mapped);
                        com1.Parameters.AddWithValue("@i_module_active", i_module_active);
                        com1.Parameters.AddWithValue("@i_user_id", userselectedvalue);
                        com1.Parameters.AddWithValue("@company_id", i_company_id);
                        com1.Parameters.AddWithValue("@location_id", i_location_id);
                        com1.ExecuteNonQuery();


                    }

                }

                if (j == 1)
                {
                    for (int k = 0; k < dt.Rows.Count; k++)
                    {
                        int i_main_menu_id = Convert.ToInt32(dt.Rows[k]["o_menu_id"].ToString());
                        string i_main_menu_code = dt.Rows[k]["o_menu_code"].ToString();
                        string i_main_menu_name = dt.Rows[k]["o_menu_name"].ToString();
                        int i_main_menu_module_id = Convert.ToInt32(dt.Rows[k]["o_module_id"].ToString());
                        string i_main_menu_form_mapped = dt.Rows[k]["o_module_form_mapped"].ToString();
                        int i_menu_active = Convert.ToInt32(dt.Rows[k]["o_menu_active"].ToString());
                        int i_company_id = Convert.ToInt32(dt.Rows[k]["o_company_id"].ToString());
                        int i_location_id = Convert.ToInt32(dt.Rows[k]["o_location_id"].ToString());

                        SqlCommand com1 = new SqlCommand("SP_USER_MAIN_MENU_MAPPED_INSERT_018", con);
                        com1.CommandType = CommandType.StoredProcedure;
                        com1.Parameters.AddWithValue("@i_menu_id", i_main_menu_id);
                        com1.Parameters.AddWithValue("@i_menu_code", i_main_menu_code);
                        com1.Parameters.AddWithValue("@i_menu_name", i_main_menu_name);
                        com1.Parameters.AddWithValue("@i_module_id", i_main_menu_module_id);
                        com1.Parameters.AddWithValue("@i_menu_form_mapped", i_main_menu_form_mapped);
                        com1.Parameters.AddWithValue("@i_menu_active", i_menu_active);
                        com1.Parameters.AddWithValue("@i_user_id", userselectedvalue);
                        com1.Parameters.AddWithValue("@company_id", i_company_id);
                        com1.Parameters.AddWithValue("@location_id", i_location_id);
                        com1.ExecuteNonQuery();


                    }

                }

                if (j == 2)
                {
                    for (int k = 0; k < dt.Rows.Count; k++)
                    {
                        int i_sub_menu_id = Convert.ToInt32(dt.Rows[k]["o_submenu_id"].ToString());
                        string i_submenu_code = dt.Rows[k]["o_submenu_code"].ToString();
                        string i_submenu_name = dt.Rows[k]["o_submenu_name"].ToString();
                        int i_sub_menu__id = Convert.ToInt32(dt.Rows[k]["o_parent"].ToString());
                        int i_sub_menu_module_id = Convert.ToInt32(dt.Rows[k]["o_module_id"].ToString());
                        string i_sub_menu_form_mapped = dt.Rows[k]["o_submenu_form_mapped"].ToString();
                        int i_submenu_active = Convert.ToInt32(dt.Rows[k]["o_submenu_active"].ToString());
                        int i_company_id = Convert.ToInt32(dt.Rows[k]["o_company_id"].ToString());
                        int i_location_id = Convert.ToInt32(dt.Rows[k]["o_location_id"].ToString());


                        SqlCommand com1 = new SqlCommand("SP_USER_SUB_MENU_MAPPED_INSERT_019", con);
                        com1.CommandType = CommandType.StoredProcedure;
                        com1.Parameters.AddWithValue("@i_menu_id", i_sub_menu_id);
                        com1.Parameters.AddWithValue("@i_menu_code", i_submenu_code);
                        com1.Parameters.AddWithValue("@i_menu_name", i_submenu_name);
                        com1.Parameters.AddWithValue("@i_sub_menu_id", i_sub_menu__id);
                        com1.Parameters.AddWithValue("@i_module_id", i_sub_menu_module_id);
                        com1.Parameters.AddWithValue("@i_menu_form_mapped", i_sub_menu_form_mapped);
                        com1.Parameters.AddWithValue("@i_menu_active", i_submenu_active);
                        com1.Parameters.AddWithValue("@i_user_id", userselectedvalue);
                        com1.Parameters.AddWithValue("@company_id", i_company_id);
                        com1.Parameters.AddWithValue("@location_id", i_location_id);
                        com1.ExecuteNonQuery();
                    }
                }
            }
            con.Close();
            PopulateTreeView(treeView2.Nodes, 0, g_MappedMenus);
            this.treeView2.ExpandAll();
            l_message_log.Visible = true;
            l_message_log.Text = "Successfully Transferd";

            location_load();
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void c_user_name_SelectedIndexChanged(object sender, EventArgs e)
        {


            //b_get_active_menu.PerformClick();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c_company_name_KeyDown(object sender, KeyEventArgs e)
        {
            dt_GetLocation.Rows.Clear();
            string companyid = c_company_name.SelectedValue.ToString();
            con.Open();
            SqlCommand com = new SqlCommand("SP_LOCATION_MAPPED_004", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_company_id", companyid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_GetLocation);

            if (dt_GetLocation.Rows.Count >= 1)
            {
                c_location_id.DisplayMember = "o_location_name";
                c_location_id.ValueMember = "o_location_id";
                c_location_id.DataSource = dt_GetLocation;
                c_location_id.Select();
                c_company_name.Enabled = false;
                c_location_id.Select();

            }
            con.Close();
        }

        private void c_location_id_KeyDown(object sender, KeyEventArgs e)
        {
            location_load();
        }

        private void location_load()
        {
            g_menus.Rows.Clear();
            g_userselected = c_user_name.SelectedValue.ToString();
            string companyid = c_company_name.SelectedValue.ToString();
            string location = c_location_id.SelectedValue.ToString();
            SqlCommand com2 = new SqlCommand("SP_USER_MENU_020", con);
            com2.CommandType = CommandType.StoredProcedure;
            //com2.Parameters.AddWithValue("@user_id", g_userselected);
            com2.Parameters.AddWithValue("@company_id", companyid);
            com2.Parameters.AddWithValue("@location_id", location);
            SqlDataAdapter da2 = new SqlDataAdapter(com2);


            da2.Fill(g_menus);

            if (g_menus.Rows.Count > 0)
            {
                tree_menu_list.Nodes.Clear();
                PopulateTreeView(tree_menu_list.Nodes, 0, g_menus);
                this.tree_menu_list.ExpandAll();
                treeView2.Nodes.Clear();
                c_company_name.Enabled = false;
                c_location_id.Enabled = false;
                c_user_name.Select();
                b_get_active_menu.PerformClick();

            }
            else
            {
                tree_menu_list.Nodes.Clear();
                treeView2.Nodes.Clear();
                //TreeView2();                
            }
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in dt.Select("[parent]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["MenuName"].ToString() + " - " + "[" + dr["MenuId"].ToString() + "]";
                t.Name = dr["MenuId"].ToString();
                t.Tag = dt.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    tree_menu_list.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                PopulateTreeView(Convert.ToInt32(dr["MenuId"].ToString()), childNode);
            }
        }

        private void bt_company_enable_Click(object sender, EventArgs e)
        {
            c_user_name.Enabled = true;
            c_company_name.Enabled = true;
            c_location_id.Enabled = true;
            c_user_name.Select();
            tree_menu_list.Nodes.Clear();
            dgv_user_menu_permissions.DataSource = null;

        }

        private void c_user_name_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
