
namespace SWEProject
{
    partial class ViewAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointments));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bck_btn = new SWEProject.RoundedButton();
            this.updateprf_btn = new SWEProject.RoundedButton();
            this.showappts_btn = new SWEProject.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(168, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 98);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(517, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(654, 364);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 37);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(168, 463);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(989, 276);
            this.dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(415, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Appointments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(181, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter Appointments by Doctor Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(181, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Or:";
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
            this.bck_btn.Location = new System.Drawing.Point(12, 743);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(127, 60);
            this.bck_btn.TabIndex = 25;
            this.bck_btn.Text = "Back";
            this.bck_btn.TextColor = System.Drawing.Color.Black;
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // updateprf_btn
            // 
            this.updateprf_btn.BackColor = System.Drawing.Color.White;
            this.updateprf_btn.BackgroundColor = System.Drawing.Color.White;
            this.updateprf_btn.BorderColor = System.Drawing.Color.LightGray;
            this.updateprf_btn.BorderRadius = 20;
            this.updateprf_btn.BorderSize = 3;
            this.updateprf_btn.FlatAppearance.BorderSize = 0;
            this.updateprf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateprf_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateprf_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.updateprf_btn.Location = new System.Drawing.Point(524, 186);
            this.updateprf_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateprf_btn.Name = "updateprf_btn";
            this.updateprf_btn.Size = new System.Drawing.Size(320, 43);
            this.updateprf_btn.TabIndex = 26;
            this.updateprf_btn.Text = "Update Profile Details";
            this.updateprf_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.updateprf_btn.UseVisualStyleBackColor = false;
            this.updateprf_btn.Click += new System.EventHandler(this.updateprf_btn_Click);
            // 
            // showappts_btn
            // 
            this.showappts_btn.BackColor = System.Drawing.Color.White;
            this.showappts_btn.BackgroundColor = System.Drawing.Color.White;
            this.showappts_btn.BorderColor = System.Drawing.Color.LightGray;
            this.showappts_btn.BorderRadius = 20;
            this.showappts_btn.BorderSize = 3;
            this.showappts_btn.FlatAppearance.BorderSize = 0;
            this.showappts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showappts_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showappts_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.showappts_btn.Location = new System.Drawing.Point(646, 405);
            this.showappts_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showappts_btn.Name = "showappts_btn";
            this.showappts_btn.Size = new System.Drawing.Size(320, 44);
            this.showappts_btn.TabIndex = 27;
            this.showappts_btn.Text = "Show All Appointments";
            this.showappts_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.showappts_btn.UseVisualStyleBackColor = false;
            this.showappts_btn.Click += new System.EventHandler(this.showappts_btn_Click);
            // 
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.showappts_btn);
            this.Controls.Add(this.updateprf_btn);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewAppointments";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RoundedButton bck_btn;
        private RoundedButton updateprf_btn;
        private RoundedButton showappts_btn;
    }
}

