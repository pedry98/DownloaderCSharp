using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VideoLibrary;



namespace YouTube_Mp3_Downloader
{
	public partial class Form1 : Form
    {

		
		
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
			if(validate_fields() == true)
			{
				MessageBox.Show("Please Fill out the necesssary info before downloading!!!!");//check validate method to keep going
			}

			if (validate_fields() == false)
			{
				using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })//select path
				{
					if (fbd.ShowDialog() == DialogResult.OK)
					{
						progressBar1.MarqueeAnimationSpeed = 30;//set bar speed


						try
						{
							richTextBox1.AppendText(Environment.NewLine + "		Getting Video information. Please wait while downloading...");

							var youtube = YouTube.Default;
							var video = await youtube.GetVideoAsync(textBox1.Text);
							progressBar1.Visible = true;

							if (comboBox1.Text == "mp3")
							{
								File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".mp3", await video.GetBytesAsync());
								richTextBox1.AppendText(Environment.NewLine + "Download complete to" + fbd.SelectedPath + @"\" + video.FullName);
								progressBar1.Value = 100;

							}

							if (comboBox1.Text == "m4a")// mp3  m4a wav mp4 flv avi
							{
								File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".m4a", await video.GetBytesAsync());
								richTextBox1.AppendText(Environment.NewLine + "Download complete to" + fbd.SelectedPath + @"\" + video.FullName);
								progressBar1.Value = 100;
							}

							if (comboBox1.Text == "wav")// mp3  m4a wav mp4 flv avi
							{
								File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".wav", await video.GetBytesAsync());
								richTextBox1.AppendText(Environment.NewLine + "Download complete to" + fbd.SelectedPath + @"\" + video.FullName);
								progressBar1.Value = 100;
							}

							if (comboBox1.Text == "mp4")// mp3  m4a wav mp4 flv avi
							{
								File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".mp4", await video.GetBytesAsync());
								richTextBox1.AppendText(Environment.NewLine + "Download complete to" + fbd.SelectedPath + @"\" + video.FullName);
								//progressBar1.Value = 100;

							}

							if (comboBox1.Text == "flv")// mp3  m4a wav mp4 flv avi
							{
								File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".flv", await video.GetBytesAsync());
								richTextBox1.AppendText(Environment.NewLine + "Download complete to" + fbd.SelectedPath + @"\" + video.FullName);
								progressBar1.Value = 100;
							}

							if (comboBox1.Text == "avi")// mp3  m4a wav mp4 flv avi
							{
								File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".avi", await video.GetBytesAsync());
								richTextBox1.AppendText(Environment.NewLine + "Download complete to" + fbd.SelectedPath + @"\" + video.FullName);
								progressBar1.Value = 100;
							}

							progressBar1.Visible = false;
							DialogResult dialogResult = MessageBox.Show("Do you want to download another one?", "Before you go", MessageBoxButtons.YesNo);
							if (dialogResult == DialogResult.Yes)
							{
								textBox1.Text = "";
								comboBox1.Text = "";
								webBrowser1.Visible = true;
								gbDownloader.Enabled = false;
							}
							else if (dialogResult == DialogResult.No)
							{
								Application.Exit();
							}
						}
						catch//If the link didnt work do this---->
						{
							MessageBox.Show("Failed to decrypt URL");
							progressBar1.Visible = false;
							richTextBox1.Text = "Links are spooky! Select the video again or paste the url :)";
						}
					}
				}

			}
            
        }
		void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value != 100)
			{
				progressBar1.Value++;
			}
			else
			{
				timer1.Stop();
			}
		}
		//browse on the webbrowser and return the link 
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / -1000,
						  (Screen.PrimaryScreen.WorkingArea.Height - this.Height) /2);
			this.Width = 1500;
			webBrowser1.Visible = true;
			btn_ok.Enabled = true;
			gbDownloader.Enabled = false;

			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//initialize few things
			this.Width = 500;
			webBrowser1.Visible = false;
			btn_ok.Enabled = false;
		}

		//button ok comes back with the link
		private void button2_Click(object sender, EventArgs e)
		{
			this.Width = 500;
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
						  (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		
			webBrowser1.Hide();
			btn_ok.Enabled = false;
			gbDownloader.Enabled = true;
			textBox1.Text = webBrowser1.Url.ToString();
		}

		//Check if the user inputs necessary info
		private bool validate_fields()
		{
			if(comboBox1.Text == ""||textBox1.Text == ""||comboBox1.Text == "Choose File-Format")
			{
				return true;
			}
			return false;
		}
		


	}
}
