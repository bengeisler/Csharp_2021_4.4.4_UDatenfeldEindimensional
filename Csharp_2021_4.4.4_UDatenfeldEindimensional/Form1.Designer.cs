
namespace Csharp_2021_4._4._4_UDatenfeldEindimensional
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
			this.lstAnzeige = new System.Windows.Forms.ListBox();
			this.btnMinima = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstAnzeige
			// 
			this.lstAnzeige.FormattingEnabled = true;
			this.lstAnzeige.Location = new System.Drawing.Point(13, 13);
			this.lstAnzeige.Name = "lstAnzeige";
			this.lstAnzeige.Size = new System.Drawing.Size(101, 225);
			this.lstAnzeige.TabIndex = 0;
			// 
			// btnMinima
			// 
			this.btnMinima.Location = new System.Drawing.Point(137, 13);
			this.btnMinima.Name = "btnMinima";
			this.btnMinima.Size = new System.Drawing.Size(75, 23);
			this.btnMinima.TabIndex = 1;
			this.btnMinima.Text = "Minima";
			this.btnMinima.UseVisualStyleBackColor = true;
			this.btnMinima.Click += new System.EventHandler(this.btnMinima_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(137, 63);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 2;
			this.lblAusgabe.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 253);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnMinima);
			this.Controls.Add(this.lstAnzeige);
			this.Name = "Form1";
			this.Text = "Datenfeld, eindimensional";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstAnzeige;
		private System.Windows.Forms.Button btnMinima;
		private System.Windows.Forms.Label lblAusgabe;
	}
}

