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
    public partial class f_user_event_mapped : Form
    {
        DataTable g_event = new DataTable();
        DataTable g_user = new DataTable();
        DataTable g_event_data = new DataTable();
        DataTable dt_user_event = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        DataTable dt_GetCompany = new DataTable();
        DataTable dt_GetLocation = new DataTable();
        DataTable dt_Getformlink = new DataTable();
        DataTable dt = new DataTable();
        DataTable g_company = new DataTable();
        DataTable g_form = new DataTable();

        public f_user_event_mapped()
        {
            InitializeComponent();
            SqlCommand com = new SqlCommand("SP_GET_USER_023", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(g_user);
            c_user_name.DisplayMember = "o_user_name";
            c_user_name.ValueMember = "o_user_id";
            c_user_name.DataSource = g_user;
            //SP_FORM_WITH_EVENTS_024();
            button3.Visible = false;
            l_message_log.Visible = false;
           // SP_GET_COMPANY_009();
            //SP_GET_LOCATION_010();
            c_user_name.Select();
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
        private void SP_FORM_WITH_EVENTS_024()
        {
            g_event.Rows.Clear();
            tree_event_list.Nodes.Clear();
            con.Open();
            string companyid = c_company_name.SelectedValue.ToString();
            string locationid = c_location_id.SelectedValue.ToString();
            string formid = c_form_id.SelectedValue.ToString();

            SqlCommand com = new SqlCommand("SP_FORM_WITH_EVENTS_024", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_company_id",companyid);
            com.Parameters.AddWithValue("@i_location_id", locationid);
            com.Parameters.AddWithValue("@i_form_id", formid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(g_event);
            PopulateTreeView(tree_event_list.Nodes, 0, g_event);
            this.tree_event_list.ExpandAll();
            con.Close();
            b_get_active_menu.PerformClick();
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
        private void b_get_active_menu_Click(object sender, EventArgs e)
        {
            dt_user_event.Rows.Clear();
            string _user_id = c_user_name.SelectedValue.ToString();
            string companyid = c_company_name.SelectedValue.ToString();
            string locationid = c_location_id.SelectedValue.ToString();
            string formid = c_form_id.SelectedValue.ToString();
            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_USER_EVENT_MAPPED_027", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id", _user_id);
            com.Parameters.AddWithValue("@i_company_id", companyid);
            com.Parameters.AddWithValue("@i_location_id", locationid);
           
            com.Parameters.AddWithValue("@i_form_id", formid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_user_event);

            dgv_user_event_permissions.DataSource = dt_user_event;
            dgv_user_event_permissions.Columns[0].ReadOnly = true;
            dgv_user_event_permissions.Columns[1].ReadOnly = true;
            dgv_user_event_permissions.Columns[2].ReadOnly = true;
            dgv_user_event_permissions.Columns[3].ReadOnly = true;
            dgv_user_event_permissions.Columns[4].ReadOnly = true;
            dgv_user_event_permissions.Columns[5].ReadOnly = false;
            dgv_user_event_permissions.Columns[6].ReadOnly = true;
            dgv_user_event_permissions.Columns[7].ReadOnly = true;
            con.Close();
            l_message_log.Text = "";
        }

        private void b_transfer_Click(object sender, EventArgs e)
        {
            string g_selected_user = c_user_name.SelectedValue.ToString();
            string form_id = c_form_id.SelectedValue.ToString();
            con.Open();
            int count = 1;
            for (int i = 0; i < g_event.Rows.Count; i++)
            {
               // int sno = Convert.ToInt32(g_event.Rows[i]["sno"].ToString());
                int module_id = Convert.ToInt32(g_event.Rows[i]["t_module_id"].ToString());
                string module_name = g_event.Rows[i]["t_module_name"].ToString();
                int parent_id = Convert.ToInt32(g_event.Rows[i]["t_parent_id"].ToString());
                string form_mapped = g_event.Rows[i]["t_form_mapped"].ToString();
                int companyid =Convert.ToInt32(g_event.Rows[i]["t_company_id"].ToString());
                int locationid =Convert.ToInt32( g_event.Rows[i]["t_location_id"].ToString());

                SqlCommand com = new SqlCommand("SP_FORM_WITH_EVENTS_INSERT_025", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i_count", count);
                //com.Parameters.AddWithValue("@i_sno", sno);
                com.Parameters.AddWithValue("@i_module_id", module_id);
                com.Parameters.AddWithValue("@i_module_name", module_name);
                com.Parameters.AddWithValue("@i_parent_id", parent_id);
                com.Parameters.AddWithValue("@i_form_mapped", module_id);
                com.Parameters.AddWithValue("@i_event_id", 1);
                com.Parameters.AddWithValue("@i_user_id", g_selected_user);
                com.Parameters.AddWithValue("@i_company_id", companyid);
                com.Parameters.AddWithValue("@i_location_id", locationid);
                com.Parameters.AddWithValue("@form_id", form_id);
                com.ExecuteNonQuery();
                count = count + 1;

            }
            l_message_log.Visible = true;
            l_message_log.Text = "Transfer Successfully.";
            con.Close();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_user_event_permissions.Rows.Count - 1; i++)
            {
                int _sno = Convert.ToInt32(dgv_user_event_permissions.Rows[i].Cells[0].Value.ToString());
                int _module_id = Convert.ToInt32(dgv_user_event_permissions.Rows[i].Cells[1].Value.ToString());
                string _module_name = (dgv_user_event_permissions.Rows[i].Cells[2].Value.ToString());
                int _parent_id = Convert.ToInt32(dgv_user_event_permissions.Rows[i].Cells[3].Value.ToString());
                string _form_mapped = (dgv_user_event_permissions.Rows[i].Cells[4].Value.ToString());
                string event_id = (dgv_user_event_permissions.Rows[i].Cells[5].Value.ToString());
                int _company_id = Convert.ToInt32(dgv_user_event_permissions.Rows[i].Cells[6].Value.ToString());
                int _location_id = Convert.ToInt32(dgv_user_event_permissions.Rows[i].Cells[7].Value.ToString());

                if (event_id != "")
                {
                    int _active_id = Convert.ToInt32(event_id);
                    con.Open();
                    SqlCommand com = new SqlCommand("SP_UPDATE_USER_EVENT_MAPPED_028", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@i_sno", _sno);
                    com.Parameters.AddWithValue("@i_module_id", _module_id);
                    com.Parameters.AddWithValue("@i_module_name", _module_name);
                    com.Parameters.AddWithValue("@i_parent_id", _parent_id);
                    com.Parameters.AddWithValue("@i_form_mapped", _form_mapped);
                    com.Parameters.AddWithValue("@i_active", _active_id);
                    com.Parameters.AddWithValue("@i_company_id", _company_id);
                    com.Parameters.AddWithValue("@i_location_id", _location_id);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Check Event Active Id", "Event Mapped", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            l_message_log.Visible = true;
            l_message_log.Text = "Updated Successfully.";
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
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
            //tree_event_list.Nodes.Clear();
            //dt.Rows.Clear();
            //string companyid = c_company_name.SelectedValue.ToString();
            //string locationid = c_location_id.SelectedValue.ToString();
            //con.Open();
            //SqlCommand com = new SqlCommand("SP_GET_MENU_MASTER_008", con);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@company_id", companyid);
            //com.Parameters.AddWithValue("@location_id", locationid);
            //SqlDataAdapter da = new SqlDataAdapter(com);
            //da.Fill(dt);
            //con.Close();
            //c_company_name.Enabled = false;
            //c_location_id.Enabled = false;
            //c_user_name.Select();
            //PopulateTreeView(0, null);
            //this.tree_event_list.ExpandAll();

            //SP_FORM_WITH_EVENTS_024();
            //b_get_active_menu.PerformClick();
            string companyid = c_company_name.SelectedValue.ToString();
            string userid=c_user_name.SelectedValue.ToString();
            string locationid=c_location_id.SelectedValue.ToString();

            con.Open();
            SqlCommand com = new SqlCommand("sp_get_form_list",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i_user_id",userid);
            com.Parameters.AddWithValue("@i_company_id",companyid);
            com.Parameters.AddWithValue("@i_location_id",locationid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(g_form);

            c_form_id.DisplayMember = "o_submenu_form_mapped";
            c_form_id.ValueMember = "o_submenu_id";
            c_form_id.DataSource = g_form;

            con.Close();
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
                    tree_event_list.Nodes.Add(t);
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
        }

        private void c_user_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //b_get_active_menu.PerformClick();
        }

        private void c_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            g_company.Rows.Clear();
            string userid = c_user_name.SelectedValue.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                //b_get_active_menu.PerformClick(); 
                con.Open();
                SqlCommand com = new SqlCommand("SP_USER_MAPPED_COMPANY_LIST", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i_user_id", userid);
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

        private void c_form_id_KeyDown(object sender, KeyEventArgs e)
        
        {
            SP_FORM_WITH_EVENTS_024();
        }
    }
}
