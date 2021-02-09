using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_4._4._4_UDatenfeldEindimensional
{
	public partial class Form1 : Form
	{
		// Zufallszahlengenerator
		private readonly Random r = new Random();
		public Form1()
		{
			InitializeComponent();
		}

		private void btnMinima_Click(object sender, EventArgs e)
		{
			// Datenfeld und Variable für Minimalwert deklarieren
			int[] a = new int[10];
			int minimum;

			lstAnzeige.Items.Clear();

			// Zufallswerte in Datenfeld eintragen und in ListBox anzeigen
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(20, 31);
				lstAnzeige.Items.Add(a[i]);
			}

			// Minimum bestimmen
			minimum = a.Min();
			lblAusgabe.Text = "Minimum: " + minimum;

			// Vorkommen des Minimums finden und anzeigen
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == minimum) lblAusgabe.Text += "\nan Position: " + i;
			}

		}
	}
}
