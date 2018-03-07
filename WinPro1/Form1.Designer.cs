namespace WinPro1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.görevliİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.görevliEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.şifreGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.görevliSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.biletİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.satılanBiletlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toplamCiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seferleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seferEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.tarihLbl = new System.Windows.Forms.Label();
			this.yöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiİşlemleriToolStripMenuItem,
            this.görevliİşlemleriToolStripMenuItem,
            this.biletİşlemleriToolStripMenuItem,
            this.seferlerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.çıkışYapToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1211, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// görevliİşlemleriToolStripMenuItem
			// 
			this.görevliİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görevliEkleToolStripMenuItem,
            this.şifreGüncelleToolStripMenuItem,
            this.görevliSilToolStripMenuItem});
			this.görevliİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.görevliİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("görevliİşlemleriToolStripMenuItem.Image")));
			this.görevliİşlemleriToolStripMenuItem.Name = "görevliİşlemleriToolStripMenuItem";
			this.görevliİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
			this.görevliİşlemleriToolStripMenuItem.Text = "Görevli İşlemleri";
			// 
			// görevliEkleToolStripMenuItem
			// 
			this.görevliEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("görevliEkleToolStripMenuItem.Image")));
			this.görevliEkleToolStripMenuItem.Name = "görevliEkleToolStripMenuItem";
			this.görevliEkleToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.görevliEkleToolStripMenuItem.Text = "Görevli Ekle";
			this.görevliEkleToolStripMenuItem.Click += new System.EventHandler(this.görevliEkleToolStripMenuItem_Click);
			// 
			// şifreGüncelleToolStripMenuItem
			// 
			this.şifreGüncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreGüncelleToolStripMenuItem.Image")));
			this.şifreGüncelleToolStripMenuItem.Name = "şifreGüncelleToolStripMenuItem";
			this.şifreGüncelleToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.şifreGüncelleToolStripMenuItem.Text = "Görevli Şifre Güncelle";
			this.şifreGüncelleToolStripMenuItem.Click += new System.EventHandler(this.şifreGüncelleToolStripMenuItem_Click);
			// 
			// görevliSilToolStripMenuItem
			// 
			this.görevliSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("görevliSilToolStripMenuItem.Image")));
			this.görevliSilToolStripMenuItem.Name = "görevliSilToolStripMenuItem";
			this.görevliSilToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.görevliSilToolStripMenuItem.Text = "Görevli Sil";
			this.görevliSilToolStripMenuItem.Click += new System.EventHandler(this.görevliSilToolStripMenuItem_Click);
			// 
			// biletİşlemleriToolStripMenuItem
			// 
			this.biletİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satılanBiletlerToolStripMenuItem,
            this.toplamCiroToolStripMenuItem});
			this.biletİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.biletİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletİşlemleriToolStripMenuItem.Image")));
			this.biletİşlemleriToolStripMenuItem.Name = "biletİşlemleriToolStripMenuItem";
			this.biletİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
			this.biletİşlemleriToolStripMenuItem.Text = "Bilet İşlemleri";
			// 
			// satılanBiletlerToolStripMenuItem
			// 
			this.satılanBiletlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satılanBiletlerToolStripMenuItem.Image")));
			this.satılanBiletlerToolStripMenuItem.Name = "satılanBiletlerToolStripMenuItem";
			this.satılanBiletlerToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
			this.satılanBiletlerToolStripMenuItem.Text = "Satılan Biletler";
			this.satılanBiletlerToolStripMenuItem.Click += new System.EventHandler(this.satılanBiletlerToolStripMenuItem_Click);
			// 
			// toplamCiroToolStripMenuItem
			// 
			this.toplamCiroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toplamCiroToolStripMenuItem.Image")));
			this.toplamCiroToolStripMenuItem.Name = "toplamCiroToolStripMenuItem";
			this.toplamCiroToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
			this.toplamCiroToolStripMenuItem.Text = "Genel Bilgi";
			this.toplamCiroToolStripMenuItem.Click += new System.EventHandler(this.toplamCiroToolStripMenuItem_Click);
			// 
			// seferlerToolStripMenuItem
			// 
			this.seferlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferleriGörüntüleToolStripMenuItem,
            this.seferEkleSilToolStripMenuItem});
			this.seferlerToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.seferlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seferlerToolStripMenuItem.Image")));
			this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
			this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
			this.seferlerToolStripMenuItem.Text = "Seferler";
			// 
			// seferleriGörüntüleToolStripMenuItem
			// 
			this.seferleriGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seferleriGörüntüleToolStripMenuItem.Image")));
			this.seferleriGörüntüleToolStripMenuItem.Name = "seferleriGörüntüleToolStripMenuItem";
			this.seferleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
			this.seferleriGörüntüleToolStripMenuItem.Text = "Seferleri Görüntüle";
			this.seferleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.seferleriGörüntüleToolStripMenuItem_Click);
			// 
			// seferEkleSilToolStripMenuItem
			// 
			this.seferEkleSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seferEkleSilToolStripMenuItem.Image")));
			this.seferEkleSilToolStripMenuItem.Name = "seferEkleSilToolStripMenuItem";
			this.seferEkleSilToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
			this.seferEkleSilToolStripMenuItem.Text = "Sefer Ekle/Sil";
			this.seferEkleSilToolStripMenuItem.Click += new System.EventHandler(this.seferEkleSilToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
			// 
			// çıkışYapToolStripMenuItem
			// 
			this.çıkışYapToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.çıkışYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışYapToolStripMenuItem.Image")));
			this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
			this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
			this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
			this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SandyBrown;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(856, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kullanıcı : ";
			// 
			// tarihLbl
			// 
			this.tarihLbl.AutoSize = true;
			this.tarihLbl.BackColor = System.Drawing.Color.SandyBrown;
			this.tarihLbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tarihLbl.Location = new System.Drawing.Point(1048, 8);
			this.tarihLbl.Name = "tarihLbl";
			this.tarihLbl.Size = new System.Drawing.Size(58, 20);
			this.tarihLbl.TabIndex = 6;
			this.tarihLbl.Text = "Tarih : ";
			// 
			// yöneticiİşlemleriToolStripMenuItem
			// 
			this.yöneticiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiEkleToolStripMenuItem});
			this.yöneticiİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.yöneticiİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yöneticiİşlemleriToolStripMenuItem.Image")));
			this.yöneticiİşlemleriToolStripMenuItem.Name = "yöneticiİşlemleriToolStripMenuItem";
			this.yöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.yöneticiİşlemleriToolStripMenuItem.Text = "Yönetici İşlemleri";
			// 
			// yöneticiEkleToolStripMenuItem
			// 
			this.yöneticiEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yöneticiEkleToolStripMenuItem.Image")));
			this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
			this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.yöneticiEkleToolStripMenuItem.Text = "Yönetici Ekle";
			this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1211, 565);
			this.Controls.Add(this.tarihLbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem görevliİşlemleriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem görevliEkleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem şifreGüncelleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem görevliSilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem biletİşlemleriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem satılanBiletlerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toplamCiroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label tarihLbl;
		private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seferleriGörüntüleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seferEkleSilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yöneticiİşlemleriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
	}
}

