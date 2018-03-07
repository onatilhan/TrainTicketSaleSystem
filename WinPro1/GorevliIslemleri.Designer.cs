namespace WinPro1
{
	partial class GorevliIslemleri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevliIslemleri));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yeniBiletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.biletİptaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.biletSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.özelİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletToolStripMenuItem,
            this.özelİşlemlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1217, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// biletToolStripMenuItem
			// 
			this.biletToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
			this.biletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniBiletToolStripMenuItem,
            this.biletİptaliToolStripMenuItem,
            this.biletSorgulaToolStripMenuItem});
			this.biletToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.biletToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletToolStripMenuItem.Image")));
			this.biletToolStripMenuItem.Name = "biletToolStripMenuItem";
			this.biletToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
			this.biletToolStripMenuItem.Text = "Bilet İşlemleri";
			// 
			// yeniBiletToolStripMenuItem
			// 
			this.yeniBiletToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniBiletToolStripMenuItem.Image")));
			this.yeniBiletToolStripMenuItem.Name = "yeniBiletToolStripMenuItem";
			this.yeniBiletToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.yeniBiletToolStripMenuItem.Text = "Yeni Bilet";
			this.yeniBiletToolStripMenuItem.Click += new System.EventHandler(this.yeniBiletToolStripMenuItem_Click);
			// 
			// biletİptaliToolStripMenuItem
			// 
			this.biletİptaliToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletİptaliToolStripMenuItem.Image")));
			this.biletİptaliToolStripMenuItem.Name = "biletİptaliToolStripMenuItem";
			this.biletİptaliToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.biletİptaliToolStripMenuItem.Text = "Bilet İptali";
			this.biletİptaliToolStripMenuItem.Click += new System.EventHandler(this.biletİptaliToolStripMenuItem_Click);
			// 
			// biletSorgulaToolStripMenuItem
			// 
			this.biletSorgulaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletSorgulaToolStripMenuItem.Image")));
			this.biletSorgulaToolStripMenuItem.Name = "biletSorgulaToolStripMenuItem";
			this.biletSorgulaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.biletSorgulaToolStripMenuItem.Text = "Bilet Sorgula";
			this.biletSorgulaToolStripMenuItem.Click += new System.EventHandler(this.biletSorgulaToolStripMenuItem_Click);
			// 
			// özelİşlemlerToolStripMenuItem
			// 
			this.özelİşlemlerToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
			this.özelİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem});
			this.özelİşlemlerToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.özelİşlemlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("özelİşlemlerToolStripMenuItem.Image")));
			this.özelİşlemlerToolStripMenuItem.Name = "özelİşlemlerToolStripMenuItem";
			this.özelİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.özelİşlemlerToolStripMenuItem.Text = "Kullanıcı İşlemleri";
			// 
			// şifreDeğiştirToolStripMenuItem
			// 
			this.şifreDeğiştirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreDeğiştirToolStripMenuItem.Image")));
			this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
			this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
			this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
			// 
			// çıkışToolStripMenuItem
			// 
			this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
			this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F);
			this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
			this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
			this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.çıkışToolStripMenuItem.Text = "Çıkış";
			this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SandyBrown;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
			this.label1.Location = new System.Drawing.Point(864, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.SandyBrown;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
			this.label2.Location = new System.Drawing.Point(1034, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tarih : ";
			// 
			// GorevliIslemleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1217, 591);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GorevliIslemleri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GorevliIslemleri";
			this.Load += new System.EventHandler(this.GorevliIslemleri_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yeniBiletToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem biletİptaliToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem biletSorgulaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem özelİşlemlerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}