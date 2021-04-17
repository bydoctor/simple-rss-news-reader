
namespace RSSOkumaUygulamasi
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
            this.btn_getir = new System.Windows.Forms.Button();
            this.lst_baslik = new System.Windows.Forms.ListBox();
            this.rssUrl = new System.Windows.Forms.GroupBox();
            this.txt_rssurl = new System.Windows.Forms.TextBox();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.haberBaslik = new System.Windows.Forms.GroupBox();
            this.detay = new System.Windows.Forms.GroupBox();
            this.rssUrl.SuspendLayout();
            this.haberBaslik.SuspendLayout();
            this.detay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(1276, 29);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 33);
            this.btn_getir.TabIndex = 0;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lst_baslik
            // 
            this.lst_baslik.FormattingEnabled = true;
            this.lst_baslik.ItemHeight = 16;
            this.lst_baslik.Location = new System.Drawing.Point(6, 21);
            this.lst_baslik.Name = "lst_baslik";
            this.lst_baslik.Size = new System.Drawing.Size(281, 564);
            this.lst_baslik.TabIndex = 1;
            this.lst_baslik.SelectedIndexChanged += new System.EventHandler(this.lst_baslik_SelectedIndexChanged);
            // 
            // rssUrl
            // 
            this.rssUrl.Controls.Add(this.txt_rssurl);
            this.rssUrl.Controls.Add(this.btn_getir);
            this.rssUrl.Location = new System.Drawing.Point(12, 12);
            this.rssUrl.Name = "rssUrl";
            this.rssUrl.Size = new System.Drawing.Size(1410, 87);
            this.rssUrl.TabIndex = 2;
            this.rssUrl.TabStop = false;
            this.rssUrl.Text = "RSS URL";
            // 
            // txt_rssurl
            // 
            this.txt_rssurl.Location = new System.Drawing.Point(6, 34);
            this.txt_rssurl.Name = "txt_rssurl";
            this.txt_rssurl.Size = new System.Drawing.Size(1230, 22);
            this.txt_rssurl.TabIndex = 3;
            this.txt_rssurl.Text = "https://www.sabah.com.tr/rss/gundem.xml";
            // 
            // web_browser
            // 
            this.web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_browser.Location = new System.Drawing.Point(3, 18);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(1087, 581);
            this.web_browser.TabIndex = 4;
            // 
            // haberBaslik
            // 
            this.haberBaslik.Controls.Add(this.lst_baslik);
            this.haberBaslik.Location = new System.Drawing.Point(18, 128);
            this.haberBaslik.Name = "haberBaslik";
            this.haberBaslik.Size = new System.Drawing.Size(293, 602);
            this.haberBaslik.TabIndex = 5;
            this.haberBaslik.TabStop = false;
            this.haberBaslik.Text = "Haber Başlıkları";
            // 
            // detay
            // 
            this.detay.Controls.Add(this.web_browser);
            this.detay.Location = new System.Drawing.Point(329, 128);
            this.detay.Name = "detay";
            this.detay.Size = new System.Drawing.Size(1093, 602);
            this.detay.TabIndex = 6;
            this.detay.TabStop = false;
            this.detay.Text = "Haber Detay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 777);
            this.Controls.Add(this.detay);
            this.Controls.Add(this.haberBaslik);
            this.Controls.Add(this.rssUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS OKUMA UYGULAMASI";
            this.rssUrl.ResumeLayout(false);
            this.rssUrl.PerformLayout();
            this.haberBaslik.ResumeLayout(false);
            this.detay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.ListBox lst_baslik;
        private System.Windows.Forms.GroupBox rssUrl;
        private System.Windows.Forms.TextBox txt_rssurl;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.GroupBox haberBaslik;
        private System.Windows.Forms.GroupBox detay;
    }
}

