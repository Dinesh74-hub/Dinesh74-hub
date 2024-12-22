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
    public partial class f_company_master : Form
    {
        string selected_event = "";
        string select_parent = "";
        DataTable Data = new DataTable();
        DataTable g_company = new DataTable();
        DataTable g_location = new DataTable();
        DataTable g_locationAll = new DataTable();
        DataTable g_taxmaster = new DataTable();
        DataTable g_currencymaster = new DataTable();
        DataTable g_LoadIdNumber = new DataTable();
        DataTable g_company_last_record = new DataTable();
        DataTable g_location_last_record = new DataTable();
        DataSet g_Last_Record = new DataSet();
        DataSet g_First_Record = new DataSet();
        DataSet g_Previous_Record = new DataSet();
        DataTable g_company_first_record = new DataTable();
        DataTable g_location_first_record = new DataTable();
        DataTable g_company_previous_record = new DataTable();
        DataTable g_location_previous_record = new DataTable();
        DataSet g_Next_Record = new DataSet();
        DataTable g_company_next_record = new DataTable();
        DataTable g_location_next_record = new DataTable();

        string company_id = "";
        string tax_id = "";
        string location_id = "";
        string currency_id = "";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public f_company_master()
        {
            InitializeComponent();
            label5.Visible = false;
            label7.Visible = false;


            label14.Text = f_user_login.g_company_code;
            label13.Text = f_user_login.g_company_name;
            label12.Text = f_user_login.g_location_name;            
            string g_form_code = f_main_form.form_code ;
            string _user_id = f_user_login.g_user_id;
            string _company_id = f_user_login.g_company_id;
            string _location_id = f_user_login.g_location_id;

            DataTable eventtable = new DataTable();
            con.Open();
            SqlCommand com = new SqlCommand("SP_FORM_EVENTS_029", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user_id", _user_id);
            com.Parameters.AddWithValue("@company_id", _company_id);
            com.Parameters.AddWithValue("@location_id", _location_id);
            com.Parameters.AddWithValue("@form_id", g_form_code);

            SqlDataAdapter da = new SqlDataAdapter(com);

            eventtable.Clear();
            da.Fill(eventtable);
            con.Close();


            PopulateTreeViewEvents(treeView1.Nodes, 0, eventtable);

            this.treeView1.ExpandAll();

            GetCompany();
            GetLocation();
            GetLastRecord();
            //LoadIdNumber();

        }
        private void GetLastRecord()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_LAST_RECORD_36", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(g_Last_Record);

            for (int i = 0; i < g_Last_Record.Tables.Count; i++)
            {
                if (i == 0)
                {
                    g_company_last_record = g_Last_Record.Tables[i];

                    for (int j = 0; j < g_company_last_record.Rows.Count; j++)
                    {
                        textBox3.Text = g_company_last_record.Rows[j]["o_company_id"].ToString();
                        textBox1.Text = g_company_last_record.Rows[j]["o_company_code"].ToString();
                        textBox2.Text = g_company_last_record.Rows[j]["o_company_name"].ToString();

                        textBox3.Enabled = false;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                    }
                }

                if (i == 1)
                {
                    //SqlCommand com1 = new SqlCommand("SP_GET_LAST_RECORD_LOCATION_32", con);
                    //com1.CommandType = CommandType.StoredProcedure;
                    //SqlDataAdapter da1 = new SqlDataAdapter(com1);
                    //da1.Fill(g_location_last_record);
                    g_location_last_record = g_Last_Record.Tables[i];

                    for (int k = 0; k < g_location_last_record.Rows.Count; k++)
                    {
                        textBox4.Text = g_location_last_record.Rows[k]["o_location_id"].ToString();
                        textBox5.Text = g_location_last_record.Rows[k]["o_location_code"].ToString();
                        textBox6.Text = g_location_last_record.Rows[k]["o_location_name"].ToString();
                        //textBox4.Text = g_location_last_record.Rows[i]["o_company_id"].ToString();
                        // textBox4.Text = g_location_last_record.Rows["location_id"].ToString();
                    }

                    comboBox1.DisplayMember = "o_company_name";
                    comboBox1.ValueMember = "o_company_id";
                    comboBox1.DataSource = g_location_last_record;

                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    comboBox1.Enabled = false;

                }
            }

                

                con.Close();
              
        }

        private void LoadIdNumberHeader()
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SP_GETID_30", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(g_LoadIdNumber);
                for(int i=0;i < g_LoadIdNumber.Rows.Count;i++)
                {
                     company_id = g_LoadIdNumber.Rows[i]["o_company_count"].ToString();
                    // tax_id = g_LoadIdNumber.Rows[i]["o_tax_count"].ToString();
                     //location_id = g_LoadIdNumber.Rows[i]["o_location_count"].ToString();
                    // currency_id = g_LoadIdNumber.Rows[i]["o_currency_count"].ToString();
                }
                textBox3.Text = company_id.ToString();
               // textBox7.Text = tax_id.ToString();
                textBox4.Text = location_id.ToString();
               // textBox11.Text = currency_id.ToString();

                textBox3.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                

                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadIdNumberTran()
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SP_GETID_30", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(g_LoadIdNumber);
                for (int i = 0; i < g_LoadIdNumber.Rows.Count; i++)
                {
                    //company_id = g_LoadIdNumber.Rows[i]["o_company_count"].ToString();
                    // tax_id = g_LoadIdNumber.Rows[i]["o_tax_count"].ToString();
                    location_id = g_LoadIdNumber.Rows[i]["o_location_count"].ToString();
                    // currency_id = g_LoadIdNumber.Rows[i]["o_currency_count"].ToString();
                }
                textBox3.Text = company_id.ToString();
                // textBox7.Text = tax_id.ToString();
                textBox4.Text = location_id.ToString();
                // textBox11.Text = currency_id.ToString();

                textBox3.Enabled = false;
                textBox7.Enabled = false;
                textBox4.Enabled = false;
                textBox11.Enabled = false;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetLocation()
        {
            try
            {

                con.Open();
                SqlCommand com = new SqlCommand("SP_GET_LOCATION_010", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);

                da.Fill(g_locationAll);
                comboBox4.DisplayMember = "o_location_name";
                comboBox4.ValueMember = "o_location_id";
                comboBox4.DataSource = g_locationAll;

                comboBox6.DisplayMember = "o_location_name";
                comboBox6.ValueMember = "o_location_id";
                comboBox6.DataSource = g_locationAll;
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void GetCompany()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SP_GET_COMPANY_009", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);

            da.Fill(g_company);
            comboBox1.DisplayMember = "o_company_name";
            comboBox1.ValueMember = "o_company_id";
            comboBox1.DataSource = g_company;
            comboBox2.DisplayMember = "o_company_name";
            comboBox2.ValueMember = "o_company_id";
            comboBox2.DataSource = g_company;
            comboBox5.DisplayMember = "o_company_name";
            comboBox5.ValueMember = "o_company_id";
            comboBox5.DataSource = g_company;

            con.Close();
        }
       
        protected void PopulateTreeViewEvents(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {
            foreach (DataRow folder in folders.Rows)
            {
                if (Convert.ToInt32(folder["t_parent_id"]) == parentID)
                {
                    String key = folder["t_module_id"].ToString();
                    String text = folder["t_module_name"].ToString();
                    TreeNodeCollection newParentNode = parentNode.Add(key, text).Nodes;
                    PopulateTreeViewEvents(newParentNode, Convert.ToInt32(folder["t_module_id"]), folders);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("InsertCompanyMaster", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CompanyCode", textBox1.Text);
                com.Parameters.AddWithValue("@CompanyName", textBox2.Text);
                int i = com.ExecuteNonQuery();
                if (i >= 1)
                {
                    label5.Visible = true;
                    label5.Text = "Inserted Successfully";

                }
                else
                {
                    label5.Visible = true;
                    label5.Text = "Inserted Failed";

                }

                con.Close();
                Clear();
                //LoadIdNumber();
            }
            catch (Exception ex)
            {

                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("GetCompanyValuebyId", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Companycode = dt.Rows[i]["CompanyCode"].ToString();
                string Companyname = dt.Rows[i]["CompanyName"].ToString();
                string LocationId = dt.Rows[i]["LocationId"].ToString();

                textBox2.Text = Companyname.ToString();
                textBox1.Enabled = false;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("UpdateCompanyMaster", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Companycode", textBox1.Text);
            com.Parameters.AddWithValue("@Companyname", textBox2.Text);
            int i = com.ExecuteNonQuery();
            if (i >= 1)
            {
                label5.Visible = true;
                label5.Text = "Updated Successfully";


            }
            else
            {
                label5.Visible = true;
                label5.Text = "Updated Failed";

            }
            con.Close();
            Clear();
            //LoadIdNumber();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("DeleteCompanyMasterbyID", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Companycode", textBox1.Text);
                int i = com.ExecuteNonQuery();
                if (i >= 1)
                {
                    label5.Visible = true;
                    label5.Text = "Deleted Successfully";
                }
                else
                {
                    label5.Visible = true;
                    label5.Text = "Deleted Failed";
                }
                con.Close();
               // LoadIdNumber();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           // textBox4.Text = "";
            textBox8.Text="";
            textBox9.Text="";
            textBox10.Text="";
            textBox5.Text="";
            textBox6.Text="";
            textBox12.Text="";
            textBox13.Text="";
            textBox14.Text = "";
            GetCompany();
            GetLocation();

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LabelClear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LabelClear();
        }
        public void LabelClear()
        {
            label5.Text = "";
        }

       

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 3;
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 5;
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                TreeNode node = treeView1.SelectedNode;
                selected_event = node.Text;

                select_parent = node.Parent.Text;

                if (selected_event != "" && select_parent != "")
                {
                    if (select_parent == "HEADER")
                    {
                        if (selected_event == "Last Record")
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SP_GET_LAST_RECORD_36", con);
                            com.CommandType = CommandType.StoredProcedure;
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            da.Fill(g_Last_Record);


                            for (int i = 0; i < g_Last_Record.Tables.Count; i++)
                            {
                                if (i == 0)
                                {
                                    g_company_last_record = g_Last_Record.Tables[i];

                                    for (int j = 0; j < g_company_last_record.Rows.Count; j++)
                                    {
                                        textBox3.Text = g_company_last_record.Rows[j]["o_company_id"].ToString();
                                        textBox1.Text = g_company_last_record.Rows[j]["o_company_code"].ToString();
                                        textBox2.Text = g_company_last_record.Rows[j]["o_company_name"].ToString();

                                        textBox3.Enabled = false;
                                        textBox1.Enabled = false;
                                        textBox2.Enabled = false;
                                    }
                                }

                                //if (i == 1)
                                //{

                                //    g_location_last_record = g_Last_Record.Tables[i];

                                //    for (int k = 0; k < g_location_last_record.Rows.Count; k++)
                                //    {
                                //        textBox4.Text = g_location_last_record.Rows[k]["o_location_id"].ToString();
                                //        textBox5.Text = g_location_last_record.Rows[k]["o_location_code"].ToString();
                                //        textBox6.Text = g_location_last_record.Rows[k]["o_location_name"].ToString();

                                //    }

                                //    comboBox1.DisplayMember = "o_company_name";
                                //    comboBox1.ValueMember = "o_company_id";
                                //    comboBox1.DataSource = g_location_last_record;

                                //    textBox4.Enabled = false;
                                //    textBox5.Enabled = false;
                                //    textBox6.Enabled = false;
                                //    comboBox1.Enabled = false;

                                //}
                            }
                            con.Close();

                        }

                        if (selected_event == "First Record")
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SP_GET_FIRST_RECORD_37", con);
                            com.CommandType = CommandType.StoredProcedure;
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            da.Fill(g_First_Record);


                            for (int i = 0; i < g_First_Record.Tables.Count; i++)
                            {
                                if (i == 0)
                                {
                                    g_company_first_record = g_First_Record.Tables[i];

                                    for (int j = 0; j < g_company_first_record.Rows.Count; j++)
                                    {
                                        textBox3.Text = g_company_first_record.Rows[j]["o_company_id"].ToString();
                                        textBox1.Text = g_company_first_record.Rows[j]["o_company_code"].ToString();
                                        textBox2.Text = g_company_first_record.Rows[j]["o_company_name"].ToString();

                                        textBox3.Enabled = false;
                                        textBox1.Enabled = false;
                                        textBox2.Enabled = false;
                                    }
                                }

                                //if (i == 1)
                                //{

                                //    g_location_first_record = g_First_Record.Tables[i];

                                //    for (int k = 0; k < g_location_first_record.Rows.Count; k++)
                                //    {
                                //        textBox4.Text = g_location_first_record.Rows[k]["o_location_id"].ToString();
                                //        textBox5.Text = g_location_first_record.Rows[k]["o_location_code"].ToString();
                                //        textBox6.Text = g_location_first_record.Rows[k]["o_location_name"].ToString();

                                //    }

                                //    comboBox1.DisplayMember = "o_company_name";
                                //    comboBox1.ValueMember = "o_company_id";
                                //    comboBox1.DataSource = g_location_first_record;

                                //    textBox4.Enabled = false;
                                //    textBox5.Enabled = false;
                                //    textBox6.Enabled = false;
                                //    comboBox1.Enabled = false;

                                //}
                            }
                            con.Close();

                        }

                        if (selected_event == "Previous Record")
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SP_GET_PREVIOUS_RECORD_39", con);
                            com.CommandType = CommandType.StoredProcedure;
                            com.Parameters.AddWithValue("@i_company_id", textBox3.Text);
                            com.Parameters.AddWithValue("@i_location_id", textBox4.Text);
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            da.Fill(g_Previous_Record);


                            for (int i = 0; i < g_Previous_Record.Tables.Count; i++)
                            {
                                if (i == 0)
                                {
                                    g_company_previous_record = g_Previous_Record.Tables[i];

                                    for (int j = 0; j < g_company_previous_record.Rows.Count; j++)
                                    {
                                        textBox3.Text = g_company_previous_record.Rows[j]["o_company_id"].ToString();
                                        textBox1.Text = g_company_previous_record.Rows[j]["o_company_code"].ToString();
                                        textBox2.Text = g_company_previous_record.Rows[j]["o_company_name"].ToString();

                                        textBox3.Enabled = false;
                                        textBox1.Enabled = false;
                                        textBox2.Enabled = false;
                                    }
                                }

                                //if (i == 1)
                                //{

                                //    g_location_previous_record = g_Previous_Record.Tables[i];

                                //    for (int k = 0; k < g_location_previous_record.Rows.Count; k++)
                                //    {
                                //        textBox4.Text = g_location_previous_record.Rows[k]["o_location_id"].ToString();
                                //        textBox5.Text = g_location_previous_record.Rows[k]["o_location_code"].ToString();
                                //        textBox6.Text = g_location_previous_record.Rows[k]["o_location_name"].ToString();

                                //    }

                                //    comboBox1.DisplayMember = "o_company_name";
                                //    comboBox1.ValueMember = "o_company_id";
                                //    comboBox1.DataSource = g_location_previous_record;

                                //    textBox4.Enabled = false;
                                //    textBox5.Enabled = false;
                                //    textBox6.Enabled = false;
                                //    comboBox1.Enabled = false;

                                //}
                            }
                            con.Close();

                        }

                        if (selected_event == "Next Record")
                        {

                            con.Open();
                            SqlCommand com = new SqlCommand("SP_GET_NEXT_RECORD_38", con);
                            com.CommandType = CommandType.StoredProcedure;
                            com.Parameters.AddWithValue("@i_company_id", textBox3.Text);
                            com.Parameters.AddWithValue("@i_location_id", textBox4.Text);
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            da.Fill(g_Next_Record);


                            for (int i = 0; i < g_Next_Record.Tables.Count; i++)
                            {
                                if (i == 0)
                                {
                                    g_company_next_record = g_Next_Record.Tables[i];

                                    for (int j = 0; j < g_company_next_record.Rows.Count; j++)
                                    {
                                        textBox3.Text = g_company_next_record.Rows[j]["o_company_id"].ToString();
                                        textBox1.Text = g_company_next_record.Rows[j]["o_company_code"].ToString();
                                        textBox2.Text = g_company_next_record.Rows[j]["o_company_name"].ToString();

                                        textBox3.Enabled = false;
                                        textBox1.Enabled = false;
                                        textBox2.Enabled = false;
                                    }
                                }

                                //if (i == 1)
                                //{

                                //    g_location_next_record = g_Next_Record.Tables[i];

                                //    for (int k = 0; k < g_location_next_record.Rows.Count; k++)
                                //    {
                                //        textBox4.Text = g_location_next_record.Rows[k]["o_location_id"].ToString();
                                //        textBox5.Text = g_location_next_record.Rows[k]["o_location_code"].ToString();
                                //        textBox6.Text = g_location_next_record.Rows[k]["o_location_name"].ToString();

                                //    }

                                //    comboBox1.DisplayMember = "o_company_name";
                                //    comboBox1.ValueMember = "o_company_id";
                                //    comboBox1.DataSource = g_location_next_record;

                                //    textBox4.Enabled = false;
                                //    textBox5.Enabled = false;
                                //    textBox6.Enabled = false;
                                //    comboBox1.Enabled = false;

                                //}
                            }
                            con.Close();

                        }
                        if (selected_event == "Add")
                        {
                            try
                            {
                              
                                Clear();
                                LoadIdNumberHeader();
                            }
                            catch (Exception ex)
                            {

                                con.Close();
                            }

                        }


                        if (selected_event == "Save")
                        {
                            try
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_COMPANY_MASTER_H_CREATE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_company_id", textBox3.Text);
                                com.Parameters.AddWithValue("@i_company_code", textBox1.Text);
                                com.Parameters.AddWithValue("@i_company_name", textBox2.Text);
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label5.Visible = true;
                                    label7.Visible = true;
                                    label7.Text = "Inserted Successfully";


                                }
                                else
                                {
                                    label5.Visible = true;
                                    label7.Visible = true;
                                    label7.Text = "Inserted Failed";

                                }

                                con.Close();
                                Clear();
                               // LoadIdNumberHeader();
                            }
                            catch (Exception ex)
                            {

                                con.Close();
                            }

                        }

                        else if (selected_event == "Search")
                        {
                            con.Open();
                            SqlCommand com = new SqlCommand("SP_COMPANY_MASTER_H_SEARCH", con);
                            com.CommandType = CommandType.StoredProcedure;
                            com.Parameters.AddWithValue("@i_company_id", textBox3.Text);
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                string g_companycode = dt.Rows[i]["o_company_code"].ToString();
                                string g_companyname = dt.Rows[i]["o_company_name"].ToString();

                                textBox1.Text = g_companycode.ToString();
                                textBox2.Text = g_companyname.ToString();

                                textBox3.Enabled = false;
                            }
                            con.Close();

                        }
                        else if (selected_event == "Edit")
                        { 
                            textBox1.Enabled = true;
                            textBox2.Enabled = true;
                            textBox3.Enabled = false;

                        }
                        else if (selected_event == "Delete")
                        {
                            con.Open();
                            SqlCommand com = new SqlCommand("SP_COMPANY_MASTER_H_DELETE", con);
                            com.CommandType = CommandType.StoredProcedure;
                            com.Parameters.AddWithValue("@i_company_id", Convert.ToInt32(textBox3.Text));
                            int i = com.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                label7.Visible = true;
                                label7.Text = "Deleted Successfully";
                            }
                            else
                            {
                                label7.Visible = true;
                                label7.Text = "Deleted Failed";
                            }
                            con.Close();
                            Clear();
                           // LoadIdNumber();
                        }
                        else if (selected_event == "View")
                        {
                            con.Open();
                            SqlCommand com = new SqlCommand("SP_COMPANY_MASTER_H_RETREIVE", con);
                            com.CommandType = CommandType.StoredProcedure;
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            da.Fill(Data);

                            if (Data.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = Data;
                            }

                            con.Close();


                        }
                    }
                    else if (select_parent == "TRANSACTION")
                    {
                        if (tabControl1.SelectedTab.Text == "LOCATION")
                        {
                            if (selected_event == "Add")
                            {
                                try
                                {
                                    
                                    LoadIdNumberTran();
                                }
                                catch (Exception ex)
                                {

                                    con.Close();
                                }
                            }
                            else if (selected_event == "Save")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_LOCATION_MASTER_T_CREATE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(textBox4.Text));
                                com.Parameters.AddWithValue("@i_location_code", textBox5.Text);
                                com.Parameters.AddWithValue("@i_location_name", textBox6.Text);
                                com.Parameters.AddWithValue("@i_company_id", Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label5.Visible = true;
                                    label7.Visible = true;
                                    label7.Text = "Inserted Successfully";

                                }
                                else
                                {
                                    label5.Visible = true;
                                    label7.Visible = true;
                                    label7.Text = "Inserted Failed";

                                }

                                con.Close();
                                ClearLocation();
                            }
                            else if (selected_event == "Search")
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand("SP_LOCATION_MASTER_T_SEARCH", con);
                                    com.CommandType = CommandType.StoredProcedure;
                                    com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(textBox4.Text));

                                    SqlDataAdapter da = new SqlDataAdapter(com);
                                    da.Fill(g_location);

                                    for (int i = 0; i < g_location.Rows.Count; i++)
                                    {

                                        textBox4.Text = g_location.Rows[i]["o_location_id"].ToString();
                                        textBox5.Text = g_location.Rows[i]["o_location_code"].ToString();
                                        textBox6.Text = g_location.Rows[i]["o_location_name"].ToString();
                                    }
                                    comboBox1.DisplayMember = "o_company_name";
                                    comboBox1.ValueMember = "o_company_id";
                                    comboBox1.DataSource = g_location;
                                    textBox4.Enabled = false;
                                    con.Close();

                                }
                                catch (Exception ex)
                                {

                                    con.Close();
                                }
                            }
                            else if (selected_event == "Edit")
                            {
                                

                                textBox4.Enabled = false;
                                textBox5.Enabled = true;
                                textBox6.Enabled = true;
                                comboBox1.Enabled = true;

                            }
                            else if (selected_event == "Delete")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_LOCATION_MASTER_T_DELETE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(textBox4.Text));
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label7.Visible = true;
                                    label7.Text = "Deleted Successfully";
                                }
                                else
                                {
                                    label7.Visible = true;
                                    label7.Text = "Deleted Failed";
                                }
                                con.Close();
                                ClearLocation();
                                //LoadIdNumber();
                            }
                            else if (selected_event == "View")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_LOCATION_MASTER_T_RETREIVE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                SqlDataAdapter da = new SqlDataAdapter(com);
                                da.Fill(Data);
                                if (Data.Rows.Count > 0)
                                {
                                    dataGridView2.DataSource = Data;
                                }
                                con.Close();


                            }
                        }

                        if (tabControl1.SelectedTab.Text == "TAX")
                        {
                            if (selected_event == "Add")
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand("SP_TAX_MASTER_T_CREATE", con);
                                    com.CommandType = CommandType.StoredProcedure;
                                    com.Parameters.AddWithValue("@i_tax_id", Convert.ToInt32(textBox7.Text));
                                    com.Parameters.AddWithValue("@i_tax_code", textBox8.Text);
                                    com.Parameters.AddWithValue("@i_tax_name", textBox9.Text);
                                    com.Parameters.AddWithValue("@i_tax_percent", textBox10.Text);
                                    com.Parameters.AddWithValue("@i_company_id", Convert.ToInt32(comboBox2.SelectedValue.ToString()));
                                    com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(comboBox4.SelectedValue.ToString()));
                                    int i = com.ExecuteNonQuery();
                                    if (i >= 1)
                                    {
                                        label5.Visible = true;
                                        label7.Visible = true;
                                        label7.Text = "Inserted Successfully";

                                    }
                                    else
                                    {
                                        label5.Visible = true;
                                        label7.Visible = true;
                                        label7.Text = "Inserted Failed";

                                    }

                                    con.Close();
                                    Cleartax();
                                   // LoadIdNumber();
                                }
                                catch (Exception ex)
                                {

                                    con.Close();
                                }
                            }
                            else if (selected_event == "Search")
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand("SP_TAX_MASTER_T_SEARCH", con);
                                    com.CommandType = CommandType.StoredProcedure;
                                    com.Parameters.AddWithValue("@i_tax_id", Convert.ToInt32(textBox7.Text));

                                    SqlDataAdapter da = new SqlDataAdapter(com);
                                    da.Fill(g_taxmaster);

                                    for (int i = 0; i < g_taxmaster.Rows.Count; i++)
                                    {

                                        textBox7.Text = g_taxmaster.Rows[i]["o_tax_id"].ToString();
                                        textBox8.Text = g_taxmaster.Rows[i]["o_tax_code"].ToString();
                                        textBox9.Text = g_taxmaster.Rows[i]["o_tax_name"].ToString();
                                        textBox10.Text = g_taxmaster.Rows[i]["o_tax_percent"].ToString();
                                    }
                                    comboBox2.DisplayMember = "o_company_name";
                                    comboBox2.ValueMember = "o_company_id";
                                    comboBox2.DataSource = g_taxmaster;

                                    comboBox4.DisplayMember = "o_location_name";
                                    comboBox4.ValueMember = "o_location_id";
                                    comboBox4.DataSource = g_taxmaster;

                                    textBox7.Enabled = false;
                                    con.Close();

                                }
                                catch (Exception ex)
                                {

                                    con.Close();
                                }
                            }
                            else if (selected_event == "Edit")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_TAX_MASTER_T_UPDATE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_tax_id", Convert.ToInt32(textBox7.Text));
                                com.Parameters.AddWithValue("@i_tax_code", textBox8.Text);
                                com.Parameters.AddWithValue("@i_tax_name", textBox9.Text);
                                com.Parameters.AddWithValue("@i_tax_percent", textBox10.Text);
                                com.Parameters.AddWithValue("@i_company_id", Convert.ToInt32(comboBox2.SelectedValue.ToString()));
                                com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(comboBox4.SelectedValue.ToString()));
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label7.Visible = true;
                                    label7.Text = "Updated Successfully";


                                }
                                else
                                {
                                    label7.Visible = true;
                                    label7.Text = "Updated Failed";

                                }
                                con.Close();
                                Cleartax();
                                textBox4.Enabled = true;
                              //  LoadIdNumber();

                            }
                            else if (selected_event == "Delete")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_TAX_MASTER_T_DELETE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_tax_id", Convert.ToInt32(textBox7.Text));
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label7.Visible = true;
                                    label7.Text = "Deleted Successfully";
                                }
                                else
                                {
                                    label7.Visible = true;
                                    label7.Text = "Deleted Failed";
                                }
                                con.Close();
                                Cleartax();
                               // LoadIdNumber();
                            }
                            else if (selected_event == "View")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_TAX_MASTER_T_RETREIVE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                SqlDataAdapter da = new SqlDataAdapter(com);
                                da.Fill(Data);

                                if (Data.Rows.Count > 0)
                                {
                                    dataGridView3.DataSource = Data;
                                }


                                con.Close();


                            }
                        }

                        if (tabControl1.SelectedTab.Text == "CURRENCY")
                        {
                            if (selected_event == "Add")
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand("SP_CURRENCY_MASTER_T_CREATE", con);
                                    com.CommandType = CommandType.StoredProcedure;
                                    com.Parameters.AddWithValue("@i_currency_id", Convert.ToInt32(textBox11.Text));
                                    com.Parameters.AddWithValue("@i_currency_code", textBox12.Text);
                                    com.Parameters.AddWithValue("@i_currency_name", textBox13.Text);
                                    com.Parameters.AddWithValue("@i_currency_rate", textBox14.Text);
                                    com.Parameters.AddWithValue("@i_company_id", Convert.ToInt32(comboBox5.SelectedValue.ToString()));
                                    com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(comboBox6.SelectedValue.ToString()));
                                    int i = com.ExecuteNonQuery();
                                    if (i >= 1)
                                    {
                                        label5.Visible = true;
                                        label7.Visible = true;
                                        label7.Text = "Inserted Successfully";

                                    }
                                    else
                                    {
                                        label5.Visible = true;
                                        label7.Visible = true;
                                        label7.Text = "Inserted Failed";

                                    }

                                    con.Close();
                                    ClearCurrency();
                                   // LoadIdNumber();
                                }
                                catch (Exception ex)
                                {

                                    con.Close();
                                }
                            }
                            else if (selected_event == "Search")
                            {
                                try
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand("SP_CURRENCY_MASTER_T_SEARCH", con);
                                    com.CommandType = CommandType.StoredProcedure;
                                    com.Parameters.AddWithValue("@i_currency_id", Convert.ToInt32(textBox11.Text));

                                    SqlDataAdapter da = new SqlDataAdapter(com);
                                    da.Fill(g_currencymaster);

                                    for (int i = 0; i < g_currencymaster.Rows.Count; i++)
                                    {
                                        textBox11.Text = g_currencymaster.Rows[i]["o_currency_id"].ToString();
                                        textBox12.Text = g_currencymaster.Rows[i]["o_currency_code"].ToString();
                                        textBox13.Text = g_currencymaster.Rows[i]["o_currency_name"].ToString();
                                        textBox14.Text = g_currencymaster.Rows[i]["o_currency_rate"].ToString();
                                    }
                                    comboBox5.DisplayMember = "o_company_name";
                                    comboBox5.ValueMember = "o_company_id";
                                    comboBox5.DataSource = g_currencymaster;

                                    comboBox6.DisplayMember = "o_location_name";
                                    comboBox6.ValueMember = "o_location_id";
                                    comboBox6.DataSource = g_currencymaster;

                                    textBox11.Enabled = false;
                                    con.Close();

                                }
                                catch (Exception ex)
                                {

                                    con.Close();
                                }
                            }
                            else if (selected_event == "Edit")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_CURRENCY_MASTER_T_UPDATE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_currency_id", Convert.ToInt32(textBox11.Text));
                                com.Parameters.AddWithValue("@i_currency_code", textBox12.Text);
                                com.Parameters.AddWithValue("@i_currency_name", textBox13.Text);
                                com.Parameters.AddWithValue("@i_currency_rate", textBox14.Text);
                                com.Parameters.AddWithValue("@i_company_id", Convert.ToInt32(comboBox5.SelectedValue.ToString()));
                                com.Parameters.AddWithValue("@i_location_id", Convert.ToInt32(comboBox6.SelectedValue.ToString()));
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label7.Visible = true;
                                    label7.Text = "Updated Successfully";


                                }
                                else
                                {
                                    label7.Visible = true;
                                    label7.Text = "Updated Failed";

                                }
                                con.Close();
                                ClearCurrency();
                                textBox11.Enabled = true;
                                //LoadIdNumber();

                            }
                            else if (selected_event == "Delete")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_CURRENCY_MASTER_T_DELETE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                com.Parameters.AddWithValue("@i_currency_id", Convert.ToInt32(textBox11.Text));
                                int i = com.ExecuteNonQuery();
                                if (i >= 1)
                                {
                                    label7.Visible = true;
                                    label7.Text = "Deleted Successfully";
                                }
                                else
                                {
                                    label7.Visible = true;
                                    label7.Text = "Deleted Failed";
                                }
                                con.Close();
                                ClearCurrency();
                               // LoadIdNumber();
                            }
                            else if (selected_event == "View")
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand("SP_CURRENCY_MASTER_T_RETREIVE", con);
                                com.CommandType = CommandType.StoredProcedure;
                                SqlDataAdapter da = new SqlDataAdapter(com);
                                da.Fill(Data);

                                if (Data.Rows.Count > 0)
                                {
                                    dataGridView4.DataSource = Data;
                                }
                                con.Close();


                            }
                        }
                    }

                    else if (select_parent == "MISCELLANEOUS")
                    {
                        //if (tabControl1.SelectedTab.Text == "LOCATION")
                        //{
                        g_Last_Record.Tables.Clear();
                        g_company_last_record.Rows.Clear();
                        g_location_last_record.Rows.Clear();

                        
                      
                   
                    }

                }
                else
                {
                    MessageBox.Show("Please Select Events");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearLocation()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            GetCompany();
        }
        private void Cleartax()
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            GetCompany();
            GetLocation();
        }

        private void ClearCurrency()
        {
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            GetCompany();
            GetLocation();
        }

       
        private void GetCompanyDetails()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SP_COMPANY_MASTER_H_RETREIVE", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(Data);

            dataGridView1.DataSource = Data;

            con.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //string text = dataGridView1.SelectedRows[0].Cells[0].ToString();
            //txtname.Text = dataGridView1.SelectedRow.Cells[2].Text;
            //txtmarks.Text = dataGridView1.SelectedRow.Cells[3].Text;
            //textBox1.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //textBox2.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();

        }
    }
}
