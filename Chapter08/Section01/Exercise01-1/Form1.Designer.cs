namespace Exercise01_1 {
    partial class Form1 {
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
            tbDisp = new TextBox();
            btEx_1 = new Button();
            button2 = new Button();
            btEx8_3 = new Button();
            SuspendLayout();
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(24, 216);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(757, 222);
            tbDisp.TabIndex = 0;
            tbDisp.TextChanged += tbDisp_TextChanged;
            // 
            // btEx_1
            // 
            btEx_1.Location = new Point(24, 12);
            btEx_1.Name = "btEx_1";
            btEx_1.Size = new Size(106, 52);
            btEx_1.TabIndex = 1;
            btEx_1.Text = "問題8.1";
            btEx_1.UseVisualStyleBackColor = true;
            btEx_1.Click += btEx_1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 94);
            button2.Name = "button2";
            button2.Size = new Size(106, 53);
            button2.TabIndex = 2;
            button2.Text = "問題8.2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btEx_2_Click;
            // 
            // btEx8_3
            // 
            btEx8_3.Location = new Point(169, 12);
            btEx8_3.Name = "btEx8_3";
            btEx8_3.Size = new Size(106, 53);
            btEx8_3.TabIndex = 2;
            btEx8_3.Text = "問題8.3";
            btEx8_3.UseVisualStyleBackColor = true;
            btEx8_3.Click += bt8_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btEx8_3);
            Controls.Add(button2);
            Controls.Add(btEx_1);
            Controls.Add(tbDisp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisp;
        private Button btEx_1;
        private Button button2;
        private Button btEx8_3;
    }
}
