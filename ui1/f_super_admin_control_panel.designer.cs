
namespace Ui1
{
    partial class f_super_admin_control_panel
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
            this.b_menu_master = new System.Windows.Forms.Button();
            this.b_user_menu_mapped = new System.Windows.Forms.Button();
            this.b_user_event_mapped = new System.Windows.Forms.Button();
            this.b_user_event_master = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_menu_master
            // 
            this.b_menu_master.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_menu_master.Location = new System.Drawing.Point(10, 23);
            this.b_menu_master.Name = "b_menu_master";
            this.b_menu_master.Size = new System.Drawing.Size(95, 66);
            this.b_menu_master.TabIndex = 0;
            this.b_menu_master.Text = "Menu Master";
            this.b_menu_master.UseVisualStyleBackColor = true;
            this.b_menu_master.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_user_menu_mapped
            // 
            this.b_user_menu_mapped.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_user_menu_mapped.Location = new System.Drawing.Point(129, 23);
            this.b_user_menu_mapped.Name = "b_user_menu_mapped";
            this.b_user_menu_mapped.Size = new System.Drawing.Size(95, 66);
            this.b_user_menu_mapped.TabIndex = 1;
            this.b_user_menu_mapped.Text = "Menu Mapping";
            this.b_user_menu_mapped.UseVisualStyleBackColor = true;
            this.b_user_menu_mapped.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_user_event_mapped
            // 
            this.b_user_event_mapped.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_user_event_mapped.Location = new System.Drawing.Point(129, 120);
            this.b_user_event_mapped.Name = "b_user_event_mapped";
            this.b_user_event_mapped.Size = new System.Drawing.Size(95, 66);
            this.b_user_event_mapped.TabIndex = 2;
            this.b_user_event_mapped.Text = "Event Mapping";
            this.b_user_event_mapped.UseVisualStyleBackColor = true;
            this.b_user_event_mapped.Click += new System.EventHandler(this.button3_Click);
            // 
            // b_user_event_master
            // 
            this.b_user_event_master.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_user_event_master.Location = new System.Drawing.Point(10, 120);
            this.b_user_event_master.Name = "b_user_event_master";
            this.b_user_event_master.Size = new System.Drawing.Size(95, 66);
            this.b_user_event_master.TabIndex = 3;
            this.b_user_event_master.Text = "Event Master";
            this.b_user_event_master.UseVisualStyleBackColor = true;
            this.b_user_event_master.Click += new System.EventHandler(this.b_user_event_master_Click);
            // 
            // f_super_admin_control_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(249, 259);
            this.Controls.Add(this.b_user_event_master);
            this.Controls.Add(this.b_user_event_mapped);
            this.Controls.Add(this.b_user_menu_mapped);
            this.Controls.Add(this.b_menu_master);
            this.Name = "f_super_admin_control_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super User Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_menu_master;
        private System.Windows.Forms.Button b_user_menu_mapped;
        private System.Windows.Forms.Button b_user_event_mapped;
        private System.Windows.Forms.Button b_user_event_master;
    }
}