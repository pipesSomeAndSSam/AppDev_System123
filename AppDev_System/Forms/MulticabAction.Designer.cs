namespace AppDev_System.Forms
{
    partial class MulticabAction
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
            this.dequeuePanel = new Guna.UI.WinForms.GunaPanel();
            this.DATE_TIME_DEQUEUED = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            this.DATE_TIME_ADDED = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.MULTICAB_ID_LABEL_DEQUEUE = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dequeueButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.DRIVER_NAME_LABEL_DEQUEUE = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.dequeuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dequeuePanel
            // 
            this.dequeuePanel.BackColor = System.Drawing.Color.White;
            this.dequeuePanel.Controls.Add(this.DATE_TIME_DEQUEUED);
            this.dequeuePanel.Controls.Add(this.gunaLabel12);
            this.dequeuePanel.Controls.Add(this.gunaPanel7);
            this.dequeuePanel.Controls.Add(this.DATE_TIME_ADDED);
            this.dequeuePanel.Controls.Add(this.gunaLabel5);
            this.dequeuePanel.Controls.Add(this.gunaPanel5);
            this.dequeuePanel.Controls.Add(this.MULTICAB_ID_LABEL_DEQUEUE);
            this.dequeuePanel.Controls.Add(this.gunaLabel4);
            this.dequeuePanel.Controls.Add(this.dequeueButton);
            this.dequeuePanel.Controls.Add(this.gunaPanel3);
            this.dequeuePanel.Controls.Add(this.DRIVER_NAME_LABEL_DEQUEUE);
            this.dequeuePanel.Controls.Add(this.gunaLabel6);
            this.dequeuePanel.Controls.Add(this.gunaLabel9);
            this.dequeuePanel.Location = new System.Drawing.Point(0, 0);
            this.dequeuePanel.Name = "dequeuePanel";
            this.dequeuePanel.Size = new System.Drawing.Size(406, 620);
            this.dequeuePanel.TabIndex = 34;
            // 
            // DATE_TIME_DEQUEUED
            // 
            this.DATE_TIME_DEQUEUED.AutoSize = true;
            this.DATE_TIME_DEQUEUED.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_TIME_DEQUEUED.Location = new System.Drawing.Point(26, 475);
            this.DATE_TIME_DEQUEUED.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.DATE_TIME_DEQUEUED.Name = "DATE_TIME_DEQUEUED";
            this.DATE_TIME_DEQUEUED.Size = new System.Drawing.Size(254, 31);
            this.DATE_TIME_DEQUEUED.TabIndex = 37;
            this.DATE_TIME_DEQUEUED.Text = "DATE_TIME_DEQUEUED";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(14, 432);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(290, 25);
            this.gunaLabel12.TabIndex = 36;
            this.gunaLabel12.Text = "Date and Time Removed to Queue:";
            // 
            // gunaPanel7
            // 
            this.gunaPanel7.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel7.Location = new System.Drawing.Point(21, 407);
            this.gunaPanel7.Name = "gunaPanel7";
            this.gunaPanel7.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel7.TabIndex = 35;
            // 
            // DATE_TIME_ADDED
            // 
            this.DATE_TIME_ADDED.AutoSize = true;
            this.DATE_TIME_ADDED.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_TIME_ADDED.Location = new System.Drawing.Point(26, 355);
            this.DATE_TIME_ADDED.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.DATE_TIME_ADDED.Name = "DATE_TIME_ADDED";
            this.DATE_TIME_ADDED.Size = new System.Drawing.Size(212, 31);
            this.DATE_TIME_ADDED.TabIndex = 34;
            this.DATE_TIME_ADDED.Text = "DATE_TIME_ADDED";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(14, 312);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(269, 25);
            this.gunaLabel5.TabIndex = 33;
            this.gunaLabel5.Text = "Date and Time Added to Queue:";
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel5.Location = new System.Drawing.Point(21, 287);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel5.TabIndex = 32;
            // 
            // MULTICAB_ID_LABEL_DEQUEUE
            // 
            this.MULTICAB_ID_LABEL_DEQUEUE.AutoSize = true;
            this.MULTICAB_ID_LABEL_DEQUEUE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MULTICAB_ID_LABEL_DEQUEUE.Location = new System.Drawing.Point(26, 231);
            this.MULTICAB_ID_LABEL_DEQUEUE.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.MULTICAB_ID_LABEL_DEQUEUE.Name = "MULTICAB_ID_LABEL_DEQUEUE";
            this.MULTICAB_ID_LABEL_DEQUEUE.Size = new System.Drawing.Size(152, 31);
            this.MULTICAB_ID_LABEL_DEQUEUE.TabIndex = 28;
            this.MULTICAB_ID_LABEL_DEQUEUE.Text = "MULTICAB_ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(14, 188);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(107, 25);
            this.gunaLabel4.TabIndex = 27;
            this.gunaLabel4.Text = "Multicab ID:";
            // 
            // dequeueButton
            // 
            this.dequeueButton.AnimationHoverSpeed = 0.07F;
            this.dequeueButton.AnimationSpeed = 0.03F;
            this.dequeueButton.BaseColor = System.Drawing.Color.Red;
            this.dequeueButton.BorderColor = System.Drawing.Color.Black;
            this.dequeueButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dequeueButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.dequeueButton.CheckedForeColor = System.Drawing.Color.White;
            this.dequeueButton.CheckedImage = null;
            this.dequeueButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.dequeueButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueButton.ForeColor = System.Drawing.Color.White;
            this.dequeueButton.Image = null;
            this.dequeueButton.ImageSize = new System.Drawing.Size(20, 20);
            this.dequeueButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.dequeueButton.Location = new System.Drawing.Point(15, 557);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.dequeueButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dequeueButton.OnHoverForeColor = System.Drawing.Color.White;
            this.dequeueButton.OnHoverImage = null;
            this.dequeueButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.dequeueButton.OnPressedColor = System.Drawing.Color.Black;
            this.dequeueButton.Radius = 5;
            this.dequeueButton.Size = new System.Drawing.Size(168, 42);
            this.dequeueButton.TabIndex = 26;
            this.dequeueButton.Text = "Remove";
            this.dequeueButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel3.Location = new System.Drawing.Point(21, 163);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(342, 3);
            this.gunaPanel3.TabIndex = 22;
            // 
            // DRIVER_NAME_LABEL_DEQUEUE
            // 
            this.DRIVER_NAME_LABEL_DEQUEUE.AutoSize = true;
            this.DRIVER_NAME_LABEL_DEQUEUE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRIVER_NAME_LABEL_DEQUEUE.Location = new System.Drawing.Point(26, 115);
            this.DRIVER_NAME_LABEL_DEQUEUE.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.DRIVER_NAME_LABEL_DEQUEUE.Name = "DRIVER_NAME_LABEL_DEQUEUE";
            this.DRIVER_NAME_LABEL_DEQUEUE.Size = new System.Drawing.Size(238, 31);
            this.DRIVER_NAME_LABEL_DEQUEUE.TabIndex = 20;
            this.DRIVER_NAME_LABEL_DEQUEUE.Text = "NAME_DRIVER_LABEL";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(14, 83);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(115, 25);
            this.gunaLabel6.TabIndex = 19;
            this.gunaLabel6.Text = "Driver Name:";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(8, 20);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(310, 41);
            this.gunaLabel9.TabIndex = 19;
            this.gunaLabel9.Text = "Remove From Queue";
            // 
            // MulticabAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 621);
            this.Controls.Add(this.dequeuePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MulticabAction";
            this.dequeuePanel.ResumeLayout(false);
            this.dequeuePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel dequeuePanel;
        private Guna.UI.WinForms.GunaLabel MULTICAB_ID_LABEL_DEQUEUE;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton dequeueButton;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel DRIVER_NAME_LABEL_DEQUEUE;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel DATE_TIME_ADDED;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaLabel DATE_TIME_DEQUEUED;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
    }
}