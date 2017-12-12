using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ResizeImages
{
    public partial class Prop : Form
    {
        public Prop()
        {
            InitializeComponent();
            LoadSettings();

        }

        private void LoadSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings esta vacio.");
                }
                else
                {
                    nmShHorWidth.Value = Convert.ToInt32(appSettings["HorWidth"].ToString());
                    nmShHorHeigth.Value = Convert.ToInt32(appSettings["HorHeight"].ToString());

                    nmShVerWidth.Value = Convert.ToInt32(appSettings["VerWidth"].ToString());
                    nmShVerHeigth.Value = Convert.ToInt32(appSettings["VerHeight"].ToString());

                    nmNewHorWidth.Value = Convert.ToInt32(appSettings["NewHorWidth"].ToString());
                    nmNewHorHeigth.Value = Convert.ToInt32(appSettings["NewHorHeight"].ToString());

                    nmNewVerWidth.Value = Convert.ToInt32(appSettings["NewVerWidth"].ToString());
                    nmNewVerHeigth.Value = Convert.ToInt32(appSettings["NewVerHeight"].ToString());

                    nmTmbHorWidth.Value = Convert.ToInt32(appSettings["TmbHorWidth"].ToString());
                    nmTmbHorHeigth.Value = Convert.ToInt32(appSettings["TmbHorHeight"].ToString());

                    nmTmbVerWidth.Value = Convert.ToInt32(appSettings["TmbVerWidth"].ToString());
                    nmTmbVerHeigth.Value = Convert.ToInt32(appSettings["TmbVerHeight"].ToString());

                    txtBPropMarcaAgua.Text = appSettings["txtMarcaAgua"].ToString();
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                configuration.AppSettings.Settings["HorWidth"].Value = nmShHorWidth.Value.ToString();
                configuration.AppSettings.Settings["HorHeight"].Value = nmShHorHeigth.Value.ToString();

                configuration.AppSettings.Settings["VerWidth"].Value = nmShVerWidth.Value.ToString();
                configuration.AppSettings.Settings["VerHeight"].Value = nmShVerHeigth.Value.ToString();

                configuration.AppSettings.Settings["NewHorWidth"].Value = nmNewHorWidth.Value.ToString();
                configuration.AppSettings.Settings["NewHorHeight"].Value = nmNewHorHeigth.Value.ToString();

                configuration.AppSettings.Settings["NewVerWidth"].Value = nmNewHorWidth.Value.ToString();
                configuration.AppSettings.Settings["NewVerHeight"].Value = nmNewHorHeigth.Value.ToString();

                configuration.AppSettings.Settings["TmbHorWidth"].Value = nmTmbHorWidth.Value.ToString();
                configuration.AppSettings.Settings["TmbHorHeight"].Value = nmTmbHorHeigth.Value.ToString();

                configuration.AppSettings.Settings["TmbVerWidth"].Value = nmTmbHorWidth.Value.ToString();
                configuration.AppSettings.Settings["TmbVerHeight"].Value = nmTmbHorHeigth.Value.ToString();



                configuration.AppSettings.Settings["txtMarcaAgua"].Value = txtBPropMarcaAgua.Text;

                configuration.Save();

                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Los valores se han guardado exitosamente.");
                Prop.ActiveForm.Close();
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
