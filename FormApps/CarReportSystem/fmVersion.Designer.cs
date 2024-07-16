namespace CarReportSystem {
    partial class fmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btVersionOk = new Button();
            label1 = new Label();
            lbVersion = new Label();
            SuspendLayout();
            // 
            // btVersionOk
            // 
            btVersionOk.Location = new Point(223, 169);
            btVersionOk.Name = "btVersionOk";
            btVersionOk.Size = new Size(75, 23);
            btVersionOk.TabIndex = 0;
            btVersionOk.Text = "OK";
            btVersionOk.UseVisualStyleBackColor = true;
            btVersionOk.Click += btVersionOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(203, 29);
            label1.TabIndex = 1;
            label1.Text = "カーレポートシステム";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Algerian", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVersion.Location = new Point(45, 90);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(83, 16);
            lbVersion.TabIndex = 2;
            lbVersion.Text = "Ver.0.0.1";
            // 
            // fmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 221);
            Controls.Add(lbVersion);
            Controls.Add(label1);
            Controls.Add(btVersionOk);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fmVersion";
            Text = "fmVersion";
            Load += fmVersion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVersionOk;
        private Label label1;
        private Label lbVersion;
    }
}