namespace SWEProject
{
    partial class DoctorInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drname_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialty_label = new System.Windows.Forms.Label();
            this.dur_label = new System.Windows.Forms.Label();
            this.hours_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bck_btn = new SWEProject.RoundedButton();
            this.procbook_btn = new SWEProject.RoundedButton();
            this.chpass_btn = new SWEProject.RoundedButton();
            this.SuspendLayout();
            // 
            // drname_label
            // 
            this.drname_label.AutoSize = true;
            this.drname_label.BackColor = System.Drawing.Color.Transparent;
            this.drname_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.drname_label.Location = new System.Drawing.Point(341, 139);
            this.drname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drname_label.Name = "drname_label";
            this.drname_label.Size = new System.Drawing.Size(375, 46);
            this.drname_label.TabIndex = 0;
            this.drname_label.Text = "Doctor Name Label";
            this.drname_label.Click += new System.EventHandler(this.drname_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Specialty:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Working Hours:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Appointment Duration:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // specialty_label
            // 
            this.specialty_label.AutoSize = true;
            this.specialty_label.BackColor = System.Drawing.Color.Transparent;
            this.specialty_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_label.Location = new System.Drawing.Point(549, 251);
            this.specialty_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specialty_label.Name = "specialty_label";
            this.specialty_label.Size = new System.Drawing.Size(108, 26);
            this.specialty_label.TabIndex = 4;
            this.specialty_label.Text = "Specialty";
            // 
            // dur_label
            // 
            this.dur_label.AutoSize = true;
            this.dur_label.BackColor = System.Drawing.Color.Transparent;
            this.dur_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dur_label.Location = new System.Drawing.Point(549, 325);
            this.dur_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dur_label.Name = "dur_label";
            this.dur_label.Size = new System.Drawing.Size(244, 26);
            this.dur_label.TabIndex = 6;
            this.dur_label.Text = "Appointment Duration";
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.BackColor = System.Drawing.Color.Transparent;
            this.hours_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_label.Location = new System.Drawing.Point(549, 288);
            this.hours_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(168, 26);
            this.hours_label.TabIndex = 5;
            this.hours_label.Text = "Working Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Appointment Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 46);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dr.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.Color.LightGray;
            this.bck_btn.BackgroundColor = System.Drawing.Color.LightGray;
            this.bck_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bck_btn.BorderRadius = 20;
            this.bck_btn.BorderSize = 0;
            this.bck_btn.FlatAppearance.BorderSize = 0;
            this.bck_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bck_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bck_btn.ForeColor = System.Drawing.Color.Black;
            this.bck_btn.Location = new System.Drawing.Point(23, 600);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(172, 49);
            this.bck_btn.TabIndex = 26;
            this.bck_btn.Text = "Back";
            this.bck_btn.TextColor = System.Drawing.Color.Black;
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // procbook_btn
            // 
            this.procbook_btn.BackColor = System.Drawing.SystemColors.Window;
            this.procbook_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.procbook_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.procbook_btn.BorderRadius = 20;
            this.procbook_btn.BorderSize = 3;
            this.procbook_btn.FlatAppearance.BorderSize = 0;
            this.procbook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procbook_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procbook_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.procbook_btn.Location = new System.Drawing.Point(390, 460);
            this.procbook_btn.Name = "procbook_btn";
            this.procbook_btn.Size = new System.Drawing.Size(228, 61);
            this.procbook_btn.TabIndex = 29;
            this.procbook_btn.Text = "Proceed to Booking";
            this.procbook_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.procbook_btn.UseVisualStyleBackColor = false;
            this.procbook_btn.Click += new System.EventHandler(this.procbook_btn_Click);
            // 
            // chpass_btn
            // 
            this.chpass_btn.BackColor = System.Drawing.Color.LightGray;
            this.chpass_btn.BackgroundColor = System.Drawing.Color.LightGray;
            this.chpass_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chpass_btn.BorderRadius = 20;
            this.chpass_btn.BorderSize = 0;
            this.chpass_btn.FlatAppearance.BorderSize = 0;
            this.chpass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chpass_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpass_btn.ForeColor = System.Drawing.Color.Black;
            this.chpass_btn.Location = new System.Drawing.Point(800, 600);
            this.chpass_btn.Name = "chpass_btn";
            this.chpass_btn.Size = new System.Drawing.Size(172, 49);
            this.chpass_btn.TabIndex = 28;
            this.chpass_btn.Text = "Change Password";
            this.chpass_btn.TextColor = System.Drawing.Color.Black;
            this.chpass_btn.UseVisualStyleBackColor = false;
            this.chpass_btn.Click += new System.EventHandler(this.chpass_btn_Click);
            // 
            // DoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SWEProject.Properties.Resources.background_1;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.procbook_btn);
            this.Controls.Add(this.chpass_btn);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dur_label);
            this.Controls.Add(this.hours_label);
            this.Controls.Add(this.specialty_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drname_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorInfo_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drname_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label specialty_label;
        private System.Windows.Forms.Label dur_label;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RoundedButton bck_btn;
        private RoundedButton procbook_btn;
        private RoundedButton chpass_btn;
    }
}