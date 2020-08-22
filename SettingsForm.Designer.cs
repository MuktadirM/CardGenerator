namespace CardGenerator
{
    partial class SettingsForm
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
            this.ManageUserTop_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageUserTop_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageUserTop_panel
            // 
            this.ManageUserTop_panel.Controls.Add(this.label1);
            this.ManageUserTop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageUserTop_panel.Location = new System.Drawing.Point(0, 0);
            this.ManageUserTop_panel.Name = "ManageUserTop_panel";
            this.ManageUserTop_panel.Size = new System.Drawing.Size(865, 97);
            this.ManageUserTop_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(865, 489);
            this.Controls.Add(this.ManageUserTop_panel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ManageUserTop_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManageUserTop_panel;
        private System.Windows.Forms.Label label1;
    }
}