
namespace Ui1
{
    partial class f_user_event_mapped
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
            this.tree_event_list = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.bt_company_enable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.c_location_id = new System.Windows.Forms.ComboBox();
            this.l_company_id = new System.Windows.Forms.Label();
            this.c_company_name = new System.Windows.Forms.ComboBox();
            this.l_message_log = new System.Windows.Forms.Label();
            this.b_transfer = new System.Windows.Forms.Button();
            this.l_user = new System.Windows.Forms.Label();
            this.b_update = new System.Windows.Forms.Button();
            this.c_user_name = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_user_event_permissions = new System.Windows.Forms.DataGridView();
            this.b_get_active_menu = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.c_form_id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_event_permissions)).BeginInit();
            this.SuspendLayout();
            // 
            // tree_event_list
            // 
            this.tree_event_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_event_list.Location = new System.Drawing.Point(0, 0);
            this.tree_event_list.Name = "tree_event_list";
            this.tree_event_list.Size = new System.Drawing.Size(325, 882);
            this.tree_event_list.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tree_event_list);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1322, 882);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeView2);
            this.splitContainer2.Size = new System.Drawing.Size(991, 882);
            this.splitContainer2.SplitterDistance = 936;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.c_form_id);
            this.splitContainer3.Panel1.Controls.Add(this.bt_company_enable);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.c_location_id);
            this.splitContainer3.Panel1.Controls.Add(this.l_company_id);
            this.splitContainer3.Panel1.Controls.Add(this.c_company_name);
            this.splitContainer3.Panel1.Controls.Add(this.l_message_log);
            this.splitContainer3.Panel1.Controls.Add(this.b_transfer);
            this.splitContainer3.Panel1.Controls.Add(this.l_user);
            this.splitContainer3.Panel1.Controls.Add(this.b_update);
            this.splitContainer3.Panel1.Controls.Add(this.c_user_name);
            this.splitContainer3.Panel1.Controls.Add(this.button3);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgv_user_event_permissions);
            this.splitContainer3.Panel2.Controls.Add(this.b_get_active_menu);
            this.splitContainer3.Size = new System.Drawing.Size(936, 882);
            this.splitContainer3.SplitterDistance = 292;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 11;
            // 
            // bt_company_enable
            // 
            this.bt_company_enable.Location = new System.Drawing.Point(449, 10);
            this.bt_company_enable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_company_enable.Name = "bt_company_enable";
            this.bt_company_enable.Size = new System.Drawing.Size(47, 34);
            this.bt_company_enable.TabIndex = 23;
            this.bt_company_enable.Text = "--";
            this.bt_company_enable.UseVisualStyleBackColor = true;
            this.bt_company_enable.Click += new System.EventHandler(this.bt_company_enable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Location Id";
            // 
            // c_location_id
            // 
            this.c_location_id.FormattingEnabled = true;
            this.c_location_id.Location = new System.Drawing.Point(145, 104);
            this.c_location_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.c_location_id.Name = "c_location_id";
            this.c_location_id.Size = new System.Drawing.Size(244, 28);
            this.c_location_id.TabIndex = 13;
            this.c_location_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_location_id_KeyDown);
            // 
            // l_company_id
            // 
            this.l_company_id.AutoSize = true;
            this.l_company_id.Location = new System.Drawing.Point(8, 66);
            this.l_company_id.Name = "l_company_id";
            this.l_company_id.Size = new System.Drawing.Size(94, 20);
            this.l_company_id.TabIndex = 12;
            this.l_company_id.Text = "Company Id";
            // 
            // c_company_name
            // 
            this.c_company_name.FormattingEnabled = true;
            this.c_company_name.Location = new System.Drawing.Point(145, 63);
            this.c_company_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.c_company_name.Name = "c_company_name";
            this.c_company_name.Size = new System.Drawing.Size(244, 28);
            this.c_company_name.TabIndex = 11;
            this.c_company_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_company_name_KeyDown);
            // 
            // l_message_log
            // 
            this.l_message_log.AutoSize = true;
            this.l_message_log.Location = new System.Drawing.Point(65, 256);
            this.l_message_log.Name = "l_message_log";
            this.l_message_log.Size = new System.Drawing.Size(51, 20);
            this.l_message_log.TabIndex = 10;
            this.l_message_log.Text = "label2";
            // 
            // b_transfer
            // 
            this.b_transfer.Location = new System.Drawing.Point(57, 222);
            this.b_transfer.Name = "b_transfer";
            this.b_transfer.Size = new System.Drawing.Size(122, 31);
            this.b_transfer.TabIndex = 5;
            this.b_transfer.Text = "1. Transfer ";
            this.b_transfer.UseVisualStyleBackColor = true;
            this.b_transfer.Click += new System.EventHandler(this.b_transfer_Click);
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(53, 19);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(43, 20);
            this.l_user.TabIndex = 3;
            this.l_user.Text = "User";
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(201, 222);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(100, 31);
            this.b_update.TabIndex = 8;
            this.b_update.Text = "2. Update ";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // c_user_name
            // 
            this.c_user_name.FormattingEnabled = true;
            this.c_user_name.Location = new System.Drawing.Point(145, 16);
            this.c_user_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.c_user_name.Name = "c_user_name";
            this.c_user_name.Size = new System.Drawing.Size(244, 28);
            this.c_user_name.TabIndex = 2;
            this.c_user_name.SelectedIndexChanged += new System.EventHandler(this.c_user_name_SelectedIndexChanged);
            this.c_user_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_user_name_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(895, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgv_user_event_permissions
            // 
            this.dgv_user_event_permissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_event_permissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user_event_permissions.Location = new System.Drawing.Point(0, 0);
            this.dgv_user_event_permissions.Name = "dgv_user_event_permissions";
            this.dgv_user_event_permissions.RowHeadersWidth = 62;
            this.dgv_user_event_permissions.RowTemplate.Height = 33;
            this.dgv_user_event_permissions.Size = new System.Drawing.Size(936, 584);
            this.dgv_user_event_permissions.TabIndex = 9;
            // 
            // b_get_active_menu
            // 
            this.b_get_active_menu.Location = new System.Drawing.Point(396, -10);
            this.b_get_active_menu.Name = "b_get_active_menu";
            this.b_get_active_menu.Size = new System.Drawing.Size(100, 31);
            this.b_get_active_menu.TabIndex = 6;
            this.b_get_active_menu.Text = "1. Get ";
            this.b_get_active_menu.UseVisualStyleBackColor = true;
            this.b_get_active_menu.Click += new System.EventHandler(this.b_get_active_menu_Click);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(3, 3);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(32, 78);
            this.treeView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Form Id";
            // 
            // c_form_id
            // 
            this.c_form_id.FormattingEnabled = true;
            this.c_form_id.Location = new System.Drawing.Point(145, 151);
            this.c_form_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.c_form_id.Name = "c_form_id";
            this.c_form_id.Size = new System.Drawing.Size(244, 28);
            this.c_form_id.TabIndex = 24;
            this.c_form_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_form_id_KeyDown);
            // 
            // f_user_event_mapped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1322, 882);
            this.Controls.Add(this.splitContainer1);
            this.Name = "f_user_event_mapped";
            this.Text = "User Event Mapped";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_event_permissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree_event_list;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button b_get_active_menu;
        private System.Windows.Forms.Button b_transfer;
        private System.Windows.Forms.ComboBox c_user_name;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.DataGridView dgv_user_event_permissions;
        private System.Windows.Forms.Label l_message_log;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c_location_id;
        private System.Windows.Forms.Label l_company_id;
        private System.Windows.Forms.ComboBox c_company_name;
        private System.Windows.Forms.Button bt_company_enable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_form_id;
    }
}