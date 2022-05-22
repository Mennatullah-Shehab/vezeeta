namespace SWEProject
{
    partial class CreateAccount
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.pat_rb = new System.Windows.Forms.RadioButton();
            this.dr_rb = new System.Windows.Forms.RadioButton();
            this.specialty_label = new System.Windows.Forms.Label();
            this.starttime_label = new System.Windows.Forms.Label();
            this.endtime_label = new System.Windows.Forms.Label();
            this.aptdur_label = new System.Windows.Forms.Label();
            this.starttime_txt = new System.Windows.Forms.TextBox();
            this.endtime_txt = new System.Windows.Forms.TextBox();
            this.specialty_cmb = new System.Windows.Forms.ComboBox();
            this.aptdur_updown = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.createacc_btn = new SWEProject.RoundedButton();
            this.bck_btn = new SWEProject.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.aptdur_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(306, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(365, 126);
            this.name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(334, 31);
            this.name_txt.TabIndex = 4;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(365, 170);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(334, 31);
            this.email_txt.TabIndex = 5;
            this.email_txt.Validating += new System.ComponentModel.CancelEventHandler(this.email_txt_Validating);
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(365, 209);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(334, 31);
            this.password_txt.TabIndex = 6;
            // 
            // pat_rb
            // 
            this.pat_rb.AutoSize = true;
            this.pat_rb.BackColor = System.Drawing.Color.Transparent;
            this.pat_rb.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pat_rb.Location = new System.Drawing.Point(245, 264);
            this.pat_rb.Margin = new System.Windows.Forms.Padding(2);
            this.pat_rb.Name = "pat_rb";
            this.pat_rb.Size = new System.Drawing.Size(163, 28);
            this.pat_rb.TabIndex = 7;
            this.pat_rb.TabStop = true;
            this.pat_rb.Text = "I am a patient";
            this.pat_rb.UseVisualStyleBackColor = false;
            this.pat_rb.CheckedChanged += new System.EventHandler(this.pat_rb_CheckedChanged);
            // 
            // dr_rb
            // 
            this.dr_rb.AutoSize = true;
            this.dr_rb.BackColor = System.Drawing.Color.Transparent;
            this.dr_rb.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_rb.Location = new System.Drawing.Point(476, 264);
            this.dr_rb.Margin = new System.Windows.Forms.Padding(2);
            this.dr_rb.Name = "dr_rb";
            this.dr_rb.Size = new System.Drawing.Size(158, 28);
            this.dr_rb.TabIndex = 8;
            this.dr_rb.TabStop = true;
            this.dr_rb.Text = "I am a doctor";
            this.dr_rb.UseVisualStyleBackColor = false;
            this.dr_rb.CheckedChanged += new System.EventHandler(this.dr_rb_CheckedChanged);
            // 
            // specialty_label
            // 
            this.specialty_label.AutoSize = true;
            this.specialty_label.BackColor = System.Drawing.Color.Transparent;
            this.specialty_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_label.Location = new System.Drawing.Point(488, 359);
            this.specialty_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specialty_label.Name = "specialty_label";
            this.specialty_label.Size = new System.Drawing.Size(97, 24);
            this.specialty_label.TabIndex = 9;
            this.specialty_label.Text = "Specialty";
            this.specialty_label.Click += new System.EventHandler(this.specialty_label_Click);
            // 
            // starttime_label
            // 
            this.starttime_label.AutoSize = true;
            this.starttime_label.BackColor = System.Drawing.Color.Transparent;
            this.starttime_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime_label.Location = new System.Drawing.Point(488, 396);
            this.starttime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.starttime_label.Name = "starttime_label";
            this.starttime_label.Size = new System.Drawing.Size(110, 24);
            this.starttime_label.TabIndex = 10;
            this.starttime_label.Text = "Start Time";
            this.starttime_label.Click += new System.EventHandler(this.starttime_label_Click);
            // 
            // endtime_label
            // 
            this.endtime_label.AutoSize = true;
            this.endtime_label.BackColor = System.Drawing.Color.Transparent;
            this.endtime_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime_label.Location = new System.Drawing.Point(488, 432);
            this.endtime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endtime_label.Name = "endtime_label";
            this.endtime_label.Size = new System.Drawing.Size(100, 24);
            this.endtime_label.TabIndex = 11;
            this.endtime_label.Text = "End Time";
            this.endtime_label.Click += new System.EventHandler(this.endtime_label_Click);
            // 
            // aptdur_label
            // 
            this.aptdur_label.AutoSize = true;
            this.aptdur_label.BackColor = System.Drawing.Color.Transparent;
            this.aptdur_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptdur_label.Location = new System.Drawing.Point(487, 471);
            this.aptdur_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aptdur_label.Name = "aptdur_label";
            this.aptdur_label.Size = new System.Drawing.Size(222, 24);
            this.aptdur_label.TabIndex = 12;
            this.aptdur_label.Text = "Appointment Duration";
            this.aptdur_label.Click += new System.EventHandler(this.aptdur_label_Click);
            // 
            // starttime_txt
            // 
            this.starttime_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime_txt.Location = new System.Drawing.Point(727, 394);
            this.starttime_txt.Margin = new System.Windows.Forms.Padding(2);
            this.starttime_txt.MaxLength = 5;
            this.starttime_txt.Name = "starttime_txt";
            this.starttime_txt.Size = new System.Drawing.Size(86, 31);
            this.starttime_txt.TabIndex = 13;
            this.starttime_txt.TextChanged += new System.EventHandler(this.starttime_txt_TextChanged);
            // 
            // endtime_txt
            // 
            this.endtime_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime_txt.Location = new System.Drawing.Point(727, 429);
            this.endtime_txt.Margin = new System.Windows.Forms.Padding(2);
            this.endtime_txt.MaxLength = 5;
            this.endtime_txt.Name = "endtime_txt";
            this.endtime_txt.Size = new System.Drawing.Size(86, 31);
            this.endtime_txt.TabIndex = 14;
            this.endtime_txt.TextChanged += new System.EventHandler(this.endtime_txt_TextChanged);
            // 
            // specialty_cmb
            // 
            this.specialty_cmb.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_cmb.FormattingEnabled = true;
            this.specialty_cmb.Location = new System.Drawing.Point(727, 357);
            this.specialty_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.specialty_cmb.Name = "specialty_cmb";
            this.specialty_cmb.Size = new System.Drawing.Size(104, 32);
            this.specialty_cmb.TabIndex = 15;
            this.specialty_cmb.SelectedIndexChanged += new System.EventHandler(this.specialty_cmb_SelectedIndexChanged);
            // 
            // aptdur_updown
            // 
            this.aptdur_updown.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptdur_updown.Location = new System.Drawing.Point(727, 464);
            this.aptdur_updown.Margin = new System.Windows.Forms.Padding(2);
            this.aptdur_updown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.aptdur_updown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.aptdur_updown.Name = "aptdur_updown";
            this.aptdur_updown.Size = new System.Drawing.Size(85, 31);
            this.aptdur_updown.TabIndex = 16;
            this.aptdur_updown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.aptdur_updown.ValueChanged += new System.EventHandler(this.aptdur_updown_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(727, 321);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Appointment Fee";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // createacc_btn
            // 
            this.createacc_btn.BackColor = System.Drawing.SystemColors.Window;
            this.createacc_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.createacc_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.createacc_btn.BorderRadius = 20;
            this.createacc_btn.BorderSize = 3;
            this.createacc_btn.FlatAppearance.BorderSize = 0;
            this.createacc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createacc_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createacc_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.createacc_btn.Location = new System.Drawing.Point(365, 531);
            this.createacc_btn.Name = "createacc_btn";
            this.createacc_btn.Size = new System.Drawing.Size(228, 61);
            this.createacc_btn.TabIndex = 22;
            this.createacc_btn.Text = "Create Account";
            this.createacc_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.createacc_btn.UseVisualStyleBackColor = false;
            this.createacc_btn.Click += new System.EventHandler(this.createacc_btn_Click);
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
            this.bck_btn.Location = new System.Drawing.Point(12, 600);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(172, 49);
            this.bck_btn.TabIndex = 23;
            this.bck_btn.Text = "Back to Main Page";
            this.bck_btn.TextColor = System.Drawing.Color.Black;
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SWEProject.Properties.Resources.background_1;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.createacc_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aptdur_updown);
            this.Controls.Add(this.specialty_cmb);
            this.Controls.Add(this.endtime_txt);
            this.Controls.Add(this.starttime_txt);
            this.Controls.Add(this.aptdur_label);
            this.Controls.Add(this.endtime_label);
            this.Controls.Add(this.starttime_label);
            this.Controls.Add(this.specialty_label);
            this.Controls.Add(this.dr_rb);
            this.Controls.Add(this.pat_rb);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAccount_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptdur_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.RadioButton pat_rb;
        private System.Windows.Forms.RadioButton dr_rb;
        private System.Windows.Forms.Label specialty_label;
        private System.Windows.Forms.Label starttime_label;
        private System.Windows.Forms.Label endtime_label;
        private System.Windows.Forms.Label aptdur_label;
        private System.Windows.Forms.TextBox starttime_txt;
        private System.Windows.Forms.TextBox endtime_txt;
        private System.Windows.Forms.ComboBox specialty_cmb;
        private System.Windows.Forms.NumericUpDown aptdur_updown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private RoundedButton createacc_btn;
        private RoundedButton bck_btn;
    }
}