namespace AppDev_System.UserControls
{
    partial class UserControl_editAcc
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.editbutton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.esc_button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.picture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.editPic_button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.name_textBox = new Guna.UI.WinForms.GunaTextBox();
            this.email_textBox = new Guna.UI.WinForms.GunaTextBox();
            this.password_textBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaUserCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPadlockPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.password_CheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaUserCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPadlockPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(122)))));
            this.gunaPanel1.Controls.Add(this.editbutton);
            this.gunaPanel1.Controls.Add(this.esc_button);
            this.gunaPanel1.Controls.Add(this.gunaLabel);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(674, 61);
            this.gunaPanel1.TabIndex = 26;
            // 
            // editbutton
            // 
            this.editbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editbutton.AnimationHoverSpeed = 0.07F;
            this.editbutton.AnimationSpeed = 0.03F;
            this.editbutton.BaseColor = System.Drawing.Color.White;
            this.editbutton.BorderColor = System.Drawing.Color.Black;
            this.editbutton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.editbutton.CheckedBorderColor = System.Drawing.Color.Black;
            this.editbutton.CheckedForeColor = System.Drawing.Color.White;
            this.editbutton.CheckedImage = null;
            this.editbutton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.editbutton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.ForeColor = System.Drawing.Color.Black;
            this.editbutton.Image = null;
            this.editbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.editbutton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editbutton.Location = new System.Drawing.Point(551, 9);
            this.editbutton.Name = "editbutton";
            this.editbutton.OnHoverBaseColor = System.Drawing.Color.White;
            this.editbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editbutton.OnHoverForeColor = System.Drawing.Color.Black;
            this.editbutton.OnHoverImage = null;
            this.editbutton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editbutton.OnPressedColor = System.Drawing.Color.Black;
            this.editbutton.Radius = 15;
            this.editbutton.Size = new System.Drawing.Size(104, 40);
            this.editbutton.TabIndex = 26;
            this.editbutton.Text = "Save";
            this.editbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // esc_button
            // 
            this.esc_button.AnimationHoverSpeed = 0.07F;
            this.esc_button.AnimationSpeed = 0.03F;
            this.esc_button.BaseColor = System.Drawing.Color.Transparent;
            this.esc_button.BorderColor = System.Drawing.Color.Black;
            this.esc_button.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.esc_button.CheckedBorderColor = System.Drawing.Color.Black;
            this.esc_button.CheckedForeColor = System.Drawing.Color.White;
            this.esc_button.CheckedImage = global::AppDev_System.Properties.Resources.close_white;
            this.esc_button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.esc_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.esc_button.ForeColor = System.Drawing.Color.White;
            this.esc_button.Image = global::AppDev_System.Properties.Resources.close_white;
            this.esc_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.esc_button.ImageSize = new System.Drawing.Size(20, 20);
            this.esc_button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.esc_button.Location = new System.Drawing.Point(13, 9);
            this.esc_button.Name = "esc_button";
            this.esc_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.esc_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.esc_button.OnHoverForeColor = System.Drawing.Color.White;
            this.esc_button.OnHoverImage = null;
            this.esc_button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.esc_button.OnPressedColor = System.Drawing.Color.Black;
            this.esc_button.Size = new System.Drawing.Size(40, 40);
            this.esc_button.TabIndex = 25;
            this.esc_button.Click += new System.EventHandler(this.esc_button_Click);
            // 
            // gunaLabel
            // 
            this.gunaLabel.AutoSize = true;
            this.gunaLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel.ForeColor = System.Drawing.Color.White;
            this.gunaLabel.Location = new System.Drawing.Point(59, 9);
            this.gunaLabel.Name = "gunaLabel";
            this.gunaLabel.Size = new System.Drawing.Size(270, 46);
            this.gunaLabel.TabIndex = 24;
            this.gunaLabel.Text = "Edit Account \r\n";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(122)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 888);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(674, 12);
            this.gunaPanel2.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.BaseColor = System.Drawing.Color.White;
            this.picture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture.Image = global::AppDev_System.Properties.Resources.user2;
            this.picture.Location = new System.Drawing.Point(22, 82);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(169, 151);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 27;
            this.picture.TabStop = false;
            this.picture.UseTransfarantBackground = false;
            // 
            // editPic_button
            // 
            this.editPic_button.AnimationHoverSpeed = 0.07F;
            this.editPic_button.AnimationSpeed = 0.03F;
            this.editPic_button.BackColor = System.Drawing.Color.Transparent;
            this.editPic_button.BaseColor = System.Drawing.Color.Black;
            this.editPic_button.BorderColor = System.Drawing.Color.Black;
            this.editPic_button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.editPic_button.CheckedBorderColor = System.Drawing.Color.Black;
            this.editPic_button.CheckedForeColor = System.Drawing.Color.White;
            this.editPic_button.CheckedImage = null;
            this.editPic_button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.editPic_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPic_button.ForeColor = System.Drawing.Color.White;
            this.editPic_button.Image = null;
            this.editPic_button.ImageSize = new System.Drawing.Size(20, 20);
            this.editPic_button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editPic_button.Location = new System.Drawing.Point(190, 199);
            this.editPic_button.Name = "editPic_button";
            this.editPic_button.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.editPic_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editPic_button.OnHoverForeColor = System.Drawing.Color.White;
            this.editPic_button.OnHoverImage = null;
            this.editPic_button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editPic_button.OnPressedColor = System.Drawing.Color.Black;
            this.editPic_button.Radius = 6;
            this.editPic_button.Size = new System.Drawing.Size(136, 34);
            this.editPic_button.TabIndex = 27;
            this.editPic_button.Text = "Select Picture";
            this.editPic_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editPic_button.Click += new System.EventHandler(this.editPic_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.BaseColor = System.Drawing.Color.White;
            this.name_textBox.BorderColor = System.Drawing.Color.LightGray;
            this.name_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_textBox.FocusedBaseColor = System.Drawing.Color.White;
            this.name_textBox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.name_textBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.name_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.name_textBox.Location = new System.Drawing.Point(98, 268);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.PasswordChar = '\0';
            this.name_textBox.Radius = 6;
            this.name_textBox.Size = new System.Drawing.Size(501, 52);
            this.name_textBox.TabIndex = 28;
            this.name_textBox.Text = "Edit Name";
            this.name_textBox.Enter += new System.EventHandler(this.name_textBox_Enter);
            this.name_textBox.Leave += new System.EventHandler(this.name_textBox_Leave);
            // 
            // email_textBox
            // 
            this.email_textBox.BaseColor = System.Drawing.Color.White;
            this.email_textBox.BorderColor = System.Drawing.Color.LightGray;
            this.email_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textBox.FocusedBaseColor = System.Drawing.Color.White;
            this.email_textBox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.email_textBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.email_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.email_textBox.Location = new System.Drawing.Point(98, 337);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.PasswordChar = '\0';
            this.email_textBox.Radius = 6;
            this.email_textBox.Size = new System.Drawing.Size(501, 52);
            this.email_textBox.TabIndex = 29;
            this.email_textBox.Text = "Edit Email";
            this.email_textBox.Enter += new System.EventHandler(this.email_textBox_Enter);
            this.email_textBox.Leave += new System.EventHandler(this.email_textBox_Leave);
            // 
            // password_textBox
            // 
            this.password_textBox.BaseColor = System.Drawing.Color.White;
            this.password_textBox.BorderColor = System.Drawing.Color.LightGray;
            this.password_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textBox.FocusedBaseColor = System.Drawing.Color.White;
            this.password_textBox.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.password_textBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.password_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.password_textBox.Location = new System.Drawing.Point(98, 406);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '\0';
            this.password_textBox.Radius = 6;
            this.password_textBox.Size = new System.Drawing.Size(501, 52);
            this.password_textBox.TabIndex = 30;
            this.password_textBox.Text = "Edit Password";
            this.password_textBox.Enter += new System.EventHandler(this.password_textBox_Enter);
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave);
            // 
            // gunaUserCirclePictureBox2
            // 
            this.gunaUserCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaUserCirclePictureBox2.Image = global::AppDev_System.Properties.Resources.user;
            this.gunaUserCirclePictureBox2.Location = new System.Drawing.Point(30, 268);
            this.gunaUserCirclePictureBox2.Name = "gunaUserCirclePictureBox2";
            this.gunaUserCirclePictureBox2.Size = new System.Drawing.Size(49, 52);
            this.gunaUserCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaUserCirclePictureBox2.TabIndex = 31;
            this.gunaUserCirclePictureBox2.TabStop = false;
            this.gunaUserCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // gunaPadlockPictureBox2
            // 
            this.gunaPadlockPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPadlockPictureBox2.Image = global::AppDev_System.Properties.Resources.padlock1;
            this.gunaPadlockPictureBox2.Location = new System.Drawing.Point(30, 418);
            this.gunaPadlockPictureBox2.Name = "gunaPadlockPictureBox2";
            this.gunaPadlockPictureBox2.Size = new System.Drawing.Size(49, 40);
            this.gunaPadlockPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPadlockPictureBox2.TabIndex = 32;
            this.gunaPadlockPictureBox2.TabStop = false;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.LightGray;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaTextBox1.Location = new System.Drawing.Point(98, 473);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 6;
            this.gunaTextBox1.Size = new System.Drawing.Size(501, 52);
            this.gunaTextBox1.TabIndex = 33;
            this.gunaTextBox1.Text = "Re-Enter Password";
            this.gunaTextBox1.Enter += new System.EventHandler(this.gunaTextBox1_Enter);
            this.gunaTextBox1.Leave += new System.EventHandler(this.gunaTextBox1_Leave);
            // 
            // password_CheckBox
            // 
            this.password_CheckBox.BaseColor = System.Drawing.Color.White;
            this.password_CheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.password_CheckBox.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.password_CheckBox.FillColor = System.Drawing.Color.White;
            this.password_CheckBox.Location = new System.Drawing.Point(473, 540);
            this.password_CheckBox.Name = "password_CheckBox";
            this.password_CheckBox.Size = new System.Drawing.Size(126, 20);
            this.password_CheckBox.TabIndex = 34;
            this.password_CheckBox.Text = "Show Password";
            this.password_CheckBox.CheckedChanged += new System.EventHandler(this.password_CheckBox_CheckedChanged);
            // 
            // UserControl_editAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.password_CheckBox);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaPadlockPictureBox2);
            this.Controls.Add(this.gunaUserCirclePictureBox2);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.editPic_button);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UserControl_editAcc";
            this.Size = new System.Drawing.Size(674, 900);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaUserCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPadlockPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton esc_button;
        private Guna.UI.WinForms.GunaLabel gunaLabel;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton editbutton;
        private Guna.UI.WinForms.GunaCirclePictureBox picture;
        private Guna.UI.WinForms.GunaAdvenceButton editPic_button;
        private Guna.UI.WinForms.GunaTextBox name_textBox;
        private Guna.UI.WinForms.GunaTextBox email_textBox;
        private Guna.UI.WinForms.GunaTextBox password_textBox;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaUserCirclePictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPadlockPictureBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaCheckBox password_CheckBox;
    }
}
