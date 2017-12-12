namespace ResizeImages
{
	partial class MainForm
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		    {
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaImages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryImagesSource = new System.Windows.Forms.TextBox();
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBVerImage = new System.Windows.Forms.CheckBox();
            this.pixel = new System.Windows.Forms.Label();
            this.txt_ImageLoadHeight = new System.Windows.Forms.TextBox();
            this.txt_ImageLoadWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DirectoryImagesDestiny = new System.Windows.Forms.TextBox();
            this.btnDirDestiny = new System.Windows.Forms.Button();
            this.gprNuevasDimensiones = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB_ImgNewHeight = new System.Windows.Forms.TextBox();
            this.txtB_ImgNewWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtB_ImgThumbHeigth = new System.Windows.Forms.TextBox();
            this.txtB_ImgThumbWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtB_NombreImagen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDirSource = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtB_MarcaAgua = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gprNuevasDimensiones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.directorioToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            this.archivoToolStripMenuItem1.Click += new System.EventHandler(this.archivoToolStripMenuItem1_Click);
            // 
            // directorioToolStripMenuItem
            // 
            this.directorioToolStripMenuItem.Name = "directorioToolStripMenuItem";
            this.directorioToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.directorioToolStripMenuItem.Text = "Directorio";
            this.directorioToolStripMenuItem.Click += new System.EventHandler(this.directorioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propiedadesToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            this.propiedadesToolStripMenuItem.Click += new System.EventHandler(this.propiedadesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // listaImages
            // 
            this.listaImages.FormattingEnabled = true;
            this.listaImages.HorizontalScrollbar = true;
            this.listaImages.ItemHeight = 16;
            this.listaImages.Location = new System.Drawing.Point(16, 138);
            this.listaImages.Margin = new System.Windows.Forms.Padding(4);
            this.listaImages.Name = "listaImages";
            this.listaImages.Size = new System.Drawing.Size(300, 500);
            this.listaImages.TabIndex = 3;
            this.listaImages.SelectedIndexChanged += new System.EventHandler(this.listaImages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directorio Fuente : ";
            // 
            // DirectoryImagesSource
            // 
            this.DirectoryImagesSource.Location = new System.Drawing.Point(153, 54);
            this.DirectoryImagesSource.Margin = new System.Windows.Forms.Padding(4);
            this.DirectoryImagesSource.Name = "DirectoryImagesSource";
            this.DirectoryImagesSource.Size = new System.Drawing.Size(653, 22);
            this.DirectoryImagesSource.TabIndex = 5;
            this.DirectoryImagesSource.DoubleClick += new System.EventHandler(this.btnDirSource_Click);
            this.DirectoryImagesSource.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DirectoryImagesSource_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBVerImage);
            this.groupBox1.Controls.Add(this.pixel);
            this.groupBox1.Controls.Add(this.txt_ImageLoadHeight);
            this.groupBox1.Controls.Add(this.txt_ImageLoadWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(340, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(190, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensiones Actuales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "px";
            // 
            // cBVerImage
            // 
            this.cBVerImage.AutoSize = true;
            this.cBVerImage.Location = new System.Drawing.Point(13, 95);
            this.cBVerImage.Margin = new System.Windows.Forms.Padding(4);
            this.cBVerImage.Name = "cBVerImage";
            this.cBVerImage.Size = new System.Drawing.Size(127, 21);
            this.cBVerImage.TabIndex = 14;
            this.cBVerImage.Text = "Visor Imagenes";
            this.cBVerImage.UseVisualStyleBackColor = true;
            this.cBVerImage.CheckedChanged += new System.EventHandler(this.cBVerImage_CheckedChanged);
            // 
            // pixel
            // 
            this.pixel.AutoSize = true;
            this.pixel.Location = new System.Drawing.Point(136, 62);
            this.pixel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pixel.Name = "pixel";
            this.pixel.Size = new System.Drawing.Size(22, 17);
            this.pixel.TabIndex = 4;
            this.pixel.Text = "px";
            // 
            // txt_ImageLoadHeight
            // 
            this.txt_ImageLoadHeight.Location = new System.Drawing.Point(75, 59);
            this.txt_ImageLoadHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ImageLoadHeight.Name = "txt_ImageLoadHeight";
            this.txt_ImageLoadHeight.ReadOnly = true;
            this.txt_ImageLoadHeight.Size = new System.Drawing.Size(57, 22);
            this.txt_ImageLoadHeight.TabIndex = 3;
            // 
            // txt_ImageLoadWidth
            // 
            this.txt_ImageLoadWidth.Location = new System.Drawing.Point(75, 27);
            this.txt_ImageLoadWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ImageLoadWidth.Name = "txt_ImageLoadWidth";
            this.txt_ImageLoadWidth.ReadOnly = true;
            this.txt_ImageLoadWidth.Size = new System.Drawing.Size(57, 22);
            this.txt_ImageLoadWidth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Width (x) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height (y) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Directorio Destino: ";
            // 
            // DirectoryImagesDestiny
            // 
            this.DirectoryImagesDestiny.Location = new System.Drawing.Point(155, 92);
            this.DirectoryImagesDestiny.Margin = new System.Windows.Forms.Padding(4);
            this.DirectoryImagesDestiny.Name = "DirectoryImagesDestiny";
            this.DirectoryImagesDestiny.Size = new System.Drawing.Size(652, 22);
            this.DirectoryImagesDestiny.TabIndex = 10;
            this.DirectoryImagesDestiny.DoubleClick += new System.EventHandler(this.btnDirDestiny_Click);
            // 
            // btnDirDestiny
            // 
            this.btnDirDestiny.Location = new System.Drawing.Point(821, 94);
            this.btnDirDestiny.Margin = new System.Windows.Forms.Padding(4);
            this.btnDirDestiny.Name = "btnDirDestiny";
            this.btnDirDestiny.Size = new System.Drawing.Size(100, 28);
            this.btnDirDestiny.TabIndex = 11;
            this.btnDirDestiny.Text = "Seleccionar";
            this.btnDirDestiny.UseVisualStyleBackColor = true;
            this.btnDirDestiny.Click += new System.EventHandler(this.btnDirDestiny_Click);
            // 
            // gprNuevasDimensiones
            // 
            this.gprNuevasDimensiones.Controls.Add(this.label6);
            this.gprNuevasDimensiones.Controls.Add(this.label7);
            this.gprNuevasDimensiones.Controls.Add(this.txtB_ImgNewHeight);
            this.gprNuevasDimensiones.Controls.Add(this.txtB_ImgNewWidth);
            this.gprNuevasDimensiones.Controls.Add(this.label8);
            this.gprNuevasDimensiones.Controls.Add(this.label9);
            this.gprNuevasDimensiones.Location = new System.Drawing.Point(553, 210);
            this.gprNuevasDimensiones.Margin = new System.Windows.Forms.Padding(4);
            this.gprNuevasDimensiones.Name = "gprNuevasDimensiones";
            this.gprNuevasDimensiones.Padding = new System.Windows.Forms.Padding(4);
            this.gprNuevasDimensiones.Size = new System.Drawing.Size(190, 150);
            this.gprNuevasDimensiones.TabIndex = 15;
            this.gprNuevasDimensiones.TabStop = false;
            this.gprNuevasDimensiones.Text = "Nuevas Dimensiones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "px";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "px";
            // 
            // txtB_ImgNewHeight
            // 
            this.txtB_ImgNewHeight.Location = new System.Drawing.Point(81, 65);
            this.txtB_ImgNewHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_ImgNewHeight.Name = "txtB_ImgNewHeight";
            this.txtB_ImgNewHeight.Size = new System.Drawing.Size(57, 22);
            this.txtB_ImgNewHeight.TabIndex = 9;
            // 
            // txtB_ImgNewWidth
            // 
            this.txtB_ImgNewWidth.Location = new System.Drawing.Point(81, 33);
            this.txtB_ImgNewWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_ImgNewWidth.Name = "txtB_ImgNewWidth";
            this.txtB_ImgNewWidth.Size = new System.Drawing.Size(57, 22);
            this.txtB_ImgNewWidth.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Width (x) : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Height (y) : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtB_ImgThumbHeigth);
            this.groupBox2.Controls.Add(this.txtB_ImgThumbWidth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(759, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 150);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thumb Dimensiones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "px";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "px";
            // 
            // txtB_ImgThumbHeigth
            // 
            this.txtB_ImgThumbHeigth.Location = new System.Drawing.Point(88, 66);
            this.txtB_ImgThumbHeigth.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_ImgThumbHeigth.Name = "txtB_ImgThumbHeigth";
            this.txtB_ImgThumbHeigth.Size = new System.Drawing.Size(57, 22);
            this.txtB_ImgThumbHeigth.TabIndex = 17;
            // 
            // txtB_ImgThumbWidth
            // 
            this.txtB_ImgThumbWidth.Location = new System.Drawing.Point(88, 34);
            this.txtB_ImgThumbWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_ImgThumbWidth.Name = "txtB_ImgThumbWidth";
            this.txtB_ImgThumbWidth.Size = new System.Drawing.Size(57, 22);
            this.txtB_ImgThumbWidth.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Width (x) : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Height (y) : ";
            // 
            // txtB_NombreImagen
            // 
            this.txtB_NombreImagen.Location = new System.Drawing.Point(499, 138);
            this.txtB_NombreImagen.Name = "txtB_NombreImagen";
            this.txtB_NombreImagen.Size = new System.Drawing.Size(346, 22);
            this.txtB_NombreImagen.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Nombre Imagen: ";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(760, 583);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(189, 55);
            this.btnProcesar.TabIndex = 19;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(343, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 256);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnDirSource
            // 
            this.btnDirSource.Location = new System.Drawing.Point(821, 54);
            this.btnDirSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnDirSource.Name = "btnDirSource";
            this.btnDirSource.Size = new System.Drawing.Size(100, 28);
            this.btnDirSource.TabIndex = 12;
            this.btnDirSource.Text = "Seleccionar";
            this.btnDirSource.UseVisualStyleBackColor = true;
            this.btnDirSource.Click += new System.EventHandler(this.btnDirSource_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Texto Marca de Agua:";
            // 
            // txtB_MarcaAgua
            // 
            this.txtB_MarcaAgua.Location = new System.Drawing.Point(499, 171);
            this.txtB_MarcaAgua.Name = "txtB_MarcaAgua";
            this.txtB_MarcaAgua.Size = new System.Drawing.Size(346, 22);
            this.txtB_MarcaAgua.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 692);
            this.Controls.Add(this.txtB_MarcaAgua);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtB_NombreImagen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gprNuevasDimensiones);
            this.Controls.Add(this.btnDirSource);
            this.Controls.Add(this.btnDirDestiny);
            this.Controls.Add(this.DirectoryImagesDestiny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DirectoryImagesSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaImages);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Resize Image(s)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gprNuevasDimensiones.ResumeLayout(false);
            this.gprNuevasDimensiones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
		private System.Windows.Forms.ListBox listaImages;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox DirectoryImagesSource;
		private System.Windows.Forms.FolderBrowserDialog fBD;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_ImageLoadHeight;
		private System.Windows.Forms.TextBox txt_ImageLoadWidth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label pixel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox DirectoryImagesDestiny;
		private System.Windows.Forms.Button btnDirDestiny;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.CheckBox cBVerImage;
		private System.Windows.Forms.GroupBox gprNuevasDimensiones;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtB_ImgNewHeight;
		private System.Windows.Forms.TextBox txtB_ImgNewWidth;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtB_ImgThumbHeigth;
        private System.Windows.Forms.TextBox txtB_ImgThumbWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtB_NombreImagen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDirSource;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtB_MarcaAgua;
    }
}

