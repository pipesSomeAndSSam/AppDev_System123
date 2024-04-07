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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Booking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.addBookings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BookingsGridView = new Guna.UI.WinForms.GunaDataGridView();
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
            this.gunaLabel.Size = new System.Drawing.Size(308, 46);
            this.gunaLabel.TabIndex = 7;
            this.gunaLabel.Text = "Booking Status";
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
            this.addBookings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addBookings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addBookings.OnHoverForeColor = System.Drawing.Color.White;
            this.addBookings.OnHoverImage = null;
            this.addBookings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBookings.OnPressedColor = System.Drawing.Color.Black;
            this.addBookings.Radius = 6;
            this.addBookings.Size = new System.Drawing.Size(213, 40);
            this.addBookings.TabIndex = 8;
            this.addBookings.Text = "ADD BOOKINGS";
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
            this.BookingsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookingsGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.BookingsGridView.ThemeStyle.ReadOnly = false;
            this.BookingsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.BookingsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BookingsGridView.ThemeStyle.RowsStyle.Height = 24;
            this.BookingsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.BookingsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // UserControl_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
