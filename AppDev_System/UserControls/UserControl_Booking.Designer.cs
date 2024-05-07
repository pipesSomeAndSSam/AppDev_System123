namespace AppDev_System.UserControls
{
    partial class UserControl_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Booking));
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.BookingsGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.sercc = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.numOfRts = new Guna.UI.WinForms.GunaLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addBookings = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.BookingsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel
            // 
            this.gunaLabel.AutoSize = true;
            this.gunaLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel.Name = "gunaLabel";
            this.gunaLabel.Size = new System.Drawing.Size(264, 46);
            this.gunaLabel.TabIndex = 7;
            this.gunaLabel.Text = "Ticket Status";
            // 
            // BookingsGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.BookingsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookingsGridView.BackgroundColor = System.Drawing.Color.White;
            this.BookingsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookingsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookingsGridView.ColumnHeadersHeight = 4;
            this.BookingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookingsGridView.EnableHeadersVisualStyles = false;
            this.BookingsGridView.GridColor = System.Drawing.Color.DarkGray;
            this.BookingsGridView.Location = new System.Drawing.Point(52, 156);
            this.BookingsGridView.Name = "BookingsGridView";
            this.BookingsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BookingsGridView.RowHeadersVisible = false;
            this.BookingsGridView.RowHeadersWidth = 51;
            this.BookingsGridView.RowTemplate.Height = 24;
            this.BookingsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BookingsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingsGridView.Size = new System.Drawing.Size(1480, 751);
            this.BookingsGridView.TabIndex = 9;
            this.BookingsGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.BookingsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.BookingsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookingsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookingsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookingsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookingsGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookingsGridView.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.BookingsGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.BookingsGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BookingsGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookingsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BookingsGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.BookingsGridView.ThemeStyle.ReadOnly = false;
            this.BookingsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.BookingsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BookingsGridView.ThemeStyle.RowsStyle.Height = 24;
            this.BookingsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.BookingsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BookingsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingsGridView_CellClick);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.Black;
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.gunaLineTextBox1.LineColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(555, 81);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.Size = new System.Drawing.Size(302, 40);
            this.gunaLineTextBox1.TabIndex = 18;
            this.gunaLineTextBox1.Text = "Input Destination";
            this.gunaLineTextBox1.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter);
            this.gunaLineTextBox1.Leave += new System.EventHandler(this.gunaLineTextBox1_Leave);
            // 
            // sercc
            // 
            this.sercc.AutoSize = true;
            this.sercc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sercc.Location = new System.Drawing.Point(458, 90);
            this.sercc.Name = "sercc";
            this.sercc.Size = new System.Drawing.Size(82, 31);
            this.sercc.TabIndex = 17;
            this.sercc.Text = "Search";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1230, 90);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(285, 30);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Ticketed Passenger on Date:";
            // 
            // numOfRts
            // 
            this.numOfRts.AutoSize = true;
            this.numOfRts.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRts.Location = new System.Drawing.Point(1534, 91);
            this.numOfRts.Margin = new System.Windows.Forms.Padding(0);
            this.numOfRts.Name = "numOfRts";
            this.numOfRts.Size = new System.Drawing.Size(37, 30);
            this.numOfRts.TabIndex = 21;
            this.numOfRts.Text = "99";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(943, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.searchButton.TabIndex = 19;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::AppDev_System.Properties.Resources.refresh_left_square3_512x512;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(283, 85);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 6;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(169, 40);
            this.gunaAdvenceButton1.TabIndex = 10;
            this.gunaAdvenceButton1.Text = "REFRESH";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // addBookings
            // 
            this.addBookings.AnimationHoverSpeed = 0.07F;
            this.addBookings.AnimationSpeed = 0.03F;
            this.addBookings.BaseColor = System.Drawing.Color.Black;
            this.addBookings.BorderColor = System.Drawing.Color.Black;
            this.addBookings.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.addBookings.CheckedBorderColor = System.Drawing.Color.Black;
            this.addBookings.CheckedForeColor = System.Drawing.Color.White;
            this.addBookings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("addBookings.CheckedImage")));
            this.addBookings.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addBookings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookings.ForeColor = System.Drawing.Color.White;
            this.addBookings.Image = global::AppDev_System.Properties.Resources.plus_511x512_WHITE_;
            this.addBookings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addBookings.ImageSize = new System.Drawing.Size(20, 20);
            this.addBookings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBookings.Location = new System.Drawing.Point(52, 85);
            this.addBookings.Name = "addBookings";
            this.addBookings.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.addBookings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addBookings.OnHoverForeColor = System.Drawing.Color.White;
            this.addBookings.OnHoverImage = null;
            this.addBookings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBookings.OnPressedColor = System.Drawing.Color.Black;
            this.addBookings.Radius = 6;
            this.addBookings.Size = new System.Drawing.Size(213, 40);
            this.addBookings.TabIndex = 8;
            this.addBookings.Text = "ADD TICKET";
            this.addBookings.Click += new System.EventHandler(this.addBookings_Click);
            // 
            // UserControl_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numOfRts);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.sercc);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.BookingsGridView);
            this.Controls.Add(this.addBookings);
            this.Controls.Add(this.gunaLabel);
            this.Name = "UserControl_Booking";
            this.Size = new System.Drawing.Size(1570, 970);
            ((System.ComponentModel.ISupportInitialize)(this.BookingsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton addBookings;
        private Guna.UI.WinForms.GunaDataGridView BookingsGridView;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton searchButton;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaLabel sercc;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel numOfRts;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
