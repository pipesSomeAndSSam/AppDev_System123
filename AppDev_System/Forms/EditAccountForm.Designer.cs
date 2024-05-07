namespace AppDev_System.Forms
{
    partial class EditAccountForm
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
            this.editbutton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.password_CheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.password_textBox = new Guna.UI.WinForms.GunaTextBox();
            this.email_textBox = new Guna.UI.WinForms.GunaTextBox();
            this.name_textBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPadlockPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaUserCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Edit_Num = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPhonePictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.done_panel = new Guna.UI.WinForms.GunaPanel();
            this.DONE = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPadlockPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaUserCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPhonePictureBox)).BeginInit();
            this.done_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(122)))));
            this.gunaPanel1.Controls.Add(this.editbutton);
            this.gunaPanel1.Controls.Add(this.gunaLabel);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(624, 61);
            this.gunaPanel1.TabIndex = 27;
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
            this.editbutton.Location = new System.Drawing.Point(501, 9);
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
            // gunaLabel
            // 
            this.gunaLabel.AutoSize = true;
            this.gunaLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel.ForeColor = System.Drawing.Color.White;
            this.gunaLabel.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel.Name = "gunaLabel";
            this.gunaLabel.Size = new System.Drawing.Size(270, 46);
            this.gunaLabel.TabIndex = 24;
            this.gunaLabel.Text = "Edit Account \r\n";
            // 
            // password_CheckBox
            // 
            this.password_CheckBox.BaseColor = System.Drawing.Color.White;
            this.password_CheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.password_CheckBox.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.password_CheckBox.FillColor = System.Drawing.Color.White;
            this.password_CheckBox.Location = new System.Drawing.Point(465, 360);
            this.password_CheckBox.Name = "password_CheckBox";
            this.password_CheckBox.Size = new System.Drawing.Size(126, 20);
            this.password_CheckBox.TabIndex = 41;
            this.password_CheckBox.Text = "Show Password";
            this.password_CheckBox.CheckedChanged += new System.EventHandler(this.password_CheckBox_CheckedChanged);
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
            this.gunaTextBox1.Location = new System.Drawing.Point(90, 293);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 6;
            this.gunaTextBox1.Size = new System.Drawing.Size(501, 52);
            this.gunaTextBox1.TabIndex = 40;
            this.gunaTextBox1.Text = "Re-Enter Password";
            this.gunaTextBox1.Enter += new System.EventHandler(this.gunaTextBox1_Enter);
            this.gunaTextBox1.Leave += new System.EventHandler(this.gunaTextBox1_Leave);
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
            this.password_textBox.Location = new System.Drawing.Point(90, 226);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '\0';
            this.password_textBox.Radius = 6;
            this.password_textBox.Size = new System.Drawing.Size(501, 52);
            this.password_textBox.TabIndex = 37;
            this.password_textBox.Text = "Edit Password";
            this.password_textBox.Enter += new System.EventHandler(this.password_textBox_Enter);
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave);
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
            this.email_textBox.ForeColor = System.Drawing.Color.Black;
            this.email_textBox.Location = new System.Drawing.Point(90, 157);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.PasswordChar = '\0';
            this.email_textBox.Radius = 6;
            this.email_textBox.Size = new System.Drawing.Size(501, 52);
            this.email_textBox.TabIndex = 36;
            this.email_textBox.Text = "Edit Email";
            this.email_textBox.Enter += new System.EventHandler(this.email_textBox_Enter);
            this.email_textBox.Leave += new System.EventHandler(this.email_textBox_Leave);
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
            this.name_textBox.ForeColor = System.Drawing.Color.Black;
            this.name_textBox.Location = new System.Drawing.Point(90, 88);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.PasswordChar = '\0';
            this.name_textBox.Radius = 6;
            this.name_textBox.Size = new System.Drawing.Size(501, 52);
            this.name_textBox.TabIndex = 35;
            this.name_textBox.Text = "Edit Name";
            this.name_textBox.Enter += new System.EventHandler(this.name_textBox_Enter);
            this.name_textBox.Leave += new System.EventHandler(this.name_textBox_Leave);
            // 
            // gunaPadlockPictureBox2
            // 
            this.gunaPadlockPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPadlockPictureBox2.Image = global::AppDev_System.Properties.Resources.padlock1;
            this.gunaPadlockPictureBox2.Location = new System.Drawing.Point(24, 226);
            this.gunaPadlockPictureBox2.Name = "gunaPadlockPictureBox2";
            this.gunaPadlockPictureBox2.Size = new System.Drawing.Size(53, 40);
            this.gunaPadlockPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPadlockPictureBox2.TabIndex = 39;
            this.gunaPadlockPictureBox2.TabStop = false;
            // 
            // gunaUserCirclePictureBox2
            // 
            this.gunaUserCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaUserCirclePictureBox2.Image = global::AppDev_System.Properties.Resources.user;
            this.gunaUserCirclePictureBox2.Location = new System.Drawing.Point(24, 88);
            this.gunaUserCirclePictureBox2.Name = "gunaUserCirclePictureBox2";
            this.gunaUserCirclePictureBox2.Size = new System.Drawing.Size(56, 52);
            this.gunaUserCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaUserCirclePictureBox2.TabIndex = 38;
            this.gunaUserCirclePictureBox2.TabStop = false;
            this.gunaUserCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // Edit_Num
            // 
            this.Edit_Num.BaseColor = System.Drawing.Color.White;
            this.Edit_Num.BorderColor = System.Drawing.Color.LightGray;
            this.Edit_Num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Edit_Num.FocusedBaseColor = System.Drawing.Color.White;
            this.Edit_Num.FocusedBorderColor = System.Drawing.Color.DimGray;
            this.Edit_Num.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Edit_Num.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Num.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Edit_Num.Location = new System.Drawing.Point(90, 360);
            this.Edit_Num.Name = "Edit_Num";
            this.Edit_Num.PasswordChar = '\0';
            this.Edit_Num.Radius = 6;
            this.Edit_Num.Size = new System.Drawing.Size(163, 42);
            this.Edit_Num.TabIndex = 42;
            this.Edit_Num.Text = "Enter Num";
            this.Edit_Num.Enter += new System.EventHandler(this.Edit_Num_Enter);
            this.Edit_Num.Leave += new System.EventHandler(this.Edit_Num_Leave);
            // 
            // gunaPhonePictureBox
            // 
            this.gunaPhonePictureBox.BaseColor = System.Drawing.Color.White;
            this.gunaPhonePictureBox.Image = global::AppDev_System.Properties.Resources.phone_call;
            this.gunaPhonePictureBox.Location = new System.Drawing.Point(24, 362);
            this.gunaPhonePictureBox.Name = "gunaPhonePictureBox";
            this.gunaPhonePictureBox.Size = new System.Drawing.Size(50, 40);
            this.gunaPhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPhonePictureBox.TabIndex = 43;
            this.gunaPhonePictureBox.TabStop = false;
            // 
            // done_panel
            // 
            this.done_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.done_panel.Controls.Add(this.DONE);
            this.done_panel.Location = new System.Drawing.Point(0, 434);
            this.done_panel.Name = "done_panel";
            this.done_panel.Size = new System.Drawing.Size(624, 50);
            this.done_panel.TabIndex = 44;
            // 
            // DONE
            // 
            this.DONE.AutoSize = true;
            this.DONE.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONE.ForeColor = System.Drawing.Color.White;
            this.DONE.Location = new System.Drawing.Point(263, 3);
            this.DONE.Name = "DONE";
            this.DONE.Size = new System.Drawing.Size(94, 38);
            this.DONE.TabIndex = 0;
            this.DONE.Text = "DONE";
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 483);
            this.Controls.Add(this.done_panel);
            this.Controls.Add(this.gunaPhonePictureBox);
            this.Controls.Add(this.Edit_Num);
            this.Controls.Add(this.password_CheckBox);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaPadlockPictureBox2);
            this.Controls.Add(this.gunaUserCirclePictureBox2);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditAccountForm";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPadlockPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaUserCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPhonePictureBox)).EndInit();
            this.done_panel.ResumeLayout(false);
            this.done_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton editbutton;
        private Guna.UI.WinForms.GunaLabel gunaLabel;
        private Guna.UI.WinForms.GunaCheckBox password_CheckBox;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPadlockPictureBox2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaUserCirclePictureBox2;
        private Guna.UI.WinForms.GunaTextBox password_textBox;
        private Guna.UI.WinForms.GunaTextBox email_textBox;
        private Guna.UI.WinForms.GunaTextBox name_textBox;
        private Guna.UI.WinForms.GunaTextBox Edit_Num;
        private Guna.UI.WinForms.GunaPictureBox gunaPhonePictureBox;
        private Guna.UI.WinForms.GunaPanel done_panel;
        private Guna.UI.WinForms.GunaLabel DONE;
    }
}