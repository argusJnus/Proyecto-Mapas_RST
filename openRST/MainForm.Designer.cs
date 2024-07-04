/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 13/05/2024
 * Time: 02:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace openRST
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOpen = new System.Windows.Forms.Button();
			this.mapa = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtResumen = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblArray = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.X = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRows = new System.Windows.Forms.Label();
			this.lblCols = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.mapa)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(384, 25);
			this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(115, 57);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Abrir Mapa";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.Button1Click);
			// 
			// mapa
			// 
			this.mapa.Location = new System.Drawing.Point(317, 96);
			this.mapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.mapa.Name = "mapa";
			this.mapa.Size = new System.Drawing.Size(971, 513);
			this.mapa.TabIndex = 1;
			this.mapa.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtResumen);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lblArray);
			this.panel1.Controls.Add(this.lblResultado);
			this.panel1.Controls.Add(this.btnCalcular);
			this.panel1.Controls.Add(this.txtRadio);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.X);
			this.panel1.Controls.Add(this.txtY);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtX);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Enabled = false;
			this.panel1.Location = new System.Drawing.Point(12, 96);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(285, 595);
			this.panel1.TabIndex = 2;
			// 
			// txtResumen
			// 
			this.txtResumen.Location = new System.Drawing.Point(3, 459);
			this.txtResumen.Multiline = true;
			this.txtResumen.Name = "txtResumen";
			this.txtResumen.ReadOnly = true;
			this.txtResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResumen.Size = new System.Drawing.Size(279, 120);
			this.txtResumen.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 423);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "Resumen radiométrico:";
			// 
			// lblArray
			// 
			this.lblArray.Location = new System.Drawing.Point(13, 242);
			this.lblArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblArray.Multiline = true;
			this.lblArray.Name = "lblArray";
			this.lblArray.ReadOnly = true;
			this.lblArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.lblArray.Size = new System.Drawing.Size(249, 157);
			this.lblArray.TabIndex = 12;
			this.lblArray.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(91, 217);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(62, 17);
			this.lblResultado.TabIndex = 9;
			this.lblResultado.Text = "Vecinos:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(91, 176);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtRadio
			// 
			this.txtRadio.Location = new System.Drawing.Point(75, 128);
			this.txtRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(139, 22);
			this.txtRadio.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Radio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(155, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Y";
			// 
			// X
			// 
			this.X.Location = new System.Drawing.Point(75, 81);
			this.X.Name = "X";
			this.X.Size = new System.Drawing.Size(35, 23);
			this.X.TabIndex = 4;
			this.X.Text = "X";
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(155, 57);
			this.txtY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(59, 22);
			this.txtY.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Celda";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(75, 57);
			this.txtX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(59, 22);
			this.txtX.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(75, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calcular vecinos";
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Location = new System.Drawing.Point(25, 36);
			this.lblRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(45, 17);
			this.lblRows.TabIndex = 3;
			this.lblRows.Text = "Filas: ";
			// 
			// lblCols
			// 
			this.lblCols.AutoSize = true;
			this.lblCols.Location = new System.Drawing.Point(25, 62);
			this.lblCols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCols.Name = "lblCols";
			this.lblCols.Size = new System.Drawing.Size(74, 17);
			this.lblCols.TabIndex = 4;
			this.lblCols.Text = "Columnas:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(858, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(272, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Tovar Lizárraga Jesús Santiago || LISI 4-1";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(516, 45);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(0, 17);
			this.lblName.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1300, 752);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblCols);
			this.Controls.Add(this.lblRows);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.mapa);
			this.Controls.Add(this.btnOpen);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Sistema Final - Tovar Lizárraga";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.mapa)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtResumen;
		private System.Windows.Forms.Label lblCols;
		private System.Windows.Forms.Label lblRows;
		private System.Windows.Forms.TextBox lblArray;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.Label X;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox mapa;
		private System.Windows.Forms.Button btnOpen;
		
		void LblArrayClick(object sender, System.EventArgs e)
		{
			
		}
	}
}
