namespace Download_Timing_Meter
{
	partial class Main
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtHız = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDosyaBoyutu = new System.Windows.Forms.TextBox();
			this.btnHesapla = new System.Windows.Forms.Button();
			this.lblSonuç = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "İnternet Hızınızı Girin (Mbps):";
			// 
			// txtHız
			// 
			this.txtHız.Location = new System.Drawing.Point(170, 42);
			this.txtHız.Name = "txtHız";
			this.txtHız.Size = new System.Drawing.Size(100, 20);
			this.txtHız.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "İndirilecek Dosya Boyutu (GB):";
			// 
			// txtDosyaBoyutu
			// 
			this.txtDosyaBoyutu.Location = new System.Drawing.Point(170, 96);
			this.txtDosyaBoyutu.Name = "txtDosyaBoyutu";
			this.txtDosyaBoyutu.Size = new System.Drawing.Size(100, 20);
			this.txtDosyaBoyutu.TabIndex = 2;
			// 
			// btnHesapla
			// 
			this.btnHesapla.Location = new System.Drawing.Point(170, 150);
			this.btnHesapla.Name = "btnHesapla";
			this.btnHesapla.Size = new System.Drawing.Size(75, 23);
			this.btnHesapla.TabIndex = 3;
			this.btnHesapla.Text = "Hesapla";
			this.btnHesapla.UseVisualStyleBackColor = true;
			this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
			// 
			// lblSonuç
			// 
			this.lblSonuç.AutoSize = true;
			this.lblSonuç.Location = new System.Drawing.Point(163, 191);
			this.lblSonuç.Name = "lblSonuç";
			this.lblSonuç.Size = new System.Drawing.Size(0, 13);
			this.lblSonuç.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 258);
			this.Controls.Add(this.btnHesapla);
			this.Controls.Add(this.txtDosyaBoyutu);
			this.Controls.Add(this.lblSonuç);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHız);
			this.Controls.Add(this.label1);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İndirme Zaman Ölçer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHız;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDosyaBoyutu;
		private System.Windows.Forms.Button btnHesapla;
		private System.Windows.Forms.Label lblSonuç;
	}
}

