


namespace SWEProject
{
    partial class BookAppt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAppt));
            this.timeslots_gridview = new System.Windows.Forms.DataGridView();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptdate_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bck_btn = new SWEProject.RoundedButton();
            this.book_btn = new SWEProject.RoundedButton();
            this.search_btn = new SWEProject.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.timeslots_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // timeslots_gridview
            // 
            this.timeslots_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeslots_gridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.timeslots_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeslots_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeSlot});
            this.timeslots_gridview.Location = new System.Drawing.Point(323, 186);
            this.timeslots_gridview.Margin = new System.Windows.Forms.Padding(2);
            this.timeslots_gridview.Name = "timeslots_gridview";
            this.timeslots_gridview.RowHeadersWidth = 51;
            this.timeslots_gridview.RowTemplate.Height = 25;
            this.timeslots_gridview.Size = new System.Drawing.Size(362, 326);
            this.timeslots_gridview.TabIndex = 0;
            this.timeslots_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TimeSlot
            // 
            this.TimeSlot.DataPropertyName = "time";
            this.TimeSlot.HeaderText = "Time Slots";
            this.TimeSlot.MinimumWidth = 6;
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.ReadOnly = true;
            // 
            // apptdate_picker
            // 
            this.apptdate_picker.CalendarFont = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.apptdate_picker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.apptdate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.apptdate_picker.Location = new System.Drawing.Point(504, 59);
            this.apptdate_picker.Margin = new System.Windows.Forms.Padding(2);
            this.apptdate_picker.Name = "apptdate_picker";
            this.apptdate_picker.Size = new System.Drawing.Size(287, 29);
            this.apptdate_picker.TabIndex = 3;
            this.apptdate_picker.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            this.apptdate_picker.ValueChanged += new System.EventHandler(this.apptdate_picker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(209, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter appointment date:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            this.bck_btn.Location = new System.Drawing.Point(25, 600);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(95, 49);
            this.bck_btn.TabIndex = 24;
            this.bck_btn.Text = "Back";
            this.bck_btn.TextColor = System.Drawing.Color.Black;
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // book_btn
            // 
            this.book_btn.BackColor = System.Drawing.SystemColors.Window;
            this.book_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.book_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.book_btn.BorderRadius = 20;
            this.book_btn.BorderSize = 3;
            this.book_btn.FlatAppearance.BorderSize = 0;
            this.book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.book_btn.Location = new System.Drawing.Point(389, 530);
            this.book_btn.Name = "book_btn";
            this.book_btn.Size = new System.Drawing.Size(228, 61);
            this.book_btn.TabIndex = 25;
            this.book_btn.Text = "Book Appointment";
            this.book_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.book_btn.UseVisualStyleBackColor = false;
            this.book_btn.Click += new System.EventHandler(this.book_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.search_btn.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.search_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.search_btn.BorderRadius = 20;
            this.search_btn.BorderSize = 3;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(450, 117);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(106, 49);
            this.search_btn.TabIndex = 26;
            this.search_btn.Text = "Search";
            this.search_btn.TextColor = System.Drawing.Color.Black;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // BookAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.book_btn);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apptdate_picker);
            this.Controls.Add(this.timeslots_gridview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookAppt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookAppt_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeslots_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timeslots_gridview;
        private System.Windows.Forms.DateTimePicker apptdate_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
        private RoundedButton bck_btn;
        private RoundedButton book_btn;
        private RoundedButton search_btn;
    }
}