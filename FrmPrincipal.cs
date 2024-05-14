using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaEtapa5
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        clsVehiculo objAuto; clsVehiculo objAvion; clsVehiculo objBarco;
        bool Auto; bool Barco; bool Avion;
        int GeneradorDeImagen;
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            GeneradorDeImagen = rnd.Next(1,4);
            switch(GeneradorDeImagen)
            {
                case 1:
                    objAuto.CrearAuto();
                    objAuto.pctAuto.Location = new Point(70, 1);
                    Controls.Add(objAuto.pctAuto);
                    Auto = true;
                    if (Avion == true)
                    {
                        objAvion.pctAvion.Dispose();
                        Avion = false;
                    }
                    if (Barco == true)
                    {
                        objBarco.pctBarco.Dispose();
                        Barco = false;
                    }
                break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(70, 1);
                    Controls.Add(objAvion.pctAvion);
                    Avion = true;
                    if (Auto == true)
                    {
                        objAuto.pctAuto.Dispose();
                        Auto = false;
                    }
                    if (Barco == true)
                    {
                        objBarco.pctBarco.Dispose();
                        Barco = false;
                    }
                break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(70, 1);
                    Controls.Add(objBarco.pctBarco);
                    Barco = true;
                    if (Auto == true)
                    {
                        objAuto.pctAuto.Dispose();
                        Auto = false;
                    }
                    if (Avion == true)
                    {
                        objAvion.pctAvion.Dispose();
                        Avion = false;
                    }
                break;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();
            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }
    }
}
