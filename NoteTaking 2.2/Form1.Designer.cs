namespace NoteTaking_2._2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonRemainders = new FontAwesome.Sharp.IconButton();
            this.iconButtonNotes = new FontAwesome.Sharp.IconButton();
            this.iconButtonTasks = new FontAwesome.Sharp.IconButton();
            this.iconButtonMeetings = new FontAwesome.Sharp.IconButton();
            this.iconButtonRecent = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonQuit = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.iconButtonRemainders);
            this.panel1.Controls.Add(this.iconButtonNotes);
            this.panel1.Controls.Add(this.iconButtonTasks);
            this.panel1.Controls.Add(this.iconButtonMeetings);
            this.panel1.Controls.Add(this.iconButtonRecent);
            this.panel1.Controls.Add(this.iconButtonNew);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.iconButtonSettings);
            this.panel1.Controls.Add(this.iconButtonQuit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 837);
            this.panel1.TabIndex = 2;
            // 
            // iconButtonRemainders
            // 
            this.iconButtonRemainders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRemainders.FlatAppearance.BorderSize = 0;
            this.iconButtonRemainders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRemainders.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRemainders.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButtonRemainders.IconColor = System.Drawing.Color.White;
            this.iconButtonRemainders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRemainders.IconSize = 25;
            this.iconButtonRemainders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRemainders.Location = new System.Drawing.Point(0, 412);
            this.iconButtonRemainders.Name = "iconButtonRemainders";
            this.iconButtonRemainders.Size = new System.Drawing.Size(210, 61);
            this.iconButtonRemainders.TabIndex = 15;
            this.iconButtonRemainders.Text = "Remainders";
            this.iconButtonRemainders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRemainders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRemainders.UseVisualStyleBackColor = true;
            this.iconButtonRemainders.Click += new System.EventHandler(this.iconButtonRemainders_Click);
            // 
            // iconButtonNotes
            // 
            this.iconButtonNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonNotes.FlatAppearance.BorderSize = 0;
            this.iconButtonNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNotes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNotes.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.iconButtonNotes.IconColor = System.Drawing.Color.White;
            this.iconButtonNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNotes.IconSize = 25;
            this.iconButtonNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNotes.Location = new System.Drawing.Point(0, 351);
            this.iconButtonNotes.Name = "iconButtonNotes";
            this.iconButtonNotes.Size = new System.Drawing.Size(210, 61);
            this.iconButtonNotes.TabIndex = 14;
            this.iconButtonNotes.Text = "Notes";
            this.iconButtonNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNotes.UseVisualStyleBackColor = true;
            this.iconButtonNotes.Click += new System.EventHandler(this.iconButtonNotes_Click);
            // 
            // iconButtonTasks
            // 
            this.iconButtonTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTasks.FlatAppearance.BorderSize = 0;
            this.iconButtonTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTasks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTasks.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButtonTasks.IconColor = System.Drawing.Color.White;
            this.iconButtonTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTasks.IconSize = 25;
            this.iconButtonTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTasks.Location = new System.Drawing.Point(0, 290);
            this.iconButtonTasks.Name = "iconButtonTasks";
            this.iconButtonTasks.Size = new System.Drawing.Size(210, 61);
            this.iconButtonTasks.TabIndex = 13;
            this.iconButtonTasks.Text = "Tasks";
            this.iconButtonTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTasks.UseVisualStyleBackColor = true;
            this.iconButtonTasks.Click += new System.EventHandler(this.iconButtonTasks_Click);
            // 
            // iconButtonMeetings
            // 
            this.iconButtonMeetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMeetings.FlatAppearance.BorderSize = 0;
            this.iconButtonMeetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMeetings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMeetings.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconButtonMeetings.IconColor = System.Drawing.Color.White;
            this.iconButtonMeetings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMeetings.IconSize = 25;
            this.iconButtonMeetings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeetings.Location = new System.Drawing.Point(0, 229);
            this.iconButtonMeetings.Name = "iconButtonMeetings";
            this.iconButtonMeetings.Size = new System.Drawing.Size(210, 61);
            this.iconButtonMeetings.TabIndex = 12;
            this.iconButtonMeetings.Text = "Meetings";
            this.iconButtonMeetings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeetings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMeetings.UseVisualStyleBackColor = true;
            this.iconButtonMeetings.Click += new System.EventHandler(this.iconButtonMeetings_Click);
            // 
            // iconButtonRecent
            // 
            this.iconButtonRecent.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRecent.FlatAppearance.BorderSize = 0;
            this.iconButtonRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRecent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRecent.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButtonRecent.IconColor = System.Drawing.Color.White;
            this.iconButtonRecent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRecent.IconSize = 25;
            this.iconButtonRecent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRecent.Location = new System.Drawing.Point(0, 168);
            this.iconButtonRecent.Name = "iconButtonRecent";
            this.iconButtonRecent.Size = new System.Drawing.Size(210, 61);
            this.iconButtonRecent.TabIndex = 11;
            this.iconButtonRecent.Text = "Recent";
            this.iconButtonRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRecent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRecent.UseVisualStyleBackColor = true;
            this.iconButtonRecent.Click += new System.EventHandler(this.iconButtonRecent_Click);
            // 
            // iconButtonNew
            // 
            this.iconButtonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonNew.FlatAppearance.BorderSize = 0;
            this.iconButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNew.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonNew.IconColor = System.Drawing.Color.White;
            this.iconButtonNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNew.IconSize = 25;
            this.iconButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNew.Location = new System.Drawing.Point(0, 107);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Size = new System.Drawing.Size(210, 61);
            this.iconButtonNew.TabIndex = 10;
            this.iconButtonNew.Text = "New";
            this.iconButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = true;
            this.iconButtonNew.Click += new System.EventHandler(this.iconButtonNew_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 101);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "NoteTaking\r\n v 2.2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteTaking_2._2.Properties.Resources.Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconButtonSettings.IconColor = System.Drawing.Color.White;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 25;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 715);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Size = new System.Drawing.Size(210, 61);
            this.iconButtonSettings.TabIndex = 7;
            this.iconButtonSettings.Text = "Settings";
            this.iconButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSettings.UseVisualStyleBackColor = true;
            this.iconButtonSettings.Click += new System.EventHandler(this.iconButtonSettings_Click);
            // 
            // iconButtonQuit
            // 
            this.iconButtonQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonQuit.FlatAppearance.BorderSize = 0;
            this.iconButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQuit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQuit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonQuit.IconColor = System.Drawing.Color.White;
            this.iconButtonQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQuit.IconSize = 25;
            this.iconButtonQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQuit.Location = new System.Drawing.Point(0, 776);
            this.iconButtonQuit.Name = "iconButtonQuit";
            this.iconButtonQuit.Size = new System.Drawing.Size(210, 61);
            this.iconButtonQuit.TabIndex = 6;
            this.iconButtonQuit.Text = "Quit";
            this.iconButtonQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQuit.UseVisualStyleBackColor = true;
            this.iconButtonQuit.Click += new System.EventHandler(this.iconButtonQuit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.White;
            this.btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNew.IconSize = 25;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(210, 6);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.panelDesktop);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 837);
            this.panel2.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 63);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(914, 774);
            this.panelDesktop.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(598, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 74);
            this.label4.TabIndex = 2;
            this.label4.Text = "NoteTaking\r\n v 2.2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NoteTaking_2._2.Properties.Resources.Logo3;
            this.pictureBox2.Location = new System.Drawing.Point(336, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 327);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "All rights reserved 2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(150, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to NoteTaking v2.2\r\nPublished by Group-7 \r\n";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(914, 7);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTitleChildForm);
            this.panel4.Controls.Add(this.iconCurrentChildForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 56);
            this.panel4.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 17);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(56, 22);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(26, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 837);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteTaking 2.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private FontAwesome.Sharp.IconButton iconButtonQuit;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonRemainders;
        private FontAwesome.Sharp.IconButton iconButtonNotes;
        private FontAwesome.Sharp.IconButton iconButtonTasks;
        private FontAwesome.Sharp.IconButton iconButtonMeetings;
        private FontAwesome.Sharp.IconButton iconButtonRecent;
        private FontAwesome.Sharp.IconButton iconButtonNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

