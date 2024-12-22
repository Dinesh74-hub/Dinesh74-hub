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

    public partial class f_event_master : Form
    {
        public static string UserID1 = f_user_login.g_user_id;
        SqlDataAdapter _adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt_GetCompany = new DataTable();
        DataTable dt_GetLocation = new DataTable();
        DataTable dt_event_link = new DataTable();
        TreeNode _selectedNode = null;
        bool _newNode, _thisLevel, _update;
        int _parent = -1;

        bool Module = false;
        bool Forms = false;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public f_event_master()
        {
            InitializeComponent();
          //  SP_GET_EVENT_MASTER_040();
            l_message_log.Visible = false;
            SP_GET_COMPANY_009();
            SP_GET_LOCATION_010();
            c_company_name.Select();
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
        private void SP_GET_EVENT_MASTER_040()
        {
            tree_menu_list.Nodes.Clear();
            string companyid = c_company_name.SelectedValue.ToString();
            string locationid = c_location_id.SelectedValue.ToString();
            try
            {
                dt.Rows.Clear();
                con.Open();

                SqlCommand com = new SqlCommand("SP_GET_EVENT_MASTER_040", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i_company_id",companyid);
                com.Parameters.AddWithValue("@i_location_id", locationid);

                _adapter = new SqlDataAdapter(com);
                _adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            PopulateTreeView_Event(0, null);
            this.tree_menu_list.ExpandAll();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedNode = tree_menu_list.SelectedNode;
            ShowNodeData(_selectedNode);
        }
        private void ShowNodeData(TreeNode nod)
        {
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[int.Parse(nod.Tag.ToString())];
                tb_event_id.Text = r["EventId"].ToString();
                tb_event_name.Text = r["EventName"].ToString();
            }
            tb_event_name.Focus();
        }

        private void PopulateTreeView_Event(int parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in dt.Select("[parent]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["EventName"].ToString() + " - " + "[" + dr["EventId"].ToString() + "]";
                t.Name = dr["EventId"].ToString();
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
                PopulateTreeView_Event(Convert.ToInt32(dr["EventId"].ToString()), childNode);
            }
        }
        void SP_EVENT_INSERT_011()
        {
            try
            {
                con.Open();
                string eventname = tb_event_name.Text;
                //string menuid = menuname.Substring(0, 2);
                string company_id = c_company_name.SelectedValue.ToString();
                string location_id = c_location_id.SelectedValue.ToString();
                string eventid = tb_event_id.Text;
                string username = tb_event_name.Text;
                string event_navigation = tb_event_linked.Text;

                if (eventid != "")
                {
                    if (eventname != "")
                    {
                        //if (form_navigation != "")
                        //{
                        SqlCommand com = new SqlCommand("SP_EVENT_INSERT_041", con);
                            com.CommandType = CommandType.StoredProcedure;
                            com.Parameters.AddWithValue("@Eventid", eventid);
                            com.Parameters.AddWithValue("@Eventname", eventname);
                            //com.Parameters.AddWithValue("@Userid", UserID1);
                            com.Parameters.AddWithValue("@Parent", _parent);
                            //com.Parameters.AddWithValue("@Eventname", menuname);
                            com.Parameters.AddWithValue("@company_id", company_id);
                            com.Parameters.AddWithValue("@location_id", location_id);
                            com.Parameters.AddWithValue("@event_navigation", event_navigation);
                            com.Parameters.AddWithValue("@event_active", 0);
                            int i = com.ExecuteNonQuery();

                            if (i >= 1)
                            {
                                l_message_log.ForeColor = Color.Green;


                                l_message_log.Visible = true;
                                l_message_log.Text = "Inserted Successfully";


                            }
                            else
                            {
                                l_message_log.ForeColor = Color.Red;
                                l_message_log.Visible = true;
                                l_message_log.Text = "Insert Failed";
                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Please Enter Form", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Event Name", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Event Id", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Result:" + ex.Message);
            }
            con.Close();

            clear();
        }
        private void clear()
        {
            tb_event_id.Text = "";
            tb_event_name.Text = "";
            //SP_GET_COMPANY_009();
           // SP_GET_LOCATION_010();
            tb_event_linked.Text = "";
        }
        void SP_EVENT_MASTER_UPDATE_43()
        {
            try
            {
                string eventname = tb_event_name.Text;
                //string menuid = menuname.Substring(0, 2);
                string company_id = c_company_name.SelectedValue.ToString();
                string location_id = c_location_id.SelectedValue.ToString();
                string eventid = tb_event_id.Text;
                string username = tb_event_name.Text;
                string event_navigation = tb_event_linked.Text;

                if (eventid != "")
                {

                    if (eventname != "")
                    {

                        if (event_navigation != "")
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SP_EVENT_MASTER_UPDATE_043", con);
                            com.CommandType = CommandType.StoredProcedure;

                            com.Parameters.AddWithValue("@Eventid", eventid);
                            com.Parameters.AddWithValue("@Eventname", eventname);
                            com.Parameters.AddWithValue("@Parent", _parent);
                            com.Parameters.AddWithValue("@company_id", company_id);
                            com.Parameters.AddWithValue("@location_id", location_id);
                            com.Parameters.AddWithValue("@event_navigation", event_navigation);

                            int i = com.ExecuteNonQuery();
                            con.Close();
                            if (i >= 1)
                            {
                                l_message_log.ForeColor = Color.Green;


                                l_message_log.Visible = true;
                                l_message_log.Text = "Updated Successfully";


                            }
                            else
                            {
                                l_message_log.ForeColor = Color.Red;
                                l_message_log.Visible = true;
                                l_message_log.Text = "Update Failed";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Form Event link", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                
                    else
                    {
                        MessageBox.Show("Please Enter Event Name", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


                else
                {
                    MessageBox.Show("Please Enter Event Id", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Result:" + ex.Message);
            }
        }
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Visible = true;
            _selectedNode = tree_menu_list.SelectedNode;
            ShowNodeData(_selectedNode);
        }

        private void underSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                /*Add menu  UTILITIES -- UT0001
                //_selectedNode = treeView1.SelectedNode;
                //string nodevalue = _selectedNode.ToString();
                //string selectednodid = nodevalue.Substring(10, 2);*/

                DataRow r = dt.Rows[int.Parse(tree_menu_list.SelectedNode.Tag.ToString())];
                // if (r["type"].ToString().Equals("Parent Account"))
                // {
                _newNode = true;
                _thisLevel = false;
                string code = string.Empty;
                _parent = int.Parse(dt.Rows[int.Parse(_selectedNode.Tag.ToString())]["EventId"].ToString());

                if (_selectedNode.Nodes.Count > 0)
                {

                    DataRow[] nodes = dt.Select("[parent]=" + _parent);
                    int max = 0;
                    foreach (DataRow ra in nodes)
                    {
                        int n = int.Parse(ra["EventId"].ToString());
                        if (n > max)
                            max = n;

                    }
                    max += 1;
                    // textBox1.Text = selectednodid+ max.ToString();
                    tb_event_id.Text = max.ToString();
                    code = max.ToString();
                }
                else
                {
                    if (_selectedNode.Level < 3)
                        code = "01";
                    else
                        code = "001";

                    // textBox1.Text = selectednodid+ r["MenuId"] + code;
                    tb_event_id.Text = r["EventId"] + code;
                }
                tb_event_name.Focus();

                Forms = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Result:" + ex);
            }
        }

        void SP_EVENT_MASTER_DELETE_044()
        {
            try
            {
                string eventid = tb_event_id.Text;


                if (eventid != "")
                {

                    con.Open();
                    int nodelevel = _selectedNode.Level;
                    SqlCommand com = new SqlCommand("SP_EVENT_MASTER_DELETE_044", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Eventid", eventid);
                    //  com.Parameters.AddWithValue("@Selectednode", nodelevel);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    string status = dt.Rows[0]["Status"].ToString();
                    con.Close();
                    if (status == "Success")
                    {
                        l_message_log.Visible = true;
                        l_message_log.ForeColor = Color.Green;
                        l_message_log.Text = "Deleted Successfully";

                    }
                    else
                    {
                        l_message_log.Visible = true;
                        l_message_log.ForeColor = Color.Red;
                        l_message_log.Text = "Delete Failed \n\nYou can't delete parent directly.";
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Id", "Event Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Result:" + ex.Message);
            }
        }
        private void b_menu_save_Click(object sender, EventArgs e)
        {
            //SP_MENU_INSERT_011();
        }
        private void b_menu_update_Click(object sender, EventArgs e)
        {
            SP_EVENT_MASTER_UPDATE_43();
            clear();
        }
        private void b_menu_delete_Click(object sender, EventArgs e)
        {
            SP_EVENT_MASTER_DELETE_044();
            clear();
        }
        private void b_menu_refresh_Click(object sender, EventArgs e)
        {
            //SP_GET_MENU_MASTER_008();
        }
        private void tree_menu_list_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tree_menu_list.SelectedNode = e.Node;
            _selectedNode = tree_menu_list.SelectedNode;
            string eventid = e.Node.Text;
            int event_with_start_index = eventid.IndexOf('[');
            int event_with_end_index = eventid.IndexOf(']');
            event_with_start_index = event_with_start_index + 1;
            event_with_end_index = event_with_end_index - event_with_start_index;

            string event_id = eventid.Substring(event_with_start_index, event_with_end_index);


            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_EVENT_LEVELNAME_42", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@event_id", event_id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt_event_link);
            for (int i = 0; i < dt_event_link.Rows.Count; i++)
            {
                tb_event_linked.Text = dt_event_link.Rows[i]["event_level_name"].ToString();
            }
                con.Close();

            ShowNodeData(_selectedNode);
        }
        private void atThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedNode = tree_menu_list.SelectedNode;
                int max = 0;
                if (tree_menu_list.Nodes.Count > 0)
                {
                    _parent = int.Parse(dt.Rows[int.Parse(_selectedNode.Tag.ToString())]["parent"].ToString());
                    DataRow[] nodes = dt.Select("[parent]=" + _parent);

                    foreach (DataRow r in nodes)
                    {
                        int n = int.Parse(r["EventId"].ToString());
                        if (n > max)
                            max = n;
                    }
                }
                else
                {
                    _parent = 0;
                }
                max += 1;
                tb_event_id.Text = max.ToString();
                _newNode = true;
                _thisLevel = true;
                tb_event_name.Focus();

                Module = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Result:" + ex.Message);
            }
        }

        
         

        private void b_event_refresh_Click(object sender, EventArgs e)
        {
            SP_GET_EVENT_MASTER_040();
            l_message_log.Text = "";
            clear();
        }

        private void b_event_save_Click(object sender, EventArgs e)
        {
            SP_EVENT_INSERT_011();
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
            //tree_menu_list.Nodes.Clear();
            //dt.Rows.Clear();
            //string companyid = c_company_name.SelectedValue.ToString();
            //string locationid = c_location_id.SelectedValue.ToString();
            //con.Open();
            //SqlCommand com = new SqlCommand("SP_GET_EVENT_MASTER_040", con);
            //com.CommandType = CommandType.StoredProcedure;
            ////com.Parameters.AddWithValue("@company_id", companyid);
            ////com.Parameters.AddWithValue("@location_id", locationid);
            //SqlDataAdapter da = new SqlDataAdapter(com);
            //da.Fill(dt);
            //con.Close();
            //PopulateTreeView(0, null);
            //this.tree_menu_list.ExpandAll();

            SP_GET_EVENT_MASTER_040();
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
            c_company_name.Enabled = true;
        }
    }
}
