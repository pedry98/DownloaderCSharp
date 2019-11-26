namespace YouTube_Mp3_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnDownload = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.gbDownloader = new System.Windows.Forms.GroupBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbDownloader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
			this.groupBox1.Location = new System.Drawing.Point(11, 42);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(560, 79);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "YouTube - URL:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 30);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(532, 27);
			this.textBox1.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
			this.groupBox2.Location = new System.Drawing.Point(11, 185);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(560, 74);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Converter:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "mp3",
            "m4a",
            "wav",
            "mp4",
            "flv",
            "avi"});
			this.comboBox1.Location = new System.Drawing.Point(16, 30);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(532, 28);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "Choose File-Format";
			// 
			// btnDownload
			// 
			this.btnDownload.BackColor = System.Drawing.Color.Green;
			this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDownload.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnDownload.Location = new System.Drawing.Point(11, 506);
			this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(560, 64);
			this.btnDownload.TabIndex = 2;
			this.btnDownload.Text = "Download";
			this.btnDownload.UseVisualStyleBackColor = false;
			this.btnDownload.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.richTextBox1);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
			this.groupBox3.Location = new System.Drawing.Point(11, 269);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(560, 167);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Status:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(11, 25);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(537, 132);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(11, 457);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(560, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(3, 3);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1320, 618);
			this.webBrowser1.TabIndex = 4;
			this.webBrowser1.Url = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackColor = System.Drawing.Color.Green;
			this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.ForeColor = System.Drawing.Color.White;
			this.btnBrowse.Location = new System.Drawing.Point(445, 128);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(126, 50);
			this.btnBrowse.TabIndex = 5;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = false;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// gbDownloader
			// 
			this.gbDownloader.Controls.Add(this.groupBox1);
			this.gbDownloader.Controls.Add(this.btnBrowse);
			this.gbDownloader.Controls.Add(this.groupBox2);
			this.gbDownloader.Controls.Add(this.btnDownload);
			this.gbDownloader.Controls.Add(this.progressBar1);
			this.gbDownloader.Controls.Add(this.groupBox3);
			this.gbDownloader.ForeColor = System.Drawing.Color.Blue;
			this.gbDownloader.Location = new System.Drawing.Point(28, 24);
			this.gbDownloader.Name = "gbDownloader";
			this.gbDownloader.Size = new System.Drawing.Size(589, 618);
			this.gbDownloader.TabIndex = 6;
			this.gbDownloader.TabStop = false;
			this.gbDownloader.Text = " ";
			// 
			// btn_ok
			// 
			this.btn_ok.BackColor = System.Drawing.Color.ForestGreen;
			this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ok.ForeColor = System.Drawing.Color.AliceBlue;
			this.btn_ok.Location = new System.Drawing.Point(1676, 666);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(110, 36);
			this.btn_ok.TabIndex = 7;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = false;
			this.btn_ok.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.webBrowser1);
			this.panel1.Location = new System.Drawing.Point(651, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1326, 624);
			this.panel1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(1835, 714);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.gbDownloader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YouTube Downloader";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.gbDownloader.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.GroupBox gbDownloader;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Panel panel1;
	}
}

