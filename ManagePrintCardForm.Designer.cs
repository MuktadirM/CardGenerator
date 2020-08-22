namespace CardGenerator
{
    partial class ManagePrintCardForm
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
            this.PrintCardHead_panel = new System.Windows.Forms.Panel();
            this.PrintTopHeadManage_level = new System.Windows.Forms.Label();
            this.PrintTopHeadPrint_panelRight = new System.Windows.Forms.Panel();
            this.RePrintIdCard_btn = new FontAwesome.Sharp.IconButton();
            this.PrintTopHeadPrint_panelLeft = new System.Windows.Forms.Panel();
            this.PrintIdCard_btn = new FontAwesome.Sharp.IconButton();
            this.PrintIdCardBody_panel = new System.Windows.Forms.Panel();
            this.PrintCardHead_panel.SuspendLayout();
            this.PrintTopHeadPrint_panelRight.SuspendLayout();
            this.PrintTopHeadPrint_panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintCardHead_panel
            // 
            this.PrintCardHead_panel.Controls.Add(this.PrintTopHeadManage_level);
            this.PrintCardHead_panel.Controls.Add(this.PrintTopHeadPrint_panelRight);
            this.PrintCardHead_panel.Controls.Add(this.PrintTopHeadPrint_panelLeft);
            this.PrintCardHead_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrintCardHead_panel.Location = new System.Drawing.Point(0, 0);
            this.PrintCardHead_panel.Name = "PrintCardHead_panel";
            this.PrintCardHead_panel.Size = new System.Drawing.Size(865, 91);
            this.PrintCardHead_panel.TabIndex = 0;
            // 
            // PrintTopHeadManage_level
            // 
            this.PrintTopHeadManage_level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintTopHeadManage_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintTopHeadManage_level.Location = new System.Drawing.Point(172, 0);
            this.PrintTopHeadManage_level.Name = "PrintTopHeadManage_level";
            this.PrintTopHeadManage_level.Size = new System.Drawing.Size(521, 91);
            this.PrintTopHeadManage_level.TabIndex = 2;
            this.PrintTopHeadManage_level.Text = "Manage Printing Of Card";
            this.PrintTopHeadManage_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintTopHeadPrint_panelRight
            // 
            this.PrintTopHeadPrint_panelRight.Controls.Add(this.RePrintIdCard_btn);
            this.PrintTopHeadPrint_panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PrintTopHeadPrint_panelRight.Location = new System.Drawing.Point(693, 0);
            this.PrintTopHeadPrint_panelRight.Name = "PrintTopHeadPrint_panelRight";
            this.PrintTopHeadPrint_panelRight.Size = new System.Drawing.Size(172, 91);
            this.PrintTopHeadPrint_panelRight.TabIndex = 1;
            // 
            // RePrintIdCard_btn
            // 
            this.RePrintIdCard_btn.BackColor = System.Drawing.Color.Gray;
            this.RePrintIdCard_btn.FlatAppearance.BorderSize = 0;
            this.RePrintIdCard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RePrintIdCard_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RePrintIdCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePrintIdCard_btn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.RePrintIdCard_btn.IconColor = System.Drawing.Color.Black;
            this.RePrintIdCard_btn.IconSize = 25;
            this.RePrintIdCard_btn.Location = new System.Drawing.Point(18, 15);
            this.RePrintIdCard_btn.Name = "RePrintIdCard_btn";
            this.RePrintIdCard_btn.Rotation = 0D;
            this.RePrintIdCard_btn.Size = new System.Drawing.Size(137, 49);
            this.RePrintIdCard_btn.TabIndex = 1;
            this.RePrintIdCard_btn.Text = "Re-Print";
            this.RePrintIdCard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RePrintIdCard_btn.UseVisualStyleBackColor = false;
            this.RePrintIdCard_btn.Click += new System.EventHandler(this.RePrintIdCard_btn_Click);
            // 
            // PrintTopHeadPrint_panelLeft
            // 
            this.PrintTopHeadPrint_panelLeft.Controls.Add(this.PrintIdCard_btn);
            this.PrintTopHeadPrint_panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrintTopHeadPrint_panelLeft.Location = new System.Drawing.Point(0, 0);
            this.PrintTopHeadPrint_panelLeft.Name = "PrintTopHeadPrint_panelLeft";
            this.PrintTopHeadPrint_panelLeft.Size = new System.Drawing.Size(172, 91);
            this.PrintTopHeadPrint_panelLeft.TabIndex = 0;
            // 
            // PrintIdCard_btn
            // 
            this.PrintIdCard_btn.BackColor = System.Drawing.Color.Gray;
            this.PrintIdCard_btn.FlatAppearance.BorderSize = 0;
            this.PrintIdCard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintIdCard_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PrintIdCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintIdCard_btn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.PrintIdCard_btn.IconColor = System.Drawing.Color.Black;
            this.PrintIdCard_btn.IconSize = 25;
            this.PrintIdCard_btn.Location = new System.Drawing.Point(12, 12);
            this.PrintIdCard_btn.Name = "PrintIdCard_btn";
            this.PrintIdCard_btn.Rotation = 0D;
            this.PrintIdCard_btn.Size = new System.Drawing.Size(137, 49);
            this.PrintIdCard_btn.TabIndex = 0;
            this.PrintIdCard_btn.Text = "Print Card";
            this.PrintIdCard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintIdCard_btn.UseVisualStyleBackColor = false;
            this.PrintIdCard_btn.Click += new System.EventHandler(this.PrintIdCard_btn_Click);
            // 
            // PrintIdCardBody_panel
            // 
            this.PrintIdCardBody_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintIdCardBody_panel.Location = new System.Drawing.Point(0, 94);
            this.PrintIdCardBody_panel.Name = "PrintIdCardBody_panel";
            this.PrintIdCardBody_panel.Size = new System.Drawing.Size(865, 395);
            this.PrintIdCardBody_panel.TabIndex = 1;
            // 
            // ManagePrintCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(865, 489);
            this.Controls.Add(this.PrintIdCardBody_panel);
            this.Controls.Add(this.PrintCardHead_panel);
            this.Name = "ManagePrintCardForm";
            this.Text = "PrintCardForm";
            this.Load += new System.EventHandler(this.ManagePrintCardForm_Load);
            this.PrintCardHead_panel.ResumeLayout(false);
            this.PrintTopHeadPrint_panelRight.ResumeLayout(false);
            this.PrintTopHeadPrint_panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PrintCardHead_panel;
        private System.Windows.Forms.Panel PrintIdCardBody_panel;
        private System.Windows.Forms.Label PrintTopHeadManage_level;
        private System.Windows.Forms.Panel PrintTopHeadPrint_panelRight;
        private FontAwesome.Sharp.IconButton RePrintIdCard_btn;
        private System.Windows.Forms.Panel PrintTopHeadPrint_panelLeft;
        private FontAwesome.Sharp.IconButton PrintIdCard_btn;
    }
}