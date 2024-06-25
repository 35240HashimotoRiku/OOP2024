namespace DateTimeApp {
    partial class btDayafter {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            btDateCount = new Button();
            tbDisp = new TextBox();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            button1 = new Button();
            btAge = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 54);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "生年月日";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(275, 54);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpBirthday_ValueChanged;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(127, 135);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(182, 53);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(41, 349);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(386, 39);
            tbDisp.TabIndex = 3;
            tbDisp.TextChanged += tbDisp_TextChanged;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(61, 255);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 46);
            nudDay.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Location = new Point(263, 255);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(115, 46);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // button1
            // 
            button1.Location = new Point(419, 255);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 5;
            button1.Text = "日後";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btDayafter_Click;
            // 
            // btAge
            // 
            btAge.Location = new Point(449, 175);
            btAge.Name = "btAge";
            btAge.Size = new Size(113, 57);
            btAge.TabIndex = 6;
            btAge.Text = "年齢";
            btAge.UseVisualStyleBackColor = true;
            btAge.Click += btAge_Click;
            // 
            // btDayafter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btAge);
            Controls.Add(button1);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(6);
            Name = "btDayafter";
            Text = "生年月日";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btDateCount;
        private TextBox tbDisp;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button button1;
        private Button btAge;
    }
}
