namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.KokunaiNews = new System.Windows.Forms.RadioButton();
            this.KokusaiNews = new System.Windows.Forms.RadioButton();
            this.KeizaiNews = new System.Windows.Forms.RadioButton();
            this.EntameNews = new System.Windows.Forms.RadioButton();
            this.SportsNews = new System.Windows.Forms.RadioButton();
            this.ItNews = new System.Windows.Forms.RadioButton();
            this.KagakuNews = new System.Windows.Forms.RadioButton();
            this.TikiNews = new System.Windows.Forms.RadioButton();
            this.MainNews = new System.Windows.Forms.RadioButton();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Location = new System.Drawing.Point(0, 0);
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(652, 19);
            this.tbRssUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(658, 0);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 25);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(339, 592);
            this.lbRssTitle.TabIndex = 2;
            // 
            // KokunaiNews
            // 
            this.KokunaiNews.AutoSize = true;
            this.KokunaiNews.Location = new System.Drawing.Point(524, 38);
            this.KokunaiNews.Name = "KokunaiNews";
            this.KokunaiNews.Size = new System.Drawing.Size(83, 16);
            this.KokunaiNews.TabIndex = 3;
            this.KokunaiNews.TabStop = true;
            this.KokunaiNews.Text = "国内ニュース";
            this.KokunaiNews.UseVisualStyleBackColor = true;
            this.KokunaiNews.CheckedChanged += new System.EventHandler(this.KokunaiNews_CheckedChanged);
            // 
            // KokusaiNews
            // 
            this.KokusaiNews.AutoSize = true;
            this.KokusaiNews.Location = new System.Drawing.Point(631, 38);
            this.KokusaiNews.Name = "KokusaiNews";
            this.KokusaiNews.Size = new System.Drawing.Size(83, 16);
            this.KokusaiNews.TabIndex = 4;
            this.KokusaiNews.TabStop = true;
            this.KokusaiNews.Text = "国際ニュース";
            this.KokusaiNews.UseVisualStyleBackColor = true;
            this.KokusaiNews.CheckedChanged += new System.EventHandler(this.KokusaiNews_CheckedChanged);
            // 
            // KeizaiNews
            // 
            this.KeizaiNews.AutoSize = true;
            this.KeizaiNews.Location = new System.Drawing.Point(411, 79);
            this.KeizaiNews.Name = "KeizaiNews";
            this.KeizaiNews.Size = new System.Drawing.Size(83, 16);
            this.KeizaiNews.TabIndex = 5;
            this.KeizaiNews.TabStop = true;
            this.KeizaiNews.Text = "経済ニュース";
            this.KeizaiNews.UseVisualStyleBackColor = true;
            this.KeizaiNews.CheckedChanged += new System.EventHandler(this.KeizaiNews_CheckedChanged);
            // 
            // EntameNews
            // 
            this.EntameNews.AutoSize = true;
            this.EntameNews.Location = new System.Drawing.Point(524, 79);
            this.EntameNews.Name = "EntameNews";
            this.EntameNews.Size = new System.Drawing.Size(93, 16);
            this.EntameNews.TabIndex = 6;
            this.EntameNews.TabStop = true;
            this.EntameNews.Text = "エンタメニュース";
            this.EntameNews.UseVisualStyleBackColor = true;
            this.EntameNews.CheckedChanged += new System.EventHandler(this.EntameNews_CheckedChanged);
            // 
            // SportsNews
            // 
            this.SportsNews.AutoSize = true;
            this.SportsNews.Location = new System.Drawing.Point(631, 79);
            this.SportsNews.Name = "SportsNews";
            this.SportsNews.Size = new System.Drawing.Size(97, 16);
            this.SportsNews.TabIndex = 7;
            this.SportsNews.TabStop = true;
            this.SportsNews.Text = "スポーツニュース";
            this.SportsNews.UseVisualStyleBackColor = true;
            this.SportsNews.CheckedChanged += new System.EventHandler(this.SportsNews_CheckedChanged);
            // 
            // ItNews
            // 
            this.ItNews.AutoSize = true;
            this.ItNews.Location = new System.Drawing.Point(411, 129);
            this.ItNews.Name = "ItNews";
            this.ItNews.Size = new System.Drawing.Size(69, 16);
            this.ItNews.TabIndex = 8;
            this.ItNews.TabStop = true;
            this.ItNews.Text = "ITニュース";
            this.ItNews.UseVisualStyleBackColor = true;
            this.ItNews.CheckedChanged += new System.EventHandler(this.ItNews_CheckedChanged);
            // 
            // KagakuNews
            // 
            this.KagakuNews.AutoSize = true;
            this.KagakuNews.Location = new System.Drawing.Point(524, 129);
            this.KagakuNews.Name = "KagakuNews";
            this.KagakuNews.Size = new System.Drawing.Size(83, 16);
            this.KagakuNews.TabIndex = 9;
            this.KagakuNews.TabStop = true;
            this.KagakuNews.Text = "科学ニュース";
            this.KagakuNews.UseVisualStyleBackColor = true;
            this.KagakuNews.CheckedChanged += new System.EventHandler(this.KagakuNews_CheckedChanged);
            // 
            // TikiNews
            // 
            this.TikiNews.AutoSize = true;
            this.TikiNews.Location = new System.Drawing.Point(631, 129);
            this.TikiNews.Name = "TikiNews";
            this.TikiNews.Size = new System.Drawing.Size(83, 16);
            this.TikiNews.TabIndex = 10;
            this.TikiNews.TabStop = true;
            this.TikiNews.Text = "地域ニュース";
            this.TikiNews.UseVisualStyleBackColor = true;
            this.TikiNews.CheckedChanged += new System.EventHandler(this.TikiNews_CheckedChanged);
            // 
            // MainNews
            // 
            this.MainNews.AutoSize = true;
            this.MainNews.Location = new System.Drawing.Point(411, 38);
            this.MainNews.Name = "MainNews";
            this.MainNews.Size = new System.Drawing.Size(83, 16);
            this.MainNews.TabIndex = 11;
            this.MainNews.TabStop = true;
            this.MainNews.Text = "主要ニュース";
            this.MainNews.UseVisualStyleBackColor = true;
            this.MainNews.CheckedChanged += new System.EventHandler(this.MainNews_CheckedChanged);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(388, 187);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(560, 431);
            this.webView21.TabIndex = 12;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 638);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.MainNews);
            this.Controls.Add(this.TikiNews);
            this.Controls.Add(this.KagakuNews);
            this.Controls.Add(this.ItNews);
            this.Controls.Add(this.SportsNews);
            this.Controls.Add(this.EntameNews);
            this.Controls.Add(this.KeizaiNews);
            this.Controls.Add(this.KokusaiNews);
            this.Controls.Add(this.KokunaiNews);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbRssUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRssUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.RadioButton KokunaiNews;
        private System.Windows.Forms.RadioButton KokusaiNews;
        private System.Windows.Forms.RadioButton KeizaiNews;
        private System.Windows.Forms.RadioButton EntameNews;
        private System.Windows.Forms.RadioButton SportsNews;
        private System.Windows.Forms.RadioButton ItNews;
        private System.Windows.Forms.RadioButton KagakuNews;
        private System.Windows.Forms.RadioButton TikiNews;
        private System.Windows.Forms.RadioButton MainNews;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

