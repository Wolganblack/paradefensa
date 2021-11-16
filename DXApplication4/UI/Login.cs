using SistemaLibreria.IU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using ModeloDatos.ORM;

namespace SistemaLibreria.IU
{
    public partial class Login: DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(unitOfWork1);
            cliente.cedula = "281-091186-0016D";
            cliente.nombre = "Ericka Valeska";
            cliente.apellido = "Pichardo Palma";
            cliente.direccion = "Barrio Laborio";
            cliente.email = "psiquispalma@gmail.com";
            cliente.Save();
            unitOfWork1.CommitChanges();
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
