﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Timing_Meter
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btnHesapla_Click(object sender, EventArgs e)
		{
			try
			{
				// Kullanıcının girdiği değerleri al
				double internetHızı = double.Parse(txtHız.Text); // Mbps cinsinden
				double dosyaBoyutu = double.Parse(txtDosyaBoyutu.Text); // GB cinsinden

				// İndirme süresini hesapla (saniye cinsinden)
				double estimatedTimeInSeconds = (dosyaBoyutu * 1024) / (internetHızı / 8);
				double estimatedTimeInMinutes = estimatedTimeInSeconds / 60;

				lblSonuç.Text = $"Tahmini İndirme Süresi: {estimatedTimeInMinutes:0.##} dakika";
			}
			catch
			{
				lblSonuç.Text = "Lütfen geçerli bir değer girin!";
			}
		}
	}
}
