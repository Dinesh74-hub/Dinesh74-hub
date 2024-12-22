
namespace Ui1
{
    partial class f_user_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_user_login));
            this.b_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_password = new System.Windows.Forms.Label();
            this.l_user = new System.Windows.Forms.Label();
            this.b_close = new System.Windows.Forms.Button();
            this.l_company = new System.Windows.Forms.Label();
            this.l_location = new System.Windows.Forms.Label();
            this.c_companyname = new System.Windows.Forms.ComboBox();
            this.c_locationname = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tb_userid = new System.Windows.Forms.TextBox();
            this.l_CompanyCode = new System.Windows.Forms.Label();
            this.l_LocationCode = new System.Windows.Forms.Label();
            this.l_UserCode = new System.Windows.Forms.Label();
            this.l_CompanyName = new System.Windows.Forms.Label();
            this.l_LocationName = new System.Windows.Forms.Label();
            this.l_CompanyId = new System.Windows.Forms.Label();
            this.l_LocationId = new System.Windows.Forms.Label();
            this.l_UserId = new System.Windows.Forms.Label();
            this.l_UserName = new System.Windows.Forms.Label();
            this.p_company_logo = new System.Windows.Forms.PictureBox();
            this.b_clear = new System.Windows.Forms.Button();
            this.l_location_check = new System.Windows.Forms.Label();
            this.l_user_check = new System.Windows.Forms.Label();
            this.l_company_check = new System.Windows.Forms.Label();
            this.l_password_check = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_company_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // b_login
            // 
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.b_login.ForeColor = System.Drawing.Color.Green;
            this.b_login.Location = new System.Drawing.Point(171, 395);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(124, 45);
            this.b_login.TabIndex = 5;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_password.Location = new System.Drawing.Point(174, 269);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(388, 30);
            this.tb_password.TabIndex = 2;
            this.tb_password.Text = "raj@123";
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_password.Location = new System.Drawing.Point(78, 277);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(89, 22);
            this.l_password.TabIndex = 1;
            this.l_password.Text = "Password";
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_user.Location = new System.Drawing.Point(78, 228);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(62, 22);
            this.l_user.TabIndex = 0;
            this.l_user.Text = "UserId";
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.b_close.ForeColor = System.Drawing.Color.Red;
            this.b_close.Location = new System.Drawing.Point(438, 395);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(124, 45);
            this.b_close.TabIndex = 6;
            this.b_close.Text = "X";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // l_company
            // 
            this.l_company.AutoSize = true;
            this.l_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_company.Location = new System.Drawing.Point(78, 326);
            this.l_company.Name = "l_company";
            this.l_company.Size = new System.Drawing.Size(86, 22);
            this.l_company.TabIndex = 6;
            this.l_company.Text = "Company";
            // 
            // l_location
            // 
            this.l_location.AutoSize = true;
            this.l_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_location.Location = new System.Drawing.Point(78, 374);
            this.l_location.Name = "l_location";
            this.l_location.Size = new System.Drawing.Size(78, 22);
            this.l_location.TabIndex = 7;
            this.l_location.Text = "Location";
            // 
            // c_companyname
            // 
            this.c_companyname.FormattingEnabled = true;
            this.c_companyname.Location = new System.Drawing.Point(174, 314);
            this.c_companyname.Name = "c_companyname";
            this.c_companyname.Size = new System.Drawing.Size(388, 28);
            this.c_companyname.TabIndex = 3;
            this.c_companyname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_companyname_KeyDown);
            // 
            // c_locationname
            // 
            this.c_locationname.FormattingEnabled = true;
            this.c_locationname.Location = new System.Drawing.Point(174, 360);
            this.c_locationname.Name = "c_locationname";
            this.c_locationname.Size = new System.Drawing.Size(388, 28);
            this.c_locationname.TabIndex = 4;
            this.c_locationname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_locationname_KeyDown);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(122, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Size = new System.Drawing.Size(1425, 1014);
            this.panel1.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1401, 990);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 27;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tb_userid);
            this.splitContainer2.Panel1.Controls.Add(this.l_CompanyCode);
            this.splitContainer2.Panel1.Controls.Add(this.l_LocationCode);
            this.splitContainer2.Panel1.Controls.Add(this.l_UserCode);
            this.splitContainer2.Panel1.Controls.Add(this.l_CompanyName);
            this.splitContainer2.Panel1.Controls.Add(this.l_LocationName);
            this.splitContainer2.Panel1.Controls.Add(this.l_CompanyId);
            this.splitContainer2.Panel1.Controls.Add(this.l_LocationId);
            this.splitContainer2.Panel1.Controls.Add(this.l_UserId);
            this.splitContainer2.Panel1.Controls.Add(this.l_UserName);
            this.splitContainer2.Panel1.Controls.Add(this.p_company_logo);
            this.splitContainer2.Panel1.Controls.Add(this.b_clear);
            this.splitContainer2.Panel1.Controls.Add(this.b_close);
            this.splitContainer2.Panel1.Controls.Add(this.l_location_check);
            this.splitContainer2.Panel1.Controls.Add(this.l_user_check);
            this.splitContainer2.Panel1.Controls.Add(this.l_company);
            this.splitContainer2.Panel1.Controls.Add(this.l_company_check);
            this.splitContainer2.Panel1.Controls.Add(this.b_login);
            this.splitContainer2.Panel1.Controls.Add(this.l_password_check);
            this.splitContainer2.Panel1.Controls.Add(this.l_location);
            this.splitContainer2.Panel1.Controls.Add(this.tb_password);
            this.splitContainer2.Panel1.Controls.Add(this.c_companyname);
            this.splitContainer2.Panel1.Controls.Add(this.l_user);
            this.splitContainer2.Panel1.Controls.Add(this.c_locationname);
            this.splitContainer2.Panel1.Controls.Add(this.l_password);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeView2);
            this.splitContainer2.Size = new System.Drawing.Size(1206, 990);
            this.splitContainer2.SplitterDistance = 887;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // tb_userid
            // 
            this.tb_userid.Location = new System.Drawing.Point(174, 228);
            this.tb_userid.Name = "tb_userid";
            this.tb_userid.Size = new System.Drawing.Size(388, 26);
            this.tb_userid.TabIndex = 36;
            this.tb_userid.Text = "1";
            this.tb_userid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_userid_KeyDown);
            // 
            // l_CompanyCode
            // 
            this.l_CompanyCode.AutoSize = true;
            this.l_CompanyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_CompanyCode.Location = new System.Drawing.Point(237, 606);
            this.l_CompanyCode.Name = "l_CompanyCode";
            this.l_CompanyCode.Size = new System.Drawing.Size(129, 22);
            this.l_CompanyCode.TabIndex = 34;
            this.l_CompanyCode.Text = "CompanyCode";
            // 
            // l_LocationCode
            // 
            this.l_LocationCode.AutoSize = true;
            this.l_LocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_LocationCode.Location = new System.Drawing.Point(237, 654);
            this.l_LocationCode.Name = "l_LocationCode";
            this.l_LocationCode.Size = new System.Drawing.Size(121, 22);
            this.l_LocationCode.TabIndex = 35;
            this.l_LocationCode.Text = "LocationCode";
            // 
            // l_UserCode
            // 
            this.l_UserCode.AutoSize = true;
            this.l_UserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_UserCode.Location = new System.Drawing.Point(237, 566);
            this.l_UserCode.Name = "l_UserCode";
            this.l_UserCode.Size = new System.Drawing.Size(91, 22);
            this.l_UserCode.TabIndex = 33;
            this.l_UserCode.Text = "UserCode";
            // 
            // l_CompanyName
            // 
            this.l_CompanyName.AutoSize = true;
            this.l_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_CompanyName.Location = new System.Drawing.Point(474, 606);
            this.l_CompanyName.Name = "l_CompanyName";
            this.l_CompanyName.Size = new System.Drawing.Size(133, 22);
            this.l_CompanyName.TabIndex = 31;
            this.l_CompanyName.Text = "CompanyName";
            // 
            // l_LocationName
            // 
            this.l_LocationName.AutoSize = true;
            this.l_LocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_LocationName.Location = new System.Drawing.Point(474, 654);
            this.l_LocationName.Name = "l_LocationName";
            this.l_LocationName.Size = new System.Drawing.Size(125, 22);
            this.l_LocationName.TabIndex = 32;
            this.l_LocationName.Text = "LocationName";
            // 
            // l_CompanyId
            // 
            this.l_CompanyId.AutoSize = true;
            this.l_CompanyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_CompanyId.Location = new System.Drawing.Point(15, 606);
            this.l_CompanyId.Name = "l_CompanyId";
            this.l_CompanyId.Size = new System.Drawing.Size(100, 22);
            this.l_CompanyId.TabIndex = 29;
            this.l_CompanyId.Text = "CompanyId";
            // 
            // l_LocationId
            // 
            this.l_LocationId.AutoSize = true;
            this.l_LocationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_LocationId.Location = new System.Drawing.Point(15, 654);
            this.l_LocationId.Name = "l_LocationId";
            this.l_LocationId.Size = new System.Drawing.Size(92, 22);
            this.l_LocationId.TabIndex = 30;
            this.l_LocationId.Text = "LocationId";
            // 
            // l_UserId
            // 
            this.l_UserId.AutoSize = true;
            this.l_UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_UserId.Location = new System.Drawing.Point(15, 566);
            this.l_UserId.Name = "l_UserId";
            this.l_UserId.Size = new System.Drawing.Size(62, 22);
            this.l_UserId.TabIndex = 27;
            this.l_UserId.Text = "UserId";
            // 
            // l_UserName
            // 
            this.l_UserName.AutoSize = true;
            this.l_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.l_UserName.Location = new System.Drawing.Point(477, 566);
            this.l_UserName.Name = "l_UserName";
            this.l_UserName.Size = new System.Drawing.Size(95, 22);
            this.l_UserName.TabIndex = 28;
            this.l_UserName.Text = "UserName";
            // 
            // p_company_logo
            // 
            this.p_company_logo.Image = ((System.Drawing.Image)(resources.GetObject("p_company_logo.Image")));
            this.p_company_logo.Location = new System.Drawing.Point(84, 68);
            this.p_company_logo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.p_company_logo.Name = "p_company_logo";
            this.p_company_logo.Size = new System.Drawing.Size(468, 129);
            this.p_company_logo.TabIndex = 11;
            this.p_company_logo.TabStop = false;
            // 
            // b_clear
            // 
            this.b_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.b_clear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.b_clear.Location = new System.Drawing.Point(303, 395);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(124, 45);
            this.b_clear.TabIndex = 26;
            this.b_clear.Text = "Clear";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // l_location_check
            // 
            this.l_location_check.AutoSize = true;
            this.l_location_check.Location = new System.Drawing.Point(570, 363);
            this.l_location_check.Name = "l_location_check";
            this.l_location_check.Size = new System.Drawing.Size(0, 20);
            this.l_location_check.TabIndex = 17;
            // 
            // l_user_check
            // 
            this.l_user_check.AutoSize = true;
            this.l_user_check.Location = new System.Drawing.Point(570, 226);
            this.l_user_check.Name = "l_user_check";
            this.l_user_check.Size = new System.Drawing.Size(0, 20);
            this.l_user_check.TabIndex = 14;
            // 
            // l_company_check
            // 
            this.l_company_check.AutoSize = true;
            this.l_company_check.Location = new System.Drawing.Point(570, 315);
            this.l_company_check.Name = "l_company_check";
            this.l_company_check.Size = new System.Drawing.Size(0, 20);
            this.l_company_check.TabIndex = 16;
            // 
            // l_password_check
            // 
            this.l_password_check.AutoSize = true;
            this.l_password_check.Location = new System.Drawing.Point(570, 272);
            this.l_password_check.Name = "l_password_check";
            this.l_password_check.Size = new System.Drawing.Size(0, 20);
            this.l_password_check.TabIndex = 15;
            // 
            // treeView2
            // 
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.ImageIndex = 2;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 6;
            this.treeView2.Size = new System.Drawing.Size(316, 990);
            this.treeView2.TabIndex = 24;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2142682_interface_left_menu_sidebar_window_icon.ico");
            this.imageList1.Images.SetKeyName(1, "1343440_copy_move_paste_square_icon.ico");
            this.imageList1.Images.SetKeyName(2, "85511_diamond_game_icon.ico");
            this.imageList1.Images.SetKeyName(3, "8643400_menu_blue_pink_navigation_location_icon (1).ico");
            this.imageList1.Images.SetKeyName(4, "8643397_switch_blue_pink_power_off_icon.ico");
            this.imageList1.Images.SetKeyName(5, "8643389_settings_blue_pink_options_preferences_icon.ico");
            this.imageList1.Images.SetKeyName(6, "2835260_control_list view_menu_menu select_more_icon.ico");
            // 
            // f_user_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1616, 1006);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_user_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_company_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Label l_company;
        private System.Windows.Forms.Label l_location;
        private System.Windows.Forms.ComboBox c_companyname;
        private System.Windows.Forms.ComboBox c_locationname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox p_company_logo;
        private System.Windows.Forms.Label l_user_check;
        private System.Windows.Forms.Label l_password_check;
        private System.Windows.Forms.Label l_company_check;
        private System.Windows.Forms.Label l_location_check;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label l_CompanyId;
        private System.Windows.Forms.Label l_LocationId;
        private System.Windows.Forms.Label l_UserId;
        private System.Windows.Forms.Label l_UserName;
        private System.Windows.Forms.Label l_CompanyName;
        private System.Windows.Forms.Label l_LocationName;
        private System.Windows.Forms.Label l_CompanyCode;
        private System.Windows.Forms.Label l_LocationCode;
        private System.Windows.Forms.Label l_UserCode;
        private System.Windows.Forms.TextBox tb_userid;

         
    }
}