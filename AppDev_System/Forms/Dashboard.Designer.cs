namespace AppDev_System
{
    partial class Dashboard
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.SeatsButtons = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BookingsButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.RoutesButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MulticabsButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DashboardButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.userName = new Guna.UI.WinForms.GunaLabel();
            this.LOGOUTButt = new Guna.UI.WinForms.GunaAdvenceButton();
            this.userControl_Routes1 = new AppDev_System.UserControls.UserControl_Routes();
            this.userControl1_Dash1 = new AppDev_System.UserControls.UserControl1_Dash();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel18);
            this.gunaPanel1.Controls.Add(this.SeatsButtons);
            this.gunaPanel1.Controls.Add(this.BookingsButton);
            this.gunaPanel1.Controls.Add(this.RoutesButton);
            this.gunaPanel1.Controls.Add(this.MulticabsButton);
            this.gunaPanel1.Controls.Add(this.DashboardButton);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(350, 1080);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(12, 321);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(317, 44);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "email";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel18.Location = new System.Drawing.Point(43, 27);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(247, 35);
            this.gunaLabel18.TabIndex = 8;
            this.gunaLabel18.Text = "Booking System";
            this.gunaLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeatsButtons
            // 
            this.SeatsButtons.AnimationHoverSpeed = 0.07F;
            this.SeatsButtons.AnimationSpeed = 0.03F;
            this.SeatsButtons.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.SeatsButtons.BorderColor = System.Drawing.Color.Black;
            this.SeatsButtons.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.SeatsButtons.CheckedBaseColor = System.Drawing.Color.White;
            this.SeatsButtons.CheckedBorderColor = System.Drawing.Color.Black;
            this.SeatsButtons.CheckedForeColor = System.Drawing.Color.Black;
            this.SeatsButtons.CheckedImage = global::AppDev_System.Properties.Resources.road_with_broken_line;
            this.SeatsButtons.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SeatsButtons.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsButtons.ForeColor = System.Drawing.Color.White;
            this.SeatsButtons.Image = global::AppDev_System.Properties.Resources.grids_256x256;
            this.SeatsButtons.ImageSize = new System.Drawing.Size(30, 30);
            this.SeatsButtons.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SeatsButtons.Location = new System.Drawing.Point(0, 807);
            this.SeatsButtons.Name = "SeatsButtons";
            this.SeatsButtons.OnHoverBaseColor = System.Drawing.Color.White;
            this.SeatsButtons.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SeatsButtons.OnHoverForeColor = System.Drawing.Color.Black;
            this.SeatsButtons.OnHoverImage = null;
            this.SeatsButtons.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SeatsButtons.OnPressedColor = System.Drawing.Color.Black;
            this.SeatsButtons.Size = new System.Drawing.Size(350, 91);
            this.SeatsButtons.TabIndex = 7;
            this.SeatsButtons.Text = "Seats";
            // 
            // BookingsButton
            // 
            this.BookingsButton.AnimationHoverSpeed = 0.07F;
            this.BookingsButton.AnimationSpeed = 0.03F;
            this.BookingsButton.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.BookingsButton.BorderColor = System.Drawing.Color.Black;
            this.BookingsButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.BookingsButton.CheckedBaseColor = System.Drawing.Color.White;
            this.BookingsButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.BookingsButton.CheckedForeColor = System.Drawing.Color.Black;
            this.BookingsButton.CheckedImage = global::AppDev_System.Properties.Resources.road_with_broken_line;
            this.BookingsButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BookingsButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsButton.ForeColor = System.Drawing.Color.White;
            this.BookingsButton.Image = global::AppDev_System.Properties.Resources.tickets;
            this.BookingsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.BookingsButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BookingsButton.Location = new System.Drawing.Point(0, 710);
            this.BookingsButton.Name = "BookingsButton";
            this.BookingsButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.BookingsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BookingsButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.BookingsButton.OnHoverImage = null;
            this.BookingsButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BookingsButton.OnPressedColor = System.Drawing.Color.Black;
            this.BookingsButton.Size = new System.Drawing.Size(350, 91);
            this.BookingsButton.TabIndex = 6;
            this.BookingsButton.Text = "Bookings";
            // 
            // RoutesButton
            // 
            this.RoutesButton.AnimationHoverSpeed = 0.07F;
            this.RoutesButton.AnimationSpeed = 0.03F;
            this.RoutesButton.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoutesButton.BorderColor = System.Drawing.Color.Black;
            this.RoutesButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.RoutesButton.CheckedBaseColor = System.Drawing.Color.White;
            this.RoutesButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.RoutesButton.CheckedForeColor = System.Drawing.Color.Black;
            this.RoutesButton.CheckedImage = global::AppDev_System.Properties.Resources.road_with_broken_line;
            this.RoutesButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.RoutesButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutesButton.ForeColor = System.Drawing.Color.White;
            this.RoutesButton.Image = global::AppDev_System.Properties.Resources.road_with_broken_line1;
            this.RoutesButton.ImageSize = new System.Drawing.Size(30, 30);
            this.RoutesButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RoutesButton.Location = new System.Drawing.Point(0, 613);
            this.RoutesButton.Name = "RoutesButton";
            this.RoutesButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.RoutesButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RoutesButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.RoutesButton.OnHoverImage = null;
            this.RoutesButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.RoutesButton.OnPressedColor = System.Drawing.Color.Black;
            this.RoutesButton.Size = new System.Drawing.Size(350, 91);
            this.RoutesButton.TabIndex = 5;
            this.RoutesButton.Text = "Routes";
            this.RoutesButton.Click += new System.EventHandler(this.RoutesButton_Click);
            // 
            // MulticabsButton
            // 
            this.MulticabsButton.AnimationHoverSpeed = 0.07F;
            this.MulticabsButton.AnimationSpeed = 0.03F;
            this.MulticabsButton.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.MulticabsButton.BorderColor = System.Drawing.Color.Black;
            this.MulticabsButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.MulticabsButton.CheckedBaseColor = System.Drawing.Color.White;
            this.MulticabsButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MulticabsButton.CheckedForeColor = System.Drawing.Color.Black;
            this.MulticabsButton.CheckedImage = global::AppDev_System.Properties.Resources.speedometer;
            this.MulticabsButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.MulticabsButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulticabsButton.ForeColor = System.Drawing.Color.White;
            this.MulticabsButton.Image = global::AppDev_System.Properties.Resources.bus_vehicle;
            this.MulticabsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.MulticabsButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.MulticabsButton.Location = new System.Drawing.Point(0, 516);
            this.MulticabsButton.Name = "MulticabsButton";
            this.MulticabsButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.MulticabsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MulticabsButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.MulticabsButton.OnHoverImage = null;
            this.MulticabsButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.MulticabsButton.OnPressedColor = System.Drawing.Color.Black;
            this.MulticabsButton.Size = new System.Drawing.Size(350, 91);
            this.MulticabsButton.TabIndex = 4;
            this.MulticabsButton.Text = "Multicabs";
            this.MulticabsButton.Click += new System.EventHandler(this.MulticabsButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.AnimationHoverSpeed = 0.07F;
            this.DashboardButton.AnimationSpeed = 0.03F;
            this.DashboardButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DashboardButton.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.DashboardButton.BorderColor = System.Drawing.Color.Black;
            this.DashboardButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.DashboardButton.Checked = true;
            this.DashboardButton.CheckedBaseColor = System.Drawing.Color.White;
            this.DashboardButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.DashboardButton.CheckedForeColor = System.Drawing.Color.Black;
            this.DashboardButton.CheckedImage = global::AppDev_System.Properties.Resources.speedometer;
            this.DashboardButton.CheckedLineColor = System.Drawing.SystemColors.HotTrack;
            this.DashboardButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Image = global::AppDev_System.Properties.Resources.speedometer;
            this.DashboardButton.ImageSize = new System.Drawing.Size(30, 30);
            this.DashboardButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DashboardButton.Location = new System.Drawing.Point(0, 419);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.DashboardButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DashboardButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.DashboardButton.OnHoverImage = null;
            this.DashboardButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DashboardButton.OnPressedColor = System.Drawing.Color.Black;
            this.DashboardButton.Size = new System.Drawing.Size(350, 91);
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel3.Location = new System.Drawing.Point(12, 365);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(295, 35);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "System Administrator";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::AppDev_System.Properties.Resources.user2;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(42, 79);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(248, 239);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(365, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(154, 35);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Welcome,";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userName.Location = new System.Drawing.Point(522, 27);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(83, 35);
            this.userName.TabIndex = 2;
            this.userName.Text = "User";
            // 
            // LOGOUTButt
            // 
            this.LOGOUTButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGOUTButt.AnimationHoverSpeed = 0.07F;
            this.LOGOUTButt.AnimationSpeed = 0.03F;
            this.LOGOUTButt.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.LOGOUTButt.BorderColor = System.Drawing.Color.Black;
            this.LOGOUTButt.CheckedBaseColor = System.Drawing.SystemColors.Highlight;
            this.LOGOUTButt.CheckedBorderColor = System.Drawing.Color.Black;
            this.LOGOUTButt.CheckedForeColor = System.Drawing.Color.White;
            this.LOGOUTButt.CheckedImage = null;
            this.LOGOUTButt.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LOGOUTButt.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUTButt.ForeColor = System.Drawing.Color.White;
            this.LOGOUTButt.Image = null;
            this.LOGOUTButt.ImageSize = new System.Drawing.Size(20, 20);
            this.LOGOUTButt.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LOGOUTButt.Location = new System.Drawing.Point(1727, 27);
            this.LOGOUTButt.Name = "LOGOUTButt";
            this.LOGOUTButt.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.LOGOUTButt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LOGOUTButt.OnHoverForeColor = System.Drawing.Color.White;
            this.LOGOUTButt.OnHoverImage = null;
            this.LOGOUTButt.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LOGOUTButt.OnPressedColor = System.Drawing.Color.Black;
            this.LOGOUTButt.Radius = 6;
            this.LOGOUTButt.Size = new System.Drawing.Size(167, 50);
            this.LOGOUTButt.TabIndex = 3;
            this.LOGOUTButt.Text = "LOGOUT";
            this.LOGOUTButt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LOGOUTButt.Click += new System.EventHandler(this.LOGOUTButt_Click);
            // 
            // userControl_Routes1
            // 
            this.userControl_Routes1.Location = new System.Drawing.Point(350, 110);
            this.userControl_Routes1.Name = "userControl_Routes1";
            this.userControl_Routes1.Size = new System.Drawing.Size(1570, 970);
            this.userControl_Routes1.TabIndex = 5;
            // 
            // userControl1_Dash1
            // 
            this.userControl1_Dash1.Location = new System.Drawing.Point(350, 110);
            this.userControl1_Dash1.Name = "userControl1_Dash1";
            this.userControl1_Dash1.Size = new System.Drawing.Size(1570, 970);
            this.userControl1_Dash1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userControl_Routes1);
            this.Controls.Add(this.userControl1_Dash1);
            this.Controls.Add(this.LOGOUTButt);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel userName;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton DashboardButton;
        private Guna.UI.WinForms.GunaAdvenceButton MulticabsButton;
        private Guna.UI.WinForms.GunaAdvenceButton RoutesButton;
        private Guna.UI.WinForms.GunaAdvenceButton BookingsButton;
        private Guna.UI.WinForms.GunaAdvenceButton SeatsButtons;
        private Guna.UI.WinForms.GunaAdvenceButton LOGOUTButt;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private UserControls.UserControl1_Dash userControl1_Dash1;
        private UserControls.UserControl_Routes userControl_Routes1;
    }
}