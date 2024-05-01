namespace AppDev_System.Forms
{
    partial class AddMulticab
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
            this.gunaPanel9 = new Guna.UI.WinForms.GunaPanel();
            this.searchMulticab_ID = new System.Windows.Forms.ComboBox();
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Driver_name_comboBox = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel11 = new Guna.UI.WinForms.GunaPanel();
            this.SetDateArrival_existing = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel16 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel22 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel23 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel9
            // 
            this.gunaPanel9.BackColor = System.Drawing.Color.White;
            this.gunaPanel9.Controls.Add(this.searchMulticab_ID);
            this.gunaPanel9.Controls.Add(this.gunaAdvenceButton6);
            this.gunaPanel9.Controls.Add(this.Driver_name_comboBox);
            this.gunaPanel9.Controls.Add(this.gunaLabel12);
            this.gunaPanel9.Controls.Add(this.gunaPanel11);
            this.gunaPanel9.Controls.Add(this.SetDateArrival_existing);
            this.gunaPanel9.Controls.Add(this.gunaLabel14);
            this.gunaPanel9.Controls.Add(this.gunaPanel16);
            this.gunaPanel9.Controls.Add(this.gunaLabel22);
            this.gunaPanel9.Controls.Add(this.gunaLabel23);
            this.gunaPanel9.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel9.Name = "gunaPanel9";
            this.gunaPanel9.Size = new System.Drawing.Size(390, 471);
            this.gunaPanel9.TabIndex = 27;
            // 
            // searchMulticab_ID
            // 
            this.searchMulticab_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMulticab_ID.FormattingEnabled = true;
            this.searchMulticab_ID.Location = new System.Drawing.Point(21, 92);
            this.searchMulticab_ID.Name = "searchMulticab_ID";
            this.searchMulticab_ID.Size = new System.Drawing.Size(282, 33);
            this.searchMulticab_ID.TabIndex = 27;
            this.searchMulticab_ID.SelectedIndexChanged += new System.EventHandler(this.searchMulticab_ID_SelectedIndexChanged);
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.Color.ForestGreen;
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.DarkGreen;
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = null;
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.Image = null;
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(10, 405);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Radius = 5;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(168, 42);
            this.gunaAdvenceButton6.TabIndex = 19;
            this.gunaAdvenceButton6.Text = "Add";
            this.gunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // Driver_name_comboBox
            // 
            this.Driver_name_comboBox.AutoSize = true;
            this.Driver_name_comboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_name_comboBox.Location = new System.Drawing.Point(15, 210);
            this.Driver_name_comboBox.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.Driver_name_comboBox.Name = "Driver_name_comboBox";
            this.Driver_name_comboBox.Size = new System.Drawing.Size(203, 31);
            this.Driver_name_comboBox.TabIndex = 24;
            this.Driver_name_comboBox.Text = "NO CAB SELECTED";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(3, 272);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(352, 41);
            this.gunaLabel12.TabIndex = 19;
            this.gunaLabel12.Text = "Date and Time Enqueue";
            // 
            // gunaPanel11
            // 
            this.gunaPanel11.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel11.Location = new System.Drawing.Point(19, 252);
            this.gunaPanel11.Name = "gunaPanel11";
            this.gunaPanel11.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel11.TabIndex = 22;
            // 
            // SetDateArrival_existing
            // 
            this.SetDateArrival_existing.AutoSize = true;
            this.SetDateArrival_existing.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDateArrival_existing.Location = new System.Drawing.Point(16, 320);
            this.SetDateArrival_existing.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.SetDateArrival_existing.Name = "SetDateArrival_existing";
            this.SetDateArrival_existing.Size = new System.Drawing.Size(126, 25);
            this.SetDateArrival_existing.TabIndex = 23;
            this.SetDateArrival_existing.Text = "123/1251/125";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel14.Location = new System.Drawing.Point(3, 160);
            this.gunaLabel14.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(196, 41);
            this.gunaLabel14.TabIndex = 22;
            this.gunaLabel14.Text = "Driver Name";
            // 
            // gunaPanel16
            // 
            this.gunaPanel16.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel16.Location = new System.Drawing.Point(21, 151);
            this.gunaPanel16.Name = "gunaPanel16";
            this.gunaPanel16.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel16.TabIndex = 21;
            // 
            // gunaLabel22
            // 
            this.gunaLabel22.AutoSize = true;
            this.gunaLabel22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel22.Location = new System.Drawing.Point(14, 54);
            this.gunaLabel22.Name = "gunaLabel22";
            this.gunaLabel22.Size = new System.Drawing.Size(188, 25);
            this.gunaLabel22.TabIndex = 19;
            this.gunaLabel22.Text = "Search for Multicab ID";
            // 
            // gunaLabel23
            // 
            this.gunaLabel23.AutoSize = true;
            this.gunaLabel23.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel23.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel23.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.gunaLabel23.Name = "gunaLabel23";
            this.gunaLabel23.Size = new System.Drawing.Size(254, 41);
            this.gunaLabel23.TabIndex = 19;
            this.gunaLabel23.Text = "Choose Multicab";
            // 
            // AddMulticab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 467);
            this.Controls.Add(this.gunaPanel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMulticab";
            this.Text = "AddMulticab";
            this.Load += new System.EventHandler(this.AddMulticab_Load);
            this.gunaPanel9.ResumeLayout(false);
            this.gunaPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel9;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private Guna.UI.WinForms.GunaLabel Driver_name_comboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaPanel gunaPanel11;
        private Guna.UI.WinForms.GunaLabel SetDateArrival_existing;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaPanel gunaPanel16;
        private Guna.UI.WinForms.GunaLabel gunaLabel22;
        private Guna.UI.WinForms.GunaLabel gunaLabel23;
        private System.Windows.Forms.ComboBox searchMulticab_ID;
    }
}