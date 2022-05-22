
namespace SWEProject
{
    partial class Report1Form
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.generate_rep = new SWEProject.RoundedButton();
            this.bck_btn = new SWEProject.RoundedButton();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 135);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1288, 667);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // generate_rep
            // 
            this.generate_rep.BackColor = System.Drawing.SystemColors.Window;
            this.generate_rep.BackgroundColor = System.Drawing.SystemColors.Window;
            this.generate_rep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.generate_rep.BorderRadius = 20;
            this.generate_rep.BorderSize = 3;
            this.generate_rep.FlatAppearance.BorderSize = 0;
            this.generate_rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_rep.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_rep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.generate_rep.Location = new System.Drawing.Point(493, 38);
            this.generate_rep.Margin = new System.Windows.Forms.Padding(4);
            this.generate_rep.Name = "generate_rep";
            this.generate_rep.Size = new System.Drawing.Size(304, 75);
            this.generate_rep.TabIndex = 30;
            this.generate_rep.Text = "Generate Report";
            this.generate_rep.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.generate_rep.UseVisualStyleBackColor = false;
            this.generate_rep.Click += new System.EventHandler(this.generate_rep_Click);
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
            this.bck_btn.Location = new System.Drawing.Point(13, 53);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(4);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(229, 60);
            this.bck_btn.TabIndex = 31;
            this.bck_btn.Text = "Back to Main Page";
            this.bck_btn.TextColor = System.Drawing.Color.Black;
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // Report1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SWEProject.Properties.Resources.background_1;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.generate_rep);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RoundedButton generate_rep;
        private RoundedButton bck_btn;
    }
}