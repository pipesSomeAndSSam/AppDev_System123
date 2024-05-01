namespace AppDev_System.Forms
{
    partial class EditMulticab
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
            this.editPanel = new Guna.UI.WinForms.GunaPanel();
            this.changeTimeCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.DATE_TIME_SET = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Edit_ID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.Edit_Name = new Guna.UI.WinForms.GunaTextBox();
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel11 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel22 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel23 = new Guna.UI.WinForms.GunaLabel();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.White;
            this.editPanel.Controls.Add(this.changeTimeCheckBox);
            this.editPanel.Controls.Add(this.DATE_TIME_SET);
            this.editPanel.Controls.Add(this.gunaLabel1);
            this.editPanel.Controls.Add(this.gunaPanel1);
            this.editPanel.Controls.Add(this.Edit_ID);
            this.editPanel.Controls.Add(this.gunaLabel8);
            this.editPanel.Controls.Add(this.Edit_Name);
            this.editPanel.Controls.Add(this.gunaAdvenceButton6);
            this.editPanel.Controls.Add(this.gunaPanel11);
            this.editPanel.Controls.Add(this.gunaLabel22);
            this.editPanel.Controls.Add(this.gunaLabel23);
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Margin = new System.Windows.Forms.Padding(0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(390, 620);
            this.editPanel.TabIndex = 29;
            // 
            // changeTimeCheckBox
            // 
            this.changeTimeCheckBox.BaseColor = System.Drawing.Color.White;
            this.changeTimeCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.changeTimeCheckBox.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.changeTimeCheckBox.FillColor = System.Drawing.Color.White;
            this.changeTimeCheckBox.Location = new System.Drawing.Point(254, 453);
            this.changeTimeCheckBox.Name = "changeTimeCheckBox";
            this.changeTimeCheckBox.Size = new System.Drawing.Size(108, 20);
            this.changeTimeCheckBox.TabIndex = 31;
            this.changeTimeCheckBox.Text = "Current Time";
            this.changeTimeCheckBox.CheckedChanged += new System.EventHandler(this.changeTimeCheckBox_CheckedChanged);
            // 
            // DATE_TIME_SET
            // 
            this.DATE_TIME_SET.AutoSize = true;
            this.DATE_TIME_SET.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_TIME_SET.Location = new System.Drawing.Point(20, 380);
            this.DATE_TIME_SET.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.DATE_TIME_SET.Name = "DATE_TIME_SET";
            this.DATE_TIME_SET.Size = new System.Drawing.Size(83, 31);
            this.DATE_TIME_SET.TabIndex = 29;
            this.DATE_TIME_SET.Text = "124/12";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 330);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(223, 41);
            this.gunaLabel1.TabIndex = 30;
            this.gunaLabel1.Text = "Time and Date";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel1.Location = new System.Drawing.Point(20, 188);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel1.TabIndex = 23;
            // 
            // Edit_ID
            // 
            this.Edit_ID.BaseColor = System.Drawing.Color.White;
            this.Edit_ID.BorderColor = System.Drawing.Color.LightGray;
            this.Edit_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Edit_ID.FocusedBaseColor = System.Drawing.Color.White;
            this.Edit_ID.FocusedBorderColor = System.Drawing.Color.Gray;
            this.Edit_ID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Edit_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edit_ID.ForeColor = System.Drawing.Color.Silver;
            this.Edit_ID.Location = new System.Drawing.Point(15, 231);
            this.Edit_ID.Name = "Edit_ID";
            this.Edit_ID.PasswordChar = '\0';
            this.Edit_ID.Radius = 6;
            this.Edit_ID.Size = new System.Drawing.Size(348, 51);
            this.Edit_ID.TabIndex = 28;
            this.Edit_ID.Text = "Input ID";
            this.Edit_ID.Enter += new System.EventHandler(this.Edit_ID_Enter);
            this.Edit_ID.Leave += new System.EventHandler(this.Edit_ID_Leave);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(15, 203);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(138, 25);
            this.gunaLabel8.TabIndex = 29;
            this.gunaLabel8.Text = "Edit Multicab ID";
            // 
            // Edit_Name
            // 
            this.Edit_Name.BaseColor = System.Drawing.Color.White;
            this.Edit_Name.BorderColor = System.Drawing.Color.LightGray;
            this.Edit_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Edit_Name.FocusedBaseColor = System.Drawing.Color.White;
            this.Edit_Name.FocusedBorderColor = System.Drawing.Color.Gray;
            this.Edit_Name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Edit_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edit_Name.ForeColor = System.Drawing.Color.Silver;
            this.Edit_Name.Location = new System.Drawing.Point(15, 115);
            this.Edit_Name.Name = "Edit_Name";
            this.Edit_Name.PasswordChar = '\0';
            this.Edit_Name.Radius = 6;
            this.Edit_Name.Size = new System.Drawing.Size(348, 51);
            this.Edit_Name.TabIndex = 26;
            this.Edit_Name.Text = "Input Name";
            this.Edit_Name.Enter += new System.EventHandler(this.Edit_Name_Enter);
            this.Edit_Name.Leave += new System.EventHandler(this.Edit_Name_Leave);
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.SystemColors.HotTrack;
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(193)))));
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = null;
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.Image = null;
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(15, 557);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.SystemColors.HotTrack;
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Radius = 5;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(168, 42);
            this.gunaAdvenceButton6.TabIndex = 19;
            this.gunaAdvenceButton6.Text = "Update";
            this.gunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // gunaPanel11
            // 
            this.gunaPanel11.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel11.Location = new System.Drawing.Point(20, 304);
            this.gunaPanel11.Name = "gunaPanel11";
            this.gunaPanel11.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel11.TabIndex = 22;
            // 
            // gunaLabel22
            // 
            this.gunaLabel22.AutoSize = true;
            this.gunaLabel22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel22.Location = new System.Drawing.Point(14, 83);
            this.gunaLabel22.Name = "gunaLabel22";
            this.gunaLabel22.Size = new System.Drawing.Size(146, 25);
            this.gunaLabel22.TabIndex = 19;
            this.gunaLabel22.Text = "Edit Driver Name";
            // 
            // gunaLabel23
            // 
            this.gunaLabel23.AutoSize = true;
            this.gunaLabel23.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel23.Location = new System.Drawing.Point(8, 20);
            this.gunaLabel23.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.gunaLabel23.Name = "gunaLabel23";
            this.gunaLabel23.Size = new System.Drawing.Size(208, 41);
            this.gunaLabel23.TabIndex = 19;
            this.gunaLabel23.Text = "Edit Multicab";
            // 
            // EditMulticab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 621);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditMulticab";
            this.Text = "EditMulticab";
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel editPanel;
        private Guna.UI.WinForms.GunaCheckBox changeTimeCheckBox;
        private Guna.UI.WinForms.GunaLabel DATE_TIME_SET;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox Edit_ID;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox Edit_Name;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private Guna.UI.WinForms.GunaPanel gunaPanel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel22;
        private Guna.UI.WinForms.GunaLabel gunaLabel23;
    }
}