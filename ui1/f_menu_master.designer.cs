﻿
namespace Ui1
{
    partial class f_menu_master
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
            this.components = new System.ComponentModel.Container();
            this.tree_menu_list = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_menu_id = new System.Windows.Forms.TextBox();
            this.b_menu_save = new System.Windows.Forms.Button();
            this.b_menu_update = new System.Windows.Forms.Button();
            this.tb_menu_name = new System.Windows.Forms.TextBox();
            this.l_menu_id = new System.Windows.Forms.Label();
            this.l_menu_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_form_linked = new System.Windows.Forms.Label();
            this.tb_form_linked = new System.Windows.Forms.TextBox();
            this.l_message_log = new System.Windows.Forms.Label();
            this.b_menu_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c_location_id = new System.Windows.Forms.ComboBox();
            this.c_company_name = new System.Windows.Forms.ComboBox();
            this.l_location_id = new System.Windows.Forms.Label();
            this.l_company_id = new System.Windows.Forms.Label();
            this.b_menu_refresh = new System.Windows.Forms.Button();
            this.bt_company_enable = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree_menu_list
            // 
            this.tree_menu_list.ContextMenuStrip = this.contextMenuStrip1;
            this.tree_menu_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_menu_list.Location = new System.Drawing.Point(0, 0);
            this.tree_menu_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree_menu_list.Name = "tree_menu_list";
            this.tree_menu_list.Size = new System.Drawing.Size(463, 782);
            this.tree_menu_list.TabIndex = 0;
            this.tree_menu_list.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_menu_list_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atThisToolStripMenuItem,
            this.underSelectedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 64);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // atThisToolStripMenuItem
            // 
            this.atThisToolStripMenuItem.Name = "atThisToolStripMenuItem";
            this.atThisToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.atThisToolStripMenuItem.Text = "At this Level ";
            this.atThisToolStripMenuItem.Click += new System.EventHandler(this.atThisToolStripMenuItem_Click);
            // 
            // underSelectedToolStripMenuItem
            // 
            this.underSelectedToolStripMenuItem.Name = "underSelectedToolStripMenuItem";
            this.underSelectedToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.underSelectedToolStripMenuItem.Text = "Under Selected";
            this.underSelectedToolStripMenuItem.Click += new System.EventHandler(this.underSelectedToolStripMenuItem_Click);
            // 
            // tb_menu_id
            // 
            this.tb_menu_id.Enabled = false;
            this.tb_menu_id.Location = new System.Drawing.Point(206, 220);
            this.tb_menu_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_menu_id.Name = "tb_menu_id";
            this.tb_menu_id.Size = new System.Drawing.Size(428, 26);
            this.tb_menu_id.TabIndex = 1;
            // 
            // b_menu_save
            // 
            this.b_menu_save.Location = new System.Drawing.Point(206, 353);
            this.b_menu_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_menu_save.Name = "b_menu_save";
            this.b_menu_save.Size = new System.Drawing.Size(100, 34);
            this.b_menu_save.TabIndex = 2;
            this.b_menu_save.Text = "Save";
            this.b_menu_save.UseVisualStyleBackColor = true;
            this.b_menu_save.Click += new System.EventHandler(this.b_menu_save_Click);
            // 
            // b_menu_update
            // 
            this.b_menu_update.Location = new System.Drawing.Point(316, 353);
            this.b_menu_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_menu_update.Name = "b_menu_update";
            this.b_menu_update.Size = new System.Drawing.Size(98, 34);
            this.b_menu_update.TabIndex = 5;
            this.b_menu_update.Text = "Update";
            this.b_menu_update.UseVisualStyleBackColor = true;
            this.b_menu_update.Click += new System.EventHandler(this.b_menu_update_Click);
            // 
            // tb_menu_name
            // 
            this.tb_menu_name.Location = new System.Drawing.Point(206, 266);
            this.tb_menu_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_menu_name.Name = "tb_menu_name";
            this.tb_menu_name.Size = new System.Drawing.Size(428, 26);
            this.tb_menu_name.TabIndex = 7;
            // 
            // l_menu_id
            // 
            this.l_menu_id.AutoSize = true;
            this.l_menu_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.l_menu_id.Location = new System.Drawing.Point(52, 225);
            this.l_menu_id.Name = "l_menu_id";
            this.l_menu_id.Size = new System.Drawing.Size(78, 25);
            this.l_menu_id.TabIndex = 8;
            this.l_menu_id.Text = "Menu Id";
            // 
            // l_menu_name
            // 
            this.l_menu_name.AutoSize = true;
            this.l_menu_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.l_menu_name.Location = new System.Drawing.Point(52, 268);
            this.l_menu_name.Name = "l_menu_name";
            this.l_menu_name.Size = new System.Drawing.Size(109, 25);
            this.l_menu_name.TabIndex = 9;
            this.l_menu_name.Text = "Menu Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 10;
            // 
            // l_form_linked
            // 
            this.l_form_linked.AutoSize = true;
            this.l_form_linked.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.l_form_linked.Location = new System.Drawing.Point(52, 317);
            this.l_form_linked.Name = "l_form_linked";
            this.l_form_linked.Size = new System.Drawing.Size(110, 25);
            this.l_form_linked.TabIndex = 11;
            this.l_form_linked.Text = "Form Linked";
            // 
            // tb_form_linked
            // 
            this.tb_form_linked.Location = new System.Drawing.Point(205, 312);
            this.tb_form_linked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_form_linked.Name = "tb_form_linked";
            this.tb_form_linked.Size = new System.Drawing.Size(428, 26);
            this.tb_form_linked.TabIndex = 12;
            // 
            // l_message_log
            // 
            this.l_message_log.AutoSize = true;
            this.l_message_log.Location = new System.Drawing.Point(206, 406);
            this.l_message_log.Name = "l_message_log";
            this.l_message_log.Size = new System.Drawing.Size(105, 20);
            this.l_message_log.TabIndex = 15;
            this.l_message_log.Text = "Message Log";
            // 
            // b_menu_delete
            // 
            this.b_menu_delete.Location = new System.Drawing.Point(424, 353);
            this.b_menu_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_menu_delete.Name = "b_menu_delete";
            this.b_menu_delete.Size = new System.Drawing.Size(100, 34);
            this.b_menu_delete.TabIndex = 14;
            this.b_menu_delete.Text = "Delete";
            this.b_menu_delete.UseVisualStyleBackColor = true;
            this.b_menu_delete.Click += new System.EventHandler(this.b_menu_delete_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(654, 48);
            this.label5.TabIndex = 13;
            this.label5.Text = "Menu Master / Form Mapping Master";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tree_menu_list);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.bt_company_enable);
            this.splitContainer1.Panel2.Controls.Add(this.c_location_id);
            this.splitContainer1.Panel2.Controls.Add(this.c_company_name);
            this.splitContainer1.Panel2.Controls.Add(this.l_location_id);
            this.splitContainer1.Panel2.Controls.Add(this.l_company_id);
            this.splitContainer1.Panel2.Controls.Add(this.b_menu_refresh);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.l_menu_name);
            this.splitContainer1.Panel2.Controls.Add(this.l_message_log);
            this.splitContainer1.Panel2.Controls.Add(this.tb_menu_name);
            this.splitContainer1.Panel2.Controls.Add(this.b_menu_delete);
            this.splitContainer1.Panel2.Controls.Add(this.b_menu_update);
            this.splitContainer1.Panel2.Controls.Add(this.l_form_linked);
            this.splitContainer1.Panel2.Controls.Add(this.l_menu_id);
            this.splitContainer1.Panel2.Controls.Add(this.b_menu_save);
            this.splitContainer1.Panel2.Controls.Add(this.tb_menu_id);
            this.splitContainer1.Panel2.Controls.Add(this.tb_form_linked);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 782);
            this.splitContainer1.SplitterDistance = 463;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 17;
            // 
            // c_location_id
            // 
            this.c_location_id.FormattingEnabled = true;
            this.c_location_id.Location = new System.Drawing.Point(206, 177);
            this.c_location_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_location_id.Name = "c_location_id";
            this.c_location_id.Size = new System.Drawing.Size(428, 28);
            this.c_location_id.TabIndex = 21;
            this.c_location_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_location_id_KeyDown);
            // 
            // c_company_name
            // 
            this.c_company_name.FormattingEnabled = true;
            this.c_company_name.Location = new System.Drawing.Point(206, 135);
            this.c_company_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_company_name.Name = "c_company_name";
            this.c_company_name.Size = new System.Drawing.Size(428, 28);
            this.c_company_name.TabIndex = 20;
            this.c_company_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_company_name_KeyDown);
            // 
            // l_location_id
            // 
            this.l_location_id.AutoSize = true;
            this.l_location_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.l_location_id.Location = new System.Drawing.Point(52, 175);
            this.l_location_id.Name = "l_location_id";
            this.l_location_id.Size = new System.Drawing.Size(131, 25);
            this.l_location_id.TabIndex = 19;
            this.l_location_id.Text = "Location Name";
            // 
            // l_company_id
            // 
            this.l_company_id.AutoSize = true;
            this.l_company_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.l_company_id.Location = new System.Drawing.Point(52, 136);
            this.l_company_id.Name = "l_company_id";
            this.l_company_id.Size = new System.Drawing.Size(141, 25);
            this.l_company_id.TabIndex = 18;
            this.l_company_id.Text = "Company Name";
            // 
            // b_menu_refresh
            // 
            this.b_menu_refresh.Location = new System.Drawing.Point(535, 353);
            this.b_menu_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_menu_refresh.Name = "b_menu_refresh";
            this.b_menu_refresh.Size = new System.Drawing.Size(100, 34);
            this.b_menu_refresh.TabIndex = 16;
            this.b_menu_refresh.Text = "Refresh";
            this.b_menu_refresh.UseVisualStyleBackColor = true;
            this.b_menu_refresh.Click += new System.EventHandler(this.b_menu_refresh_Click);
            // 
            // bt_company_enable
            // 
            this.bt_company_enable.Location = new System.Drawing.Point(640, 133);
            this.bt_company_enable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_company_enable.Name = "bt_company_enable";
            this.bt_company_enable.Size = new System.Drawing.Size(47, 34);
            this.bt_company_enable.TabIndex = 22;
            this.bt_company_enable.Text = "--";
            this.bt_company_enable.UseVisualStyleBackColor = true;
            this.bt_company_enable.Click += new System.EventHandler(this.bt_company_enable_Click);
            // 
            // f_menu_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 782);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "f_menu_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu  Master";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_menu_list;
        private System.Windows.Forms.TextBox tb_menu_id;
        private System.Windows.Forms.Button b_menu_save;
        private System.Windows.Forms.Button b_menu_update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underSelectedToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_menu_name;
        private System.Windows.Forms.Label l_menu_id;
        private System.Windows.Forms.Label l_menu_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_form_linked;
        private System.Windows.Forms.TextBox tb_form_linked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_menu_delete;
        private System.Windows.Forms.Label l_message_log;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_menu_refresh;
        private System.Windows.Forms.ComboBox c_location_id;
        private System.Windows.Forms.ComboBox c_company_name;
        private System.Windows.Forms.Label l_location_id;
        private System.Windows.Forms.Label l_company_id;
        private System.Windows.Forms.Button bt_company_enable;
    }
}