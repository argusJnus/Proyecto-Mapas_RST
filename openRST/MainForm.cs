/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 13/05/2024
 * Time: 02:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace openRST
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Arreglo para conteo de la cantidad de celdas que son de tal categoría o leyenda	
		private int[] categorias;
		
		//Arreglo de string para almacenar los nombres de las leyendas 
		private string[] leyendas;
		
		
		private int numeroLeyendas;
		private int valorMax;
		
		
		private int columns = 0;
		private int rows = 0;
		private string type = "";
		private int[,] matriz;
		
		private Color[] colores = new Color[]{
				Color.Black,
				Color.Red,
				Color.Green,
				Color.Orange,
				Color.Yellow,
				Color.Turquoise,
				Color.Blue,
				Color.Beige,
				Color.Crimson,
				Color.DarkGray,
				Color.DarkOrange,
				Color.Olive,
				Color.NavajoWhite,
				Color.MediumSeaGreen,
				Color.LightSkyBlue,
				Color.LemonChiffon,
				Color.Goldenrod,
				Color.DarkViolet,
				Color.DeepPink,
				Color.Fuchsia,
				Color.AliceBlue,
			    Color.AntiqueWhite,
			    Color.Aqua,
			    Color.Aquamarine,
			    Color.Azure,
			    Color.Bisque,
			    Color.BlanchedAlmond,
			    Color.BlueViolet,
			    Color.Brown,
			    Color.BurlyWood,
			    Color.CadetBlue,
			    Color.Chartreuse,
			    Color.Chocolate,
			    Color.Coral,
			    Color.CornflowerBlue,
			    Color.Cornsilk,
			    Color.Cyan,
			    Color.DarkBlue,
			    Color.DarkCyan,
			    Color.DarkGoldenrod,
			    Color.DarkGreen,
			    Color.DarkKhaki,
			    Color.DarkMagenta,
			    Color.DarkOliveGreen,
			    Color.DarkOrchid,
			    Color.DarkRed,
			    Color.DarkSalmon,
			    Color.DarkSeaGreen,
			    Color.DarkSlateBlue,
			    Color.DarkSlateGray,
			    Color.DarkTurquoise,
			    Color.DeepSkyBlue,
			    Color.DimGray,
			    Color.DodgerBlue,
			    Color.Firebrick,
			    Color.FloralWhite,
			    Color.ForestGreen,
			    Color.Gainsboro,
			    Color.GhostWhite,
			    Color.Gold,
			    Color.Gray,
			    Color.GreenYellow,
			    Color.Honeydew,
			    Color.HotPink,
			    Color.IndianRed,
			    Color.Indigo,
			    Color.Ivory,
			    Color.Khaki,
			    Color.Lavender,
			    Color.LavenderBlush,
			    Color.LawnGreen,
			    Color.LightBlue,
			    Color.LightCoral,
			    Color.LightCyan,
			    Color.LightGoldenrodYellow,
			    Color.LightGray,
			    Color.LightGreen,
			    Color.LightPink,
			    Color.LightSalmon,
			    Color.LightSeaGreen,
			    Color.LightSlateGray,
			    Color.LightSteelBlue,
			    Color.LightYellow,
			    Color.Lime,
			    Color.LimeGreen,
			    Color.Linen,
			    Color.Magenta,
			    Color.Maroon,
			    Color.MediumAquamarine,
			    Color.MediumBlue,
			    Color.MediumOrchid,
			    Color.MediumPurple,
			    Color.MediumSlateBlue,
			    Color.MediumSpringGreen,
			    Color.MediumTurquoise,
			    Color.MediumVioletRed,
			    Color.MidnightBlue,
			    Color.MintCream,
			    Color.MistyRose,
			    Color.Moccasin,
			    Color.Navy,
			    Color.OldLace,
			    Color.OliveDrab,
			    Color.OrangeRed,
			    Color.Orchid,
			    Color.PaleGoldenrod,
			    Color.PaleGreen,
			    Color.PaleTurquoise,
			    Color.PaleVioletRed,
			    Color.PapayaWhip,
			    Color.PeachPuff,
			    Color.Peru,
			    Color.Pink,
			    Color.Plum,
			    Color.PowderBlue,
			    Color.Purple,
			    Color.RosyBrown,
			    Color.RoyalBlue,
			    Color.SaddleBrown,
			    Color.Salmon,
			    Color.SandyBrown,
			    Color.SeaGreen,
			    Color.SeaShell,
			    Color.Sienna,
			    Color.Silver,
			    Color.SkyBlue,
			    Color.SlateBlue,
			    Color.SlateGray,
			    Color.Snow,
			    Color.SpringGreen,
			    Color.SteelBlue,
			    Color.Tan,
			    Color.Teal,
			    Color.Thistle,
			    Color.Tomato,
			    Color.Violet,
			    Color.Wheat,
			    Color.White,
			    Color.WhiteSmoke,
			    Color.YellowGreen
		};
		private TrackBar trackBarZoom = new TrackBar();
		
		//Función de zoom
		private void trackBarZoom_Scroll(object sender, EventArgs e) {
		    TrackBar trackBar = sender as TrackBar;
		    float zoomFactor = trackBar.Value;
		    drawRaster(this.matriz, zoomFactor);
		}
		
		//Inicializar trackBar
		private void initTrack(){
	        trackBarZoom.Minimum = 1;
	        trackBarZoom.Maximum = 5;
	        trackBarZoom.Value = 1;
	        trackBarZoom.TickFrequency = 1;
	        trackBarZoom.Dock = DockStyle.Bottom;
	        trackBarZoom.Scroll += new EventHandler(trackBarZoom_Scroll);
	        this.Controls.Add(trackBarZoom);
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			initTrack();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		//Abrir mapa
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Archivos rst (*.rst*)|*.rst*"; 
            openFileDialog.FilterIndex = 1; 
            openFileDialog.RestoreDirectory = true; 

           
            if (openFileDialog.ShowDialog() == DialogResult.OK){
            	
                try{
                   
                    byte[] contenidoArchivo = File.ReadAllBytes(openFileDialog.FileName);
                    lblName.Text = Path.GetFileName(openFileDialog.FileName);
                    string archivoRDC = Path.ChangeExtension(openFileDialog.FileName, ".RDC");
                    
                    if (File.Exists(archivoRDC)){
                    	
                        	string[] contenidoRDC = File.ReadAllLines(archivoRDC);
                        	
                        	//Tipo de archivo
                        	string[] type = contenidoRDC[2].Split(':');
                        	this.type = type[1].Trim();
                        	
                        	if(this.type != "real"){
                        		
                        		//Num Columnas
	                        	string[] columns = contenidoRDC[4].Split(':');
	                        	this.columns = int.Parse(columns[1].Trim());
	                        	
	                        	//Num de Filas
	                        	string[] rows = contenidoRDC[5].Split(':');
	                        	this.rows = int.Parse(rows[1].Trim());
	                        	
	                        	//Valor máximo dentro del mapa
	                        	string[] maxValue = contenidoRDC[16].Split(':');
	                        	this.valorMax = int.Parse(maxValue[1].Trim());
	                        	
	                        	//Numero de leyendas que hay
	                        	string[] numLeg = contenidoRDC[23].Split(':');
	                        	this.numeroLeyendas = int.Parse(numLeg[1].Trim());
	                        	
	                        	
	                        	if(this.numeroLeyendas > 0){
	                        		//Se inicializa el arreglo de los nombres
	                        		this.leyendas = new string[this.numeroLeyendas+1];
	                        		this.leyendas[0] = "Vacio";
	                        		
	                        		//A partir de la linea 24 del archivo RDC vienen los nombres de las leyendas
	                        		int lineArchivo = 24;
	                        		for(int i = 1; i<this.numeroLeyendas+1;i++){
	                        			
	                        			//Se extrae el nombre de la leyenda
	                        			string[] leg = contenidoRDC[lineArchivo].Split(':');
	                        			this.leyendas[i] = leg[1].Trim();
	                        			
	                        			lineArchivo++;
	                        		}
	                        	}else{
	                        		//Si no hay leyendas, se usa el max value que viene en el RDC
	                        		this.leyendas = new string[this.valorMax+1];
	                        		this.numeroLeyendas = this.valorMax;
	                        		for(int i = 0; i<this.valorMax+1;i++){
	                        			
	                        			this.leyendas[i] = i.ToString();
	                        			
	                        		}
	                        	}
	                        	
	                        	lblCols.Text = "Columnas: "+this.columns.ToString();
	                        	lblRows.Text = "Filas: "+this.rows.ToString();
	                        	
	                        	
	                        	//Dibujado del mapa
	                        	if(this.type == "byte"){
	                        		
	                        		float initialZoomFactor = 1.0f;
	                        		this.matriz = binarytoDecimal(contenidoArchivo);
	                        		drawRaster(this.matriz, initialZoomFactor);
	                        		trackBarZoom.Value = 1;
	                        		
	                        	}else if (this.type == "integer"){
	                        		
	                        		this.matriz = binarytoDecimalInt(contenidoArchivo);
	                        		float initialZoomFactor = 1.0f;
	                        		drawRaster(this.matriz, initialZoomFactor);
	                        		trackBarZoom.Value = 1;
	                        		
	                        	}
	                        	//Sección de vecinos activada
	                        	panel1.Enabled = true;
                        	}else{
                        		MessageBox.Show("Elija un archivo de tipo de integer o byte");
                        	}
                        	
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
		}
		
		//Leer bytes y pasarlos a decimal
		public int[,] binarytoDecimal(byte[] raster){
			int [,] matrizDecimal = new int[this.rows, this.columns];
			int aux = 0;
			for(int i = 0;i< this.rows;i++){
				for(int j = 0; j < this.columns; j++){
					if(aux < raster.Length){
						matrizDecimal[i,j] = int.Parse(raster[aux].ToString());
						aux++;
					}else{
						matrizDecimal[i,j] = 0;
					}
				}
			}
			return matrizDecimal;
		}
		
		//Leer integers y pasarlos a decimal
		public int[,] binarytoDecimalInt(byte[] raster){
			int [,] matrizDecimal = new int[this.rows, this.columns];
			int aux = 0;
			for(int i = 0;i< this.rows;i++){
				for(int j = 0; j < this.columns; j++){
					if (aux + 1 < raster.Length){
						
		                int valorDecimal = BitConverter.ToInt16(raster, aux);
		                
		                matrizDecimal[i, j] = valorDecimal;
		                aux += 2;
		            }else{
						matrizDecimal[i,j] = 0;
					}
				}
			}
			return matrizDecimal;
		}
		
		//Dibujar mapa
		private void drawRaster(int[,] matrizDecimales, float zoomFactor) {
		    
			txtResumen.Text = "";
		    lblArray.Text = "";
		    lblResultado.Text = "Vecinos: ";
		    int rows = this.rows;
		    int columns = this.columns;
		
		    //Crear Bitmap original
		    Bitmap originalBitmap = new Bitmap(columns, rows);
		    for (int i = 0; i < rows; i++) {
		        for (int j = 0; j < columns; j++) {
		            Color pixel = this.colores[matrizDecimales[i, j]];
		            originalBitmap.SetPixel(j, i, pixel);
		        }
		    }
		
		    //Calcular el tamaño del Bitmap con zoom
		    int zoomedWidth = (int)(columns * zoomFactor);
		    int zoomedHeight = (int)(rows * zoomFactor);
		
		    //Crear el Bitmap con zoom
		    Bitmap zoomedBitmap = new Bitmap(zoomedWidth, zoomedHeight);
		    using (Graphics g = Graphics.FromImage(zoomedBitmap)) {
		    	
		        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
		        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
		        g.DrawImage(originalBitmap, new Rectangle(0, 0, zoomedWidth, zoomedHeight));
		        
		    }
		
		    //Tamaño del pictureBox
		    mapa.Size = new Size(zoomedWidth, zoomedHeight);
		    mapa.Image = zoomedBitmap;
		    this.mapa.MouseClick -= new MouseEventHandler(mapa_MouseClick);
			this.mapa.MouseClick += new MouseEventHandler(mapa_MouseClick);

		}

		//Función que calcula los vecinos
		void calcularVecinos(int[,] matriz, int radio, int posX, int posY){
		    txtResumen.Text = "";
		    lblArray.Text = "";
		
		    this.categorias = new int[this.valorMax + 1];
		
		    if (posY >= this.rows || posX >= this.columns)
		    {
		        MessageBox.Show("Celda fuera de rango", "Error", MessageBoxButtons.OK);
		        return;
		    }
		
		    StringBuilder vecinos = new StringBuilder();
		    StringBuilder res = new StringBuilder();
		    int limIzq = Math.Max(posX - radio, 0);
		    int limDer = Math.Min(posX + radio, this.columns - 1);
		    int limUp = Math.Max(posY - radio, 0);
		    int limDown = Math.Min(posY + radio, this.rows - 1);
		    int contador = 0;
		
		    //Recorrer la submatriz
		    for (int i = limUp; i <= limDown; i++)
		    {
		        for (int j = limIzq; j <= limDer; j++)
		        {
		            contador++;
		            if (!(i == posY && j == posX))
		            {
		                //Almacenar vecinos
		                vecinos.AppendFormat("[{0},{1}], ", j, i);
		
		                //Conteo de categorías
		                this.categorias[matriz[i, j]]++;
		            }
		        }
		        vecinos.AppendLine();
		    }
		
		    //Realizar la lista de vecinos y el resumen
		    lblArray.Text = vecinos.ToString();
		    lblResultado.Text = "Vecinos: " + (contador - 1).ToString();
		    txtResumen.Text = "Los vecinos alrededor del punto son:" + Environment.NewLine;
		
		    for (int it = 0; it <= this.numeroLeyendas; it++)
		    {
		        if (this.categorias[it] > 0)
		        {
		        	res.AppendFormat("{0} pertenecientes a {1}\n", this.categorias[it].ToString(), this.leyendas[it]);
		        	res.AppendLine();
		        }
		    }
		    txtResumen.Text = res.ToString();
		}

		
		
		//Cálculo de vecinos
		void BtnCalcularClick(object sender, EventArgs e){
			
	    	if (!string.IsNullOrEmpty(txtX.Text) && !string.IsNullOrEmpty(txtY.Text) && !string.IsNullOrEmpty(txtRadio.Text)){
		        
				try{
					
		            int x = int.Parse(txtX.Text);
		            int y = int.Parse(txtY.Text);
		            int radio = int.Parse(txtRadio.Text);
		            
		            calcularVecinos(this.matriz, radio, x, y);
		        }
		        catch (FormatException){
					
		            MessageBox.Show("Todos los valores tienen que ser números enteros.");
		        }
		    }else{
				
		        MessageBox.Show("Llene todos los campos antes de calcular.");
		    }
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		//Hacer clic dentro del mapa para obtener coordenadas
		private void mapa_MouseClick(object sender, MouseEventArgs e){
			
		    //Coordenadas del clic en el mapa
		    int mouseX = e.X;
		    int mouseY = e.Y;
		
		    //Obtener el factor de zoom actual desde el TrackBar
		    float zoomFactor = trackBarZoom.Value;
		
		    //Convertir las coordenadas de clic al sistema de coordenadas original del mapa
		    int originalX = (int)(mouseX / zoomFactor);
		    int originalY = (int)(mouseY / zoomFactor);
		
		    //Validar que las coordenadas están dentro del rango válido
		    if (originalX >= 0 && originalX < columns && originalY >= 0 && originalY < rows){
		        txtX.Text = originalX.ToString();
		        txtY.Text = originalY.ToString();
		    }
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
	}
}
