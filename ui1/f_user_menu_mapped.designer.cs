
namespace Ui1
{
    partial class f_user_menu_mapped

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.c_user_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tree_menu_list = new System.Windows.Forms.TreeView();
            this.b_transfer = new System.Windows.Forms.Button();
            this.l_headermessage = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.l_message_log = new System.Windows.Forms.Label();
            this.bt_company_enable = new System.Windows.Forms.Button();
            this.c_company_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_update = new System.Windows.Forms.Button();
            this.c_location_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.b_get_active_menu = new System.Windows.Forms.Button();
            this.dgv_user_menu_permissions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_menu_permissions)).BeginInit();
            this.SuspendLayout();
            // 
            // c_user_name
            // 
            this.c_user_name.FormattingEnabled = true;
            this.c_user_name.Location = new System.Drawing.Point(159, 20);
            this.c_user_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_user_name.Name = "c_user_name";
            this.c_user_name.Size = new System.Drawing.Size(203, 28);
            this.c_user_name.TabIndex = 0;
            this.c_user_name.SelectedIndexChanged += new System.EventHandler(this.c_user_name_SelectedIndexChanged);
            this.c_user_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_user_name_KeyDown);
            this.c_user_name.Layout += new System.Windows.Forms.LayoutEventHandler(this.c_user_name_Layout);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tree_menu_list
            // 
            this.tree_menu_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_menu_list.Location = new System.Drawing.Point(0, 0);
            this.tree_menu_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree_menu_list.Name = "tree_menu_list";
            this.tree_menu_list.Size = new System.Drawing.Size(291, 988);
            this.tree_menu_list.TabIndex = 2;
            this.tree_menu_list.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tree_menu_list_AfterCheck);
            // 
            // b_transfer
            // 
            this.b_transfer.Location = new System.Drawing.Point(141, 162);
            this.b_transfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_transfer.Name = "b_transfer";
            this.b_transfer.Size = new System.Drawing.Size(148, 31);
            this.b_transfer.TabIndex = 3;
            this.b_transfer.Text = "1. Transfer ";
            this.b_transfer.UseVisualStyleBackColor = true;
            this.b_transfer.Click += new System.EventHandler(this.b_transfer_Click_1);
            // 
            // l_headermessage
            // 
            this.l_headermessage.AutoSize = true;
            this.l_headermessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_headermessage.Location = new System.Drawing.Point(0, 0);
            this.l_headermessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_headermessage.Name = "l_headermessage";
            this.l_headermessage.Size = new System.Drawing.Size(209, 20);
            this.l_headermessage.TabIndex = 4;
            this.l_headermessage.Text = "Menu Available For Mapping";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1225, 1048);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.l_headermessage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tree_menu_list);
            this.splitContainer2.Size = new System.Drawing.Size(291, 1048);
            this.splitContainer2.SplitterDistance = 55;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgv_user_menu_permissions);
            this.splitContainer4.Size = new System.Drawing.Size(930, 1048);
            this.splitContainer4.SplitterDistance = 306;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 4;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.l_message_log);
            this.splitContainer3.Panel1.Controls.Add(this.bt_company_enable);
            this.splitContainer3.Panel1.Controls.Add(this.c_company_name);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.b_update);
            this.splitContainer3.Panel1.Controls.Add(this.c_location_id);
            this.splitContainer3.Panel1.Controls.Add(this.b_transfer);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.c_user_name);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.treeView2);
            this.splitContainer3.Panel2.Controls.Add(this.b_get_active_menu);
            this.splitContainer3.Size = new System.Drawing.Size(930, 306);
            this.splitContainer3.SplitterDistance = 260;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 5;
            // 
            // l_message_log
            // 
            this.l_message_log.AutoSize = true;
            this.l_message_log.Location = new System.Drawing.Point(131, 195);
            this.l_message_log.Name = "l_message_log";
            this.l_message_log.Size = new System.Drawing.Size(51, 20);
            this.l_message_log.TabIndex = 7;
            this.l_message_log.Text = "label3";
            // 
            // bt_company_enable
            // 
            this.bt_company_enable.Location = new System.Drawing.Point(399, 14);
            this.bt_company_enable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_company_enable.Name = "bt_company_enable";
            this.bt_company_enable.Size = new System.Drawing.Size(47, 34);
            this.bt_company_enable.TabIndex = 23;
            this.bt_company_enable.Text = "--";
            this.bt_company_enable.UseVisualStyleBackColor = true;
            this.bt_company_enable.Click += new System.EventHandler(this.bt_company_enable_Click);
            // 
            // c_company_name
            // 
            this.c_company_name.FormattingEnabled = true;
            this.c_company_name.Location = new System.Drawing.Point(159, 60);
            this.c_company_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_company_name.Name = "c_company_name";
            this.c_company_name.Size = new System.Drawing.Size(203, 28);
            this.c_company_name.TabIndex = 4;
            this.c_company_name.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.c_company_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_company_name_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(310, 162);
            this.b_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(148, 31);
            this.b_update.TabIndex = 4;
            this.b_update.Text = "2. Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // c_location_id
            // 
            this.c_location_id.AccessibleName = "v";
            this.c_location_id.FormattingEnabled = true;
            this.c_location_id.Location = new System.Drawing.Point(159, 104);
            this.c_location_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c_location_id.Name = "c_location_id";
            this.c_location_id.Size = new System.Drawing.Size(203, 28);
            this.c_location_id.TabIndex = 2;
            this.c_location_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_location_id_KeyDown);
            // 
            // label2
            // 
            this.label2.AccessibleName = "v";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(630, 18);
            this.treeView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(48, 73);
            this.treeView2.TabIndex = 3;
            // 
            // b_get_active_menu
            // 
            this.b_get_active_menu.Location = new System.Drawing.Point(342, 18);
            this.b_get_active_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_get_active_menu.Name = "b_get_active_menu";
            this.b_get_active_menu.Size = new System.Drawing.Size(148, 31);
            this.b_get_active_menu.TabIndex = 6;
            this.b_get_active_menu.Text = "1. Get Menu";
            this.b_get_active_menu.UseVisualStyleBackColor = true;
            this.b_get_active_menu.Click += new System.EventHandler(this.b_get_active_menu_Click);
            // 
            // dgv_user_menu_permissions
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user_menu_permissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_user_menu_permissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_user_menu_permissions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_user_menu_permissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user_menu_permissions.Location = new System.Drawing.Point(0, 0);
            this.dgv_user_menu_permissions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_user_menu_permissions.Name = "dgv_user_menu_permissions";
            this.dgv_user_menu_permissions.RowHeadersWidth = 62;
            this.dgv_user_menu_permissions.RowTemplate.Height = 33;
            this.dgv_user_menu_permissions.Size = new System.Drawing.Size(930, 737);
            this.dgv_user_menu_permissions.TabIndex = 0;
            // 
            // f_user_menu_mapped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1225, 1048);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "f_user_menu_mapped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Menu Mapping";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_menu_permissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox c_user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tree_menu_list;
        private System.Windows.Forms.Button b_transfer;
        private System.Windows.Forms.Label l_headermessage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_get_active_menu;
        private System.Windows.Forms.DataGridView dgv_user_menu_permissions;
        private System.Windows.Forms.Label l_message_log;
        private System.Windows.Forms.ComboBox c_company_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox c_location_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_company_enable;
    }
}