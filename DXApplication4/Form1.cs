using DXApplication4.sisstemadelibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(unitOfWork1);
            cliente.Cedula = "281-091186-0016D";
            cliente.Nombre = "Ericka Valeska";
            cliente.Apellido = "Pichardo Palma";
            cliente.Direccion = "Barrio Laborio";
            cliente.Email = "psiquispalma@gmail.com";
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
