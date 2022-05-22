
namespace SWEProject
{
    partial class SignIn
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
            this.email_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dr_rb = new System.Windows.Forms.RadioButton();
            this.pat_rb = new System.Windows.Forms.RadioButton();
            this.signin_btn = new SWEProject.RoundedButton();
            this.bck_btn = new SWEProject.RoundedButton();
            this.SuspendLayout();
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.email_txt.Location = new System.Drawing.Point(378, 283);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(308, 31);
            this.email_txt.TabIndex = 0;
            this.email_txt.TextChanged += new System.EventHandler(this.email_txt_TextChanged);
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.pass_txt.Location = new System.Drawing.Point(378, 327);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(308, 31);
            this.pass_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(388, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(265, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(265, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // dr_rb
            // 
            this.dr_rb.AutoSize = true;
            this.dr_rb.BackColor = System.Drawing.Color.Transparent;
            this.dr_rb.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.dr_rb.Location = new System.Drawing.Point(528, 406);
            this.dr_rb.Margin = new System.Windows.Forms.Padding(2);
            this.dr_rb.Name = "dr_rb";
            this.dr_rb.Size = new System.Drawing.Size(158, 28);
            this.dr_rb.TabIndex = 10;
            this.dr_rb.TabStop = true;
            this.dr_rb.Text = "I am a doctor";
            this.dr_rb.UseVisualStyleBackColor = false;
            // 
            // pat_rb
            // 
            this.pat_rb.AutoSize = true;
            this.pat_rb.BackColor = System.Drawing.Color.Transparent;
            this.pat_rb.Checked = true;
            this.pat_rb.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.pat_rb.Location = new System.Drawing.Point(269, 406);
            this.pat_rb.Margin = new System.Windows.Forms.Padding(2);
            this.pat_rb.Name = "pat_rb";
            this.pat_rb.Size = new System.Drawing.Size(163, 28);
            this.pat_rb.TabIndex = 9;
            this.pat_rb.TabStop = true;
            this.pat_rb.Text = "I am a patient";
            this.pat_rb.UseVisualStyleBackColor = false;
            this.pat_rb.CheckedChanged += new System.EventHandler(this.pat_rb_CheckedChanged);
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.SystemColors.Window;
            this.signin_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.signin_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.signin_btn.BorderRadius = 20;
            this.signin_btn.BorderSize = 3;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.signin_btn.Location = new System.Drawing.Point(417, 482);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(170, 61);
            this.signin_btn.TabIndex = 23;
            this.signin_btn.Text = "Sign In";
            this.signin_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
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
            this.bck_btn.TabIndex = 24;
            this.bck_btn.Text = "Back to Main Page";
            this.bck_btn.TextColor = System.Drawing.Color.Black;
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SWEProject.Properties.Resources.background_1;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.dr_rb);
            this.Controls.Add(this.pat_rb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.email_txt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignIn";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton dr_rb;
        private System.Windows.Forms.RadioButton pat_rb;
        private RoundedButton signin_btn;
        private RoundedButton bck_btn;
    }
}