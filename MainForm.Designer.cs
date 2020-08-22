namespace CardGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.Settings_btn = new FontAwesome.Sharp.IconButton();
            this.Logout_btn = new FontAwesome.Sharp.IconButton();
            this.ManageStorage_btn = new FontAwesome.Sharp.IconButton();
            this.ManageUser_btn = new FontAwesome.Sharp.IconButton();
            this.PrintCard_btn = new FontAwesome.Sharp.IconButton();
            this.Generate_btn = new FontAwesome.Sharp.IconButton();
            this.Home_btn = new FontAwesome.Sharp.IconButton();
            this.HomeLogoPanel = new System.Windows.Forms.Panel();
            this.CompanyLogoHome_pBox = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.sideBarPanel.SuspendLayout();
            this.HomeLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoHome_pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.AutoScroll = true;
            this.sideBarPanel.Controls.Add(this.Settings_btn);
            this.sideBarPanel.Controls.Add(this.Logout_btn);
            this.sideBarPanel.Controls.Add(this.ManageStorage_btn);
            this.sideBarPanel.Controls.Add(this.ManageUser_btn);
            this.sideBarPanel.Controls.Add(this.PrintCard_btn);
            this.sideBarPanel.Controls.Add(this.Generate_btn);
            this.sideBarPanel.Controls.Add(this.Home_btn);
            this.sideBarPanel.Controls.Add(this.HomeLogoPanel);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(183, 528);
            this.sideBarPanel.TabIndex = 0;
            // 
            // Settings_btn
            // 
            this.Settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_btn.FlatAppearance.BorderSize = 0;
            this.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Settings_btn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.Settings_btn.IconColor = System.Drawing.Color.LightGray;
            this.Settings_btn.IconSize = 40;
            this.Settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_btn.Location = new System.Drawing.Point(0, 394);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Settings_btn.Rotation = 0D;
            this.Settings_btn.Size = new System.Drawing.Size(183, 55);
            this.Settings_btn.TabIndex = 8;
            this.Settings_btn.Text = "Settings";
            this.Settings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Logout_btn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Logout_btn.IconColor = System.Drawing.Color.LightGray;
            this.Logout_btn.IconSize = 40;
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.Location = new System.Drawing.Point(0, 473);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logout_btn.Rotation = 0D;
            this.Logout_btn.Size = new System.Drawing.Size(183, 55);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            // 
            // ManageStorage_btn
            // 
            this.ManageStorage_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageStorage_btn.FlatAppearance.BorderSize = 0;
            this.ManageStorage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageStorage_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ManageStorage_btn.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ManageStorage_btn.IconColor = System.Drawing.Color.LightGray;
            this.ManageStorage_btn.IconSize = 40;
            this.ManageStorage_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageStorage_btn.Location = new System.Drawing.Point(0, 339);
            this.ManageStorage_btn.Name = "ManageStorage_btn";
            this.ManageStorage_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManageStorage_btn.Rotation = 0D;
            this.ManageStorage_btn.Size = new System.Drawing.Size(183, 55);
            this.ManageStorage_btn.TabIndex = 5;
            this.ManageStorage_btn.Text = "Manage Storage";
            this.ManageStorage_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageStorage_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageStorage_btn.UseVisualStyleBackColor = true;
            this.ManageStorage_btn.Click += new System.EventHandler(this.ManageStorage_btn_Click);
            // 
            // ManageUser_btn
            // 
            this.ManageUser_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageUser_btn.FlatAppearance.BorderSize = 0;
            this.ManageUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUser_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ManageUser_btn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ManageUser_btn.IconColor = System.Drawing.Color.LightGray;
            this.ManageUser_btn.IconSize = 40;
            this.ManageUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUser_btn.Location = new System.Drawing.Point(0, 284);
            this.ManageUser_btn.Name = "ManageUser_btn";
            this.ManageUser_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManageUser_btn.Rotation = 0D;
            this.ManageUser_btn.Size = new System.Drawing.Size(183, 55);
            this.ManageUser_btn.TabIndex = 4;
            this.ManageUser_btn.Text = "Manage User";
            this.ManageUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUser_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageUser_btn.UseVisualStyleBackColor = true;
            this.ManageUser_btn.Click += new System.EventHandler(this.ManageUser_btn_Click);
            // 
            // PrintCard_btn
            // 
            this.PrintCard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrintCard_btn.FlatAppearance.BorderSize = 0;
            this.PrintCard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintCard_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PrintCard_btn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.PrintCard_btn.IconColor = System.Drawing.Color.LightGray;
            this.PrintCard_btn.IconSize = 40;
            this.PrintCard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintCard_btn.Location = new System.Drawing.Point(0, 229);
            this.PrintCard_btn.Name = "PrintCard_btn";
            this.PrintCard_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PrintCard_btn.Rotation = 0D;
            this.PrintCard_btn.Size = new System.Drawing.Size(183, 55);
            this.PrintCard_btn.TabIndex = 3;
            this.PrintCard_btn.Text = "Print Card";
            this.PrintCard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintCard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintCard_btn.UseVisualStyleBackColor = true;
            this.PrintCard_btn.Click += new System.EventHandler(this.PrintCard_btn_Click);
            // 
            // Generate_btn
            // 
            this.Generate_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Generate_btn.FlatAppearance.BorderSize = 0;
            this.Generate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Generate_btn.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.Generate_btn.IconColor = System.Drawing.Color.LightGray;
            this.Generate_btn.IconSize = 40;
            this.Generate_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Generate_btn.Location = new System.Drawing.Point(0, 174);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Generate_btn.Rotation = 0D;
            this.Generate_btn.Size = new System.Drawing.Size(183, 55);
            this.Generate_btn.TabIndex = 2;
            this.Generate_btn.Text = "Generate";
            this.Generate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Generate_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_btn.FlatAppearance.BorderSize = 0;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Home_btn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home_btn.IconColor = System.Drawing.Color.LightGray;
            this.Home_btn.IconSize = 40;
            this.Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_btn.Location = new System.Drawing.Point(0, 119);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home_btn.Rotation = 0D;
            this.Home_btn.Size = new System.Drawing.Size(183, 55);
            this.Home_btn.TabIndex = 1;
            this.Home_btn.Text = "Home";
            this.Home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // HomeLogoPanel
            // 
            this.HomeLogoPanel.Controls.Add(this.CompanyLogoHome_pBox);
            this.HomeLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeLogoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLogoPanel.Name = "HomeLogoPanel";
            this.HomeLogoPanel.Size = new System.Drawing.Size(183, 119);
            this.HomeLogoPanel.TabIndex = 0;
            // 
            // CompanyLogoHome_pBox
            // 
            this.CompanyLogoHome_pBox.Image = ((System.Drawing.Image)(resources.GetObject("CompanyLogoHome_pBox.Image")));
            this.CompanyLogoHome_pBox.Location = new System.Drawing.Point(37, 22);
            this.CompanyLogoHome_pBox.Name = "CompanyLogoHome_pBox";
            this.CompanyLogoHome_pBox.Size = new System.Drawing.Size(121, 69);
            this.CompanyLogoHome_pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyLogoHome_pBox.TabIndex = 0;
            this.CompanyLogoHome_pBox.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(183, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(881, 528);
            this.panelChildForm.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1064, 528);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sideBarPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ID Card Generator";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.HomeLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoHome_pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel HomeLogoPanel;
        private System.Windows.Forms.PictureBox CompanyLogoHome_pBox;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton Home_btn;
        private FontAwesome.Sharp.IconButton Logout_btn;
        private FontAwesome.Sharp.IconButton ManageStorage_btn;
        private FontAwesome.Sharp.IconButton ManageUser_btn;
        private FontAwesome.Sharp.IconButton PrintCard_btn;
        private FontAwesome.Sharp.IconButton Generate_btn;
        private FontAwesome.Sharp.IconButton Settings_btn;
    }
}

