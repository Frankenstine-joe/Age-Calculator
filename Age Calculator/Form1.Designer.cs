namespace Age_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DobDays = new System.Windows.Forms.NumericUpDown();
            this.DobMonths = new System.Windows.Forms.NumericUpDown();
            this.DobYear = new System.Windows.Forms.NumericUpDown();
            this.NowDay = new System.Windows.Forms.NumericUpDown();
            this.NowMonth = new System.Windows.Forms.NumericUpDown();
            this.NowYear = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DobDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Of birth / Specified date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today / Required Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DobDays
            // 
            this.DobDays.Location = new System.Drawing.Point(361, 154);
            this.DobDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.DobDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DobDays.Name = "DobDays";
            this.DobDays.Size = new System.Drawing.Size(82, 22);
            this.DobDays.TabIndex = 4;
            this.DobDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DobMonths
            // 
            this.DobMonths.Location = new System.Drawing.Point(467, 154);
            this.DobMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DobMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DobMonths.Name = "DobMonths";
            this.DobMonths.Size = new System.Drawing.Size(82, 22);
            this.DobMonths.TabIndex = 4;
            this.DobMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DobYear
            // 
            this.DobYear.Location = new System.Drawing.Point(573, 154);
            this.DobYear.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.DobYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DobYear.Name = "DobYear";
            this.DobYear.Size = new System.Drawing.Size(82, 22);
            this.DobYear.TabIndex = 4;
            this.DobYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NowDay
            // 
            this.NowDay.Location = new System.Drawing.Point(361, 199);
            this.NowDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NowDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NowDay.Name = "NowDay";
            this.NowDay.Size = new System.Drawing.Size(82, 22);
            this.NowDay.TabIndex = 4;
            this.NowDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NowMonth
            // 
            this.NowMonth.Location = new System.Drawing.Point(467, 199);
            this.NowMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NowMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NowMonth.Name = "NowMonth";
            this.NowMonth.Size = new System.Drawing.Size(82, 22);
            this.NowMonth.TabIndex = 4;
            this.NowMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NowYear
            // 
            this.NowYear.Location = new System.Drawing.Point(573, 199);
            this.NowYear.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NowYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NowYear.Name = "NowYear";
            this.NowYear.Size = new System.Drawing.Size(82, 22);
            this.NowYear.TabIndex = 4;
            this.NowYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Month";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(591, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Light", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ancient Ages Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NowYear);
            this.Controls.Add(this.NowMonth);
            this.Controls.Add(this.DobYear);
            this.Controls.Add(this.NowDay);
            this.Controls.Add(this.DobMonths);
            this.Controls.Add(this.DobDays);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DobDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DobYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown DobDays;
        private System.Windows.Forms.NumericUpDown DobMonths;
        private System.Windows.Forms.NumericUpDown DobYear;
        private System.Windows.Forms.NumericUpDown NowDay;
        private System.Windows.Forms.NumericUpDown NowMonth;
        private System.Windows.Forms.NumericUpDown NowYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

