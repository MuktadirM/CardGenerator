namespace CardGenerator
{
    partial class GenerateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoGen_label = new System.Windows.Forms.Label();
            this.TopHeadInfoRight_panel = new System.Windows.Forms.Panel();
            this.GenTopHeadInfo_panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GenerateCardBtn_panel = new System.Windows.Forms.Panel();
            this.GenerateSelected_btn = new FontAwesome.Sharp.IconButton();
            this.SearchGen_panel = new System.Windows.Forms.Panel();
            this.SearchGen_btn = new FontAwesome.Sharp.IconButton();
            this.SearchGen_txtBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.RemoveCardGen_btn = new FontAwesome.Sharp.IconButton();
            this.DeleteGen_btn = new FontAwesome.Sharp.IconButton();
            this.UpdateGen_btn = new FontAwesome.Sharp.IconButton();
            this.AddNewGen_btn = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.GenerateCardBtn_panel.SuspendLayout();
            this.SearchGen_panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoGen_label);
            this.panel1.Controls.Add(this.TopHeadInfoRight_panel);
            this.panel1.Controls.Add(this.GenTopHeadInfo_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 0;
            // 
            // InfoGen_label
            // 
            this.InfoGen_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGen_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGen_label.Location = new System.Drawing.Point(178, 0);
            this.InfoGen_label.Name = "InfoGen_label";
            this.InfoGen_label.Size = new System.Drawing.Size(444, 97);
            this.InfoGen_label.TabIndex = 2;
            this.InfoGen_label.Text = "Manage Card Generation";
            this.InfoGen_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopHeadInfoRight_panel
            // 
            this.TopHeadInfoRight_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopHeadInfoRight_panel.Location = new System.Drawing.Point(622, 0);
            this.TopHeadInfoRight_panel.Name = "TopHeadInfoRight_panel";
            this.TopHeadInfoRight_panel.Size = new System.Drawing.Size(178, 97);
            this.TopHeadInfoRight_panel.TabIndex = 1;
            // 
            // GenTopHeadInfo_panel
            // 
            this.GenTopHeadInfo_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenTopHeadInfo_panel.Location = new System.Drawing.Point(0, 0);
            this.GenTopHeadInfo_panel.Name = "GenTopHeadInfo_panel";
            this.GenTopHeadInfo_panel.Size = new System.Drawing.Size(178, 97);
            this.GenTopHeadInfo_panel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 353);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GenerateCardBtn_panel);
            this.panel5.Controls.Add(this.SearchGen_panel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 65);
            this.panel5.TabIndex = 9;
            // 
            // GenerateCardBtn_panel
            // 
            this.GenerateCardBtn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateCardBtn_panel.Controls.Add(this.GenerateSelected_btn);
            this.GenerateCardBtn_panel.Location = new System.Drawing.Point(471, 3);
            this.GenerateCardBtn_panel.Name = "GenerateCardBtn_panel";
            this.GenerateCardBtn_panel.Size = new System.Drawing.Size(327, 60);
            this.GenerateCardBtn_panel.TabIndex = 9;
            // 
            // GenerateSelected_btn
            // 
            this.GenerateSelected_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.GenerateSelected_btn.FlatAppearance.BorderSize = 0;
            this.GenerateSelected_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateSelected_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.GenerateSelected_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateSelected_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenerateSelected_btn.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.GenerateSelected_btn.IconColor = System.Drawing.Color.White;
            this.GenerateSelected_btn.IconSize = 19;
            this.GenerateSelected_btn.Location = new System.Drawing.Point(87, 11);
            this.GenerateSelected_btn.Name = "GenerateSelected_btn";
            this.GenerateSelected_btn.Rotation = 0D;
            this.GenerateSelected_btn.Size = new System.Drawing.Size(229, 39);
            this.GenerateSelected_btn.TabIndex = 0;
            this.GenerateSelected_btn.Text = "Generate Selected";
            this.GenerateSelected_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenerateSelected_btn.UseVisualStyleBackColor = false;
            // 
            // SearchGen_panel
            // 
            this.SearchGen_panel.Controls.Add(this.SearchGen_btn);
            this.SearchGen_panel.Controls.Add(this.SearchGen_txtBox);
            this.SearchGen_panel.Location = new System.Drawing.Point(2, 3);
            this.SearchGen_panel.Name = "SearchGen_panel";
            this.SearchGen_panel.Size = new System.Drawing.Size(389, 60);
            this.SearchGen_panel.TabIndex = 8;
            // 
            // SearchGen_btn
            // 
            this.SearchGen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.SearchGen_btn.FlatAppearance.BorderSize = 0;
            this.SearchGen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchGen_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SearchGen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchGen_btn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.SearchGen_btn.IconColor = System.Drawing.Color.White;
            this.SearchGen_btn.IconSize = 20;
            this.SearchGen_btn.Location = new System.Drawing.Point(266, 15);
            this.SearchGen_btn.Name = "SearchGen_btn";
            this.SearchGen_btn.Rotation = 0D;
            this.SearchGen_btn.Size = new System.Drawing.Size(85, 25);
            this.SearchGen_btn.TabIndex = 1;
            this.SearchGen_btn.Text = "Search";
            this.SearchGen_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchGen_btn.UseVisualStyleBackColor = false;
            // 
            // SearchGen_txtBox
            // 
            this.SearchGen_txtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchGen_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.SearchGen_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGen_txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchGen_txtBox.Location = new System.Drawing.Point(15, 16);
            this.SearchGen_txtBox.Name = "SearchGen_txtBox";
            this.SearchGen_txtBox.Size = new System.Drawing.Size(233, 27);
            this.SearchGen_txtBox.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(3, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(797, 288);
            this.panel7.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.RemoveCardGen_btn);
            this.panel10.Controls.Add(this.DeleteGen_btn);
            this.panel10.Controls.Add(this.UpdateGen_btn);
            this.panel10.Controls.Add(this.AddNewGen_btn);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 243);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(797, 45);
            this.panel10.TabIndex = 2;
            // 
            // RemoveCardGen_btn
            // 
            this.RemoveCardGen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCardGen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.RemoveCardGen_btn.FlatAppearance.BorderSize = 0;
            this.RemoveCardGen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCardGen_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RemoveCardGen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCardGen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveCardGen_btn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.RemoveCardGen_btn.IconColor = System.Drawing.Color.White;
            this.RemoveCardGen_btn.IconSize = 15;
            this.RemoveCardGen_btn.Location = new System.Drawing.Point(612, 0);
            this.RemoveCardGen_btn.Name = "RemoveCardGen_btn";
            this.RemoveCardGen_btn.Rotation = 0D;
            this.RemoveCardGen_btn.Size = new System.Drawing.Size(161, 39);
            this.RemoveCardGen_btn.TabIndex = 6;
            this.RemoveCardGen_btn.Text = "Remove Card";
            this.RemoveCardGen_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveCardGen_btn.UseVisualStyleBackColor = false;
            // 
            // DeleteGen_btn
            // 
            this.DeleteGen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.DeleteGen_btn.FlatAppearance.BorderSize = 0;
            this.DeleteGen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteGen_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteGen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteGen_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteGen_btn.IconColor = System.Drawing.Color.White;
            this.DeleteGen_btn.IconSize = 15;
            this.DeleteGen_btn.Location = new System.Drawing.Point(298, 0);
            this.DeleteGen_btn.Name = "DeleteGen_btn";
            this.DeleteGen_btn.Rotation = 0D;
            this.DeleteGen_btn.Size = new System.Drawing.Size(97, 39);
            this.DeleteGen_btn.TabIndex = 3;
            this.DeleteGen_btn.Text = "Delete";
            this.DeleteGen_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteGen_btn.UseVisualStyleBackColor = false;
            // 
            // UpdateGen_btn
            // 
            this.UpdateGen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.UpdateGen_btn.FlatAppearance.BorderSize = 0;
            this.UpdateGen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGen_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.UpdateGen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateGen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateGen_btn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.UpdateGen_btn.IconColor = System.Drawing.Color.White;
            this.UpdateGen_btn.IconSize = 15;
            this.UpdateGen_btn.Location = new System.Drawing.Point(178, 0);
            this.UpdateGen_btn.Name = "UpdateGen_btn";
            this.UpdateGen_btn.Rotation = 0D;
            this.UpdateGen_btn.Size = new System.Drawing.Size(97, 39);
            this.UpdateGen_btn.TabIndex = 2;
            this.UpdateGen_btn.Text = "Update";
            this.UpdateGen_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateGen_btn.UseVisualStyleBackColor = false;
            // 
            // AddNewGen_btn
            // 
            this.AddNewGen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(22)))), ((int)(((byte)(73)))));
            this.AddNewGen_btn.FlatAppearance.BorderSize = 0;
            this.AddNewGen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewGen_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddNewGen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewGen_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewGen_btn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddNewGen_btn.IconColor = System.Drawing.Color.White;
            this.AddNewGen_btn.IconSize = 15;
            this.AddNewGen_btn.Location = new System.Drawing.Point(64, 0);
            this.AddNewGen_btn.Name = "AddNewGen_btn";
            this.AddNewGen_btn.Rotation = 0D;
            this.AddNewGen_btn.Size = new System.Drawing.Size(93, 38);
            this.AddNewGen_btn.TabIndex = 1;
            this.AddNewGen_btn.Text = "Add New";
            this.AddNewGen_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddNewGen_btn.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(58, 45);
            this.panel11.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.panel9.Location = new System.Drawing.Point(564, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(230, 240);
            this.panel9.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.UName,
            this.Position,
            this.BloodGroup,
            this.CreatedOn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmpId
            // 
            this.EmpId.HeaderText = "ID";
            this.EmpId.Name = "EmpId";
            // 
            // UName
            // 
            this.UName.HeaderText = "Name";
            this.UName.Name = "UName";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // BloodGroup
            // 
            this.BloodGroup.HeaderText = "Blood Group";
            this.BloodGroup.Name = "BloodGroup";
            // 
            // CreatedOn
            // 
            this.CreatedOn.HeaderText = "Created";
            this.CreatedOn.Name = "CreatedOn";
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "GenerateForm";
            this.Text = "GenerateForm";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.GenerateCardBtn_panel.ResumeLayout(false);
            this.SearchGen_panel.ResumeLayout(false);
            this.SearchGen_panel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InfoGen_label;
        private System.Windows.Forms.Panel TopHeadInfoRight_panel;
        private System.Windows.Forms.Panel GenTopHeadInfo_panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel GenerateCardBtn_panel;
        private FontAwesome.Sharp.IconButton GenerateSelected_btn;
        private System.Windows.Forms.Panel SearchGen_panel;
        private FontAwesome.Sharp.IconButton SearchGen_btn;
        private System.Windows.Forms.TextBox SearchGen_txtBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton DeleteGen_btn;
        private FontAwesome.Sharp.IconButton UpdateGen_btn;
        private FontAwesome.Sharp.IconButton AddNewGen_btn;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton RemoveCardGen_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
    }
}