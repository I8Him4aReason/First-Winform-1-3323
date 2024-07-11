namespace First_Winform_1_3323
{
    partial class DayForAnyDate
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
            this.label1 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.MonthDay = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Day = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(641, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "בס\"ד";
            // 
            // Month
            // 
            this.Month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Month.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Month.DisplayMember = "0";
            this.Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.Month.Location = new System.Drawing.Point(190, 41);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(283, 46);
            this.Month.TabIndex = 2;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.DarkCyan;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Year.ForeColor = System.Drawing.SystemColors.Info;
            this.Year.Location = new System.Drawing.Point(46, 41);
            this.Year.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(111, 45);
            this.Year.TabIndex = 5;
            this.Year.TabStop = false;
            this.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Year.ValueChanged += new System.EventHandler(this.Year_ValueChanged);
            // 
            // MonthDay
            // 
            this.MonthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthDay.BackColor = System.Drawing.Color.DarkCyan;
            this.MonthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MonthDay.ForeColor = System.Drawing.SystemColors.Info;
            this.MonthDay.Location = new System.Drawing.Point(515, 41);
            this.MonthDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.MonthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthDay.Name = "MonthDay";
            this.MonthDay.Size = new System.Drawing.Size(79, 45);
            this.MonthDay.TabIndex = 6;
            this.MonthDay.TabStop = false;
            this.MonthDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonthDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthDay.ValueChanged += new System.EventHandler(this.MonthDay_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(716, 99);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Day
            // 
            this.Day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Day.AutoSize = true;
            this.Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Day.Font = new System.Drawing.Font("Arial", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Day.Location = new System.Drawing.Point(49, 167);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(424, 114);
            this.Day.TabIndex = 4;
            this.Day.Text = "Shabbat";
            this.Day.Click += new System.EventHandler(this.Day_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 167);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DayForAnyDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(740, 326);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MonthDay);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DayForAnyDate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day For Any Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.NumericUpDown MonthDay;
        protected System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

