namespace AppDev_System.UserControls
{
    partial class UserControl_MultData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_MultData));
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.numOfMulticabs = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.input_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.sercc = new Guna.UI.WinForms.GunaLabel();
            this.MulticabGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.searchButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Refresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addMulticab = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.MulticabGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel
            // 
            this.gunaLabel.AutoSize = true;
            this.gunaLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel.Name = "gunaLabel";
            this.gunaLabel.Size = new System.Drawing.Size(310, 46);
            this.gunaLabel.TabIndex = 8;
            this.gunaLabel.Text = "Multicab Status";
            // 
            // numOfMulticabs
            // 
            this.numOfMulticabs.AutoSize = true;
            this.numOfMulticabs.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfMulticabs.Location = new System.Drawing.Point(1534, 91);
            this.numOfMulticabs.Margin = new System.Windows.Forms.Padding(0);
            this.numOfMulticabs.Name = "numOfMulticabs";
            this.numOfMulticabs.Size = new System.Drawing.Size(37, 30);
            this.numOfMulticabs.TabIndex = 30;
            this.numOfMulticabs.Text = "99";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1276, 90);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(222, 30);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Number of Multicabs:";
            // 
            // input_Name
            // 
            this.input_Name.BackColor = System.Drawing.Color.White;
            this.input_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_Name.FocusedLineColor = System.Drawing.Color.Black;
            this.input_Name.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Name.ForeColor = System.Drawing.Color.Silver;
            this.input_Name.LineColor = System.Drawing.SystemColors.AppWorkspace;
            this.input_Name.Location = new System.Drawing.Point(555, 81);
            this.input_Name.Name = "input_Name";
            this.input_Name.PasswordChar = '\0';
            this.input_Name.Size = new System.Drawing.Size(302, 40);
            this.input_Name.TabIndex = 27;
            this.input_Name.Text = "Input Driver Name";
            this.input_Name.Enter += new System.EventHandler(this.input_Name_Enter);
            this.input_Name.Leave += new System.EventHandler(this.input_Name_Leave);
            // 
            // sercc
            // 
            this.sercc.AutoSize = true;
            this.sercc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sercc.Location = new System.Drawing.Point(458, 90);
            this.sercc.Name = "sercc";
            this.sercc.Size = new System.Drawing.Size(82, 31);
            this.sercc.TabIndex = 26;
            this.sercc.Text = "Search";
            // 
            // MulticabGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.MulticabGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MulticabGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MulticabGridView.BackgroundColor = System.Drawing.Color.White;
            this.MulticabGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MulticabGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MulticabGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MulticabGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MulticabGridView.ColumnHeadersHeight = 4;
            this.MulticabGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MulticabGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MulticabGridView.EnableHeadersVisualStyles = false;
            this.MulticabGridView.GridColor = System.Drawing.Color.DarkGray;
            this.MulticabGridView.Location = new System.Drawing.Point(52, 156);
            this.MulticabGridView.Name = "MulticabGridView";
            this.MulticabGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MulticabGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MulticabGridView.RowHeadersVisible = false;
            this.MulticabGridView.RowHeadersWidth = 51;
            this.MulticabGridView.RowTemplate.Height = 24;
            this.MulticabGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MulticabGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MulticabGridView.Size = new System.Drawing.Size(1480, 751);
            this.MulticabGridView.TabIndex = 24;
            this.MulticabGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.MulticabGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.MulticabGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MulticabGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MulticabGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MulticabGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MulticabGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MulticabGridView.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.MulticabGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.MulticabGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MulticabGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulticabGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MulticabGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MulticabGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.MulticabGridView.ThemeStyle.ReadOnly = false;
            this.MulticabGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.MulticabGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MulticabGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulticabGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MulticabGridView.ThemeStyle.RowsStyle.Height = 24;
            this.MulticabGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.MulticabGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MulticabGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MulticabGridView_CellClick);
            // 
            // searchButton
            // 
            this.searchButton.AnimationHoverSpeed = 0.07F;
            this.searchButton.AnimationSpeed = 0.03F;
            this.searchButton.BaseColor = System.Drawing.Color.Black;
            this.searchButton.BorderColor = System.Drawing.Color.Black;
            this.searchButton.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.searchButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.searchButton.CheckedForeColor = System.Drawing.Color.White;
            this.searchButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("searchButton.CheckedImage")));
            this.searchButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::AppDev_System.Properties.Resources.search_512x512;
            this.searchButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchButton.ImageSize = new System.Drawing.Size(25, 25);
            this.searchButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.searchButton.Location = new System.Drawing.Point(880, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.searchButton.OnHoverImage = null;
            this.searchButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.searchButton.OnPressedColor = System.Drawing.Color.Black;
            this.searchButton.Radius = 6;
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.TabIndex = 28;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Refresh
            // 
            this.Refresh.AnimationHoverSpeed = 0.07F;
            this.Refresh.AnimationSpeed = 0.03F;
            this.Refresh.BaseColor = System.Drawing.Color.Black;
            this.Refresh.BorderColor = System.Drawing.Color.Black;
            this.Refresh.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.Refresh.CheckedBorderColor = System.Drawing.Color.Black;
            this.Refresh.CheckedForeColor = System.Drawing.Color.White;
            this.Refresh.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Refresh.CheckedImage")));
            this.Refresh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Image = global::AppDev_System.Properties.Resources.refresh_left_square3_512x512;
            this.Refresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Refresh.ImageSize = new System.Drawing.Size(35, 35);
            this.Refresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Refresh.Location = new System.Drawing.Point(283, 85);
            this.Refresh.Name = "Refresh";
            this.Refresh.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.Refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.Refresh.OnHoverImage = null;
            this.Refresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Refresh.OnPressedColor = System.Drawing.Color.Black;
            this.Refresh.Radius = 6;
            this.Refresh.Size = new System.Drawing.Size(169, 40);
            this.Refresh.TabIndex = 25;
            this.Refresh.Text = "REFRESH";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // addMulticab
            // 
            this.addMulticab.AnimationHoverSpeed = 0.07F;
            this.addMulticab.AnimationSpeed = 0.03F;
            this.addMulticab.BaseColor = System.Drawing.Color.Black;
            this.addMulticab.BorderColor = System.Drawing.Color.Black;
            this.addMulticab.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.addMulticab.CheckedBorderColor = System.Drawing.Color.Black;
            this.addMulticab.CheckedForeColor = System.Drawing.Color.White;
            this.addMulticab.CheckedImage = ((System.Drawing.Image)(resources.GetObject("addMulticab.CheckedImage")));
            this.addMulticab.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addMulticab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMulticab.ForeColor = System.Drawing.Color.White;
            this.addMulticab.Image = global::AppDev_System.Properties.Resources.plus_511x512_WHITE_;
            this.addMulticab.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addMulticab.ImageSize = new System.Drawing.Size(20, 20);
            this.addMulticab.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addMulticab.Location = new System.Drawing.Point(52, 85);
            this.addMulticab.Name = "addMulticab";
            this.addMulticab.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.addMulticab.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addMulticab.OnHoverForeColor = System.Drawing.Color.White;
            this.addMulticab.OnHoverImage = null;
            this.addMulticab.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addMulticab.OnPressedColor = System.Drawing.Color.Black;
            this.addMulticab.Radius = 6;
            this.addMulticab.Size = new System.Drawing.Size(213, 40);
            this.addMulticab.TabIndex = 23;
            this.addMulticab.Text = "ADD MULTICAB";
            this.addMulticab.Click += new System.EventHandler(this.addMulticab_Click);
            // 
            // UserControl_MultData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numOfMulticabs);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.input_Name);
            this.Controls.Add(this.sercc);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.MulticabGridView);
            this.Controls.Add(this.addMulticab);
            this.Controls.Add(this.gunaLabel);
            this.Name = "UserControl_MultData";
            this.Size = new System.Drawing.Size(1570, 970);
            ((System.ComponentModel.ISupportInitialize)(this.MulticabGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel;
        private Guna.UI.WinForms.GunaLabel numOfMulticabs;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton searchButton;
        private Guna.UI.WinForms.GunaLineTextBox input_Name;
        private Guna.UI.WinForms.GunaLabel sercc;
        private Guna.UI.WinForms.GunaAdvenceButton Refresh;
        private Guna.UI.WinForms.GunaDataGridView MulticabGridView;
        private Guna.UI.WinForms.GunaAdvenceButton addMulticab;
    }
}
