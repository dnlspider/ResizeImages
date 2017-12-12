using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResizeImages
{
    public partial class MainForm : Form
    {

        #region selectDirectorySource
        private void selectDirectorySource()
        {
            string strFileName = string.Empty;

            clearFields();

            if (String.IsNullOrEmpty(DirectoryImagesSource.Text))
            {
                DialogResult result = fBD.ShowDialog();
                fBD.RootFolder = Environment.SpecialFolder.Desktop;


                if (!String.IsNullOrEmpty(fBD.SelectedPath))
                {
                    obtieneArchivos(fBD.SelectedPath);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado directorio alguno.");
                    return;
                }
            }
            else
            {
                if (DirectoryImagesSource.Text.Contains(":/") || DirectoryImagesSource.Text.Contains(":\\"))
                {
                    obtieneArchivos(DirectoryImagesSource.Text);
                }
                else
                {
                    MessageBox.Show("La ruta ingresada no es valida", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion//selectDirectorySource

        #region selectDirectoryDest
        private void selectDirectoryDest()
        {
            if (string.IsNullOrEmpty(DirectoryImagesSource.Text))
            {
                DialogResult result = fBD.ShowDialog();
                fBD.RootFolder = Environment.SpecialFolder.Desktop;

                if (!String.IsNullOrEmpty(fBD.SelectedPath))
                {
                    DirectoryImagesDestiny.Text = Path.GetFullPath(fBD.SelectedPath);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado directorio alguno.");
                }
            }
            else
            {

            }
        }
        #endregion//selectDirectoryDest

        #region clearFields
        private void clearFields()
        {
            listaImages.Items.Clear();
            DirectoryImagesSource.Text = "";
        }
        #endregion//clearFields

        #region obtieneArchivos
        private void obtieneArchivos(string strPathFiles)
        {
            string strFileName = string.Empty;

            string[] files = Directory.GetFiles(strPathFiles);

            DirectoryImagesSource.Text = Path.GetFullPath(strPathFiles);

            if (String.IsNullOrEmpty(DirectoryImagesDestiny.Text))
            {
                DirectoryImagesDestiny.Text = DirectoryImagesSource.Text;
            }

            foreach (string strFile in files)
            {
                try
                {
                    if (!listaImages.Items.Contains(strFile))
                    {
                        if (strFile.ToLower().EndsWith(".png") || strFile.ToLower().EndsWith(".bmp")
                            || strFile.ToLower().EndsWith(".jpg") || strFile.ToLower().EndsWith(".gif"))
                        {
                            strFileName = Path.GetFileName(strFile);
                            listaImages.Items.Add(strFileName);
                            strFileName = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error en la aplicación: " + ex);
                }
            }

        }
        #endregion//obtieneArchivos

        #region obtienePathFile
        private string obtienePathFile()
        {
            string strPathFile = string.Empty;

            if (listaImages.SelectedItem != null)
            {
                strPathFile = DirectoryImagesSource.Text + "\\" + listaImages.SelectedItem.ToString();

                Image img = new Bitmap(strPathFile);

                txt_ImageLoadWidth.Text = img.Width.ToString();
                txt_ImageLoadHeight.Text = img.Height.ToString();
                txtB_NombreImagen.Text = listaImages.SelectedItem.ToString();
            }
            return strPathFile;
        }
        #endregion//obtienePathFile

        #region redimensionaImagen
        private Bitmap redimensionaImagen(Image imgOriginal, int nWidth, int nHeigth)
        {
            Bitmap bitMapImg = new Bitmap(nWidth, nHeigth);

            using (Graphics g = Graphics.FromImage((Image)bitMapImg))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(imgOriginal, 0, 0, nWidth, nHeigth);
            }

            return bitMapImg;
        }
        #endregion//redimensionaImagen


        #region marcaAguaTexto
        private Image marcaAguaTexto(Image imgPhoto, string textoMarca)
        {
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(imgPhoto, new Rectangle(0, 0, phWidth, phHeight), 0, 0, phWidth, phHeight, GraphicsUnit.Pixel);

            //To maximize the size of the Copyright message we will test 7 different Font sizes 
            // to determine the largest possible size we can use for the width of our Photograph.
            int[] sizes = new int[] { 72, 48, 36, 28, 26, 24, 22, 10, 18, 16, 14, 12, 10, 8, 6, 4 };
            Font crFont = null;
            SizeF crSize = new SizeF();
            for (int i = 0; i < 7; i++)
            {
                crFont = new Font("arial", sizes[i], FontStyle.Bold);
                crSize = grPhoto.MeasureString(textoMarca, crFont);

                if ((ushort)crSize.Width < (ushort)phWidth)
                    break;
            }

            // Posición abajo centrada
            int yPixlesFromBottom = (int)(phHeight * .05);
            float yPosFromBottom = ((phHeight - yPixlesFromBottom) - (crSize.Height / 2));
            float xCenterOfImg = (phWidth / 2);


            // Pintamos dos veces con el graphics el texto en la imagen con dos brush diferentes
            // con esto conseguiremos el efecto de sombra.
            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;

            SolidBrush semiTransBrush2 = new SolidBrush(Color.FromArgb(153, 0, 0, 0));

            grPhoto.DrawString(textoMarca,
                crFont,
                semiTransBrush2,
                new PointF(xCenterOfImg + 1, yPosFromBottom + 1),
                StrFormat);

            SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(153, 255, 255, 255));

            grPhoto.DrawString(textoMarca,
                crFont,
                semiTransBrush,
                new PointF(xCenterOfImg, yPosFromBottom),
                StrFormat);

            // Vamos a cambiar la imagen por lo que la sacamos de memoria antes
            imgPhoto.Dispose();
            // Pasamos el bitmap a un Image para aprovecharnos de sus propiedades
            imgPhoto = bmPhoto;
            // Descargamos de memoria el graphics
            grPhoto.Dispose();

            return imgPhoto;
        }
        #endregion//marcaAguaTexto



        public MainForm()
        {

            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearFields();
            OpenFileDialog oFD = new OpenFileDialog();
            string strFileName = string.Empty;

            oFD.InitialDirectory = "c:\\";
            oFD.Filter = "Images (*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            oFD.FilterIndex = 2;
            oFD.Multiselect = true;
            oFD.RestoreDirectory = true;

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                DirectoryImagesSource.Text = Path.GetDirectoryName(oFD.FileName);

                foreach (String file in oFD.FileNames)
                {
                    try
                    {
                        if (!listaImages.Items.Contains(file))
                        {
                            strFileName = Path.GetFileName(file);
                            listaImages.Items.Add(strFileName);
                            strFileName = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error en el programa" + ex);
                    }
                }
            }
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DirectoryImagesSource == null || DirectoryImagesSource.Text == string.Empty)
            {
                selectDirectorySource();
            }
        }

        private void listaImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nWidth = 0
               , nHeigth = 0;

            string strPathFile = string.Empty;

            ConfigurationManager.GetSection("appSettings");
            var appSettings = ConfigurationManager.AppSettings;

            strPathFile = obtienePathFile();

            Image img = new Bitmap(strPathFile);

            txtB_MarcaAgua.Text = appSettings["txtMarcaAgua"].ToString();

            if (img.Width > img.Height)
            {
                //Orientación Horizontal
                nWidth = Convert.ToInt32(appSettings["HorWidth"].ToString());
                nHeigth = Convert.ToInt32(appSettings["HorHeight"].ToString());

                txtB_ImgNewWidth.Text = appSettings["NewHorWidth"].ToString();
                txtB_ImgNewHeight.Text = appSettings["NewHorHeight"].ToString();

                txtB_ImgThumbWidth.Text = appSettings["TmbHorWidth"].ToString();
                txtB_ImgThumbHeigth.Text = appSettings["TmbHorHeight"].ToString();

            }
            if (img.Width < img.Height)
            {
                //Orientación Vertical
                nWidth = Convert.ToInt32(appSettings["VerWidth"].ToString());
                nHeigth = Convert.ToInt32(appSettings["VerHeight"].ToString());

                txtB_ImgNewWidth.Text = appSettings["NewVerWidth"].ToString();
                txtB_ImgNewHeight.Text = appSettings["NewVerHeight"].ToString();

                txtB_ImgThumbWidth.Text = appSettings["TmbVerWidth"].ToString();
                txtB_ImgThumbHeigth.Text = appSettings["TmbVerHeight"].ToString();


            }
            if (img.Width == img.Height)
            {
                nWidth = 300;
                nHeigth = 300;
            }
            pictureBox1.Load(strPathFile);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new System.Drawing.Size(nWidth, nHeigth);

            if (cBVerImage.Checked)
            {
                if (!String.IsNullOrEmpty(strPathFile))
                {
                    Process.Start(strPathFile);
                }
            }
        }

        private void btnDirDestiny_Click(object sender, EventArgs e)
        {
            selectDirectoryDest();
        }



        private void btnDirSource_Click(object sender, EventArgs e)
        {
            selectDirectorySource();
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
        }

        private void cBVerImage_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DirectoryImagesSource.Text))
            {
                cBVerImage.Checked = false;
                MessageBox.Show("Seleccione un directorio, por favor", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                string strPathFile = string.Empty;

                if (cBVerImage.Checked)
                {
                    strPathFile = obtienePathFile();

                    if (!String.IsNullOrEmpty(strPathFile))
                    {
                        //mostrarImagen(strPathFile, false);
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona una imagen.", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if (cBVerImage.Checked == false)
                {

                }
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string strPathFile = string.Empty
                 , strImgName = string.Empty;

            int nWidth = 0
              , nHeigth = 0
              , nWidthThumb = 0
              , nHeigthThumb = 0;

            if (!string.IsNullOrEmpty(txtB_NombreImagen.Text))
            {
                nWidth = Convert.ToInt32(txtB_ImgNewWidth.Text);
                nHeigth = Convert.ToInt32(txtB_ImgNewHeight.Text);

                nWidthThumb = Convert.ToInt32(txtB_ImgThumbWidth.Text);
                nHeigthThumb = Convert.ToInt32(txtB_ImgThumbHeigth.Text);
                strImgName = txtB_NombreImagen.Text;

                if (nWidth <= 0 || nHeigth <= 0
                    || nWidthThumb <= 0 || nHeigthThumb <= 0)
                {
                    MessageBox.Show("No se ha dado una dimension valida a la imagen.", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                strPathFile = obtienePathFile();

                Image img = new Bitmap(strPathFile);

                Bitmap bitMapImg = redimensionaImagen(marcaAguaTexto(img, txtB_MarcaAgua.Text), nWidth, nHeigth);
                bitMapImg.Save(DirectoryImagesDestiny.Text + "\\" + strImgName + ".jpg", ImageFormat.Jpeg);
                bitMapImg.Dispose();

                Image img1 = new Bitmap(strPathFile);

                Bitmap bitMapImgThumb = redimensionaImagen(marcaAguaTexto(img1, txtB_MarcaAgua.Text), nWidthThumb, nHeigthThumb);
                bitMapImgThumb.Save(DirectoryImagesDestiny.Text + "\\" + strImgName + ".thumb.jpg", ImageFormat.Jpeg);
                bitMapImgThumb.Dispose();

                MessageBox.Show("He terminado de procesar la imagen.", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen.", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }


        private void DirectoryImagesSource_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strPath = string.Empty;

                strPath = DirectoryImagesSource.Text;

                if (Directory.Exists(strPath))
                {
                    obtieneArchivos(DirectoryImagesSource.Text);

                    if (String.IsNullOrEmpty(DirectoryImagesDestiny.Text))
                    {
                        DirectoryImagesDestiny.Text = DirectoryImagesSource.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Ruta Invalida");
                }
            }
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop prt = new Prop();
            prt.Show();
        }
    }
}
