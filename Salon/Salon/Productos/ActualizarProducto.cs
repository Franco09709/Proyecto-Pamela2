using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Productos
{
    public partial class ActualizarProducto : Form
    {
        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {

        }

        private void cbEstadoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleccionando el estado y asigarle el valor de su estado correspondiente
            int indice = 0;
            string valor = "";
            indice = cbEstadoProd.SelectedIndex;
            switch (indice)
            {
                //En caso de que el indice sea 0 el valor sera true y si es 1 es false
                case 0:
                    valor = "True";
                    break;

                case 1:
                    valor = "False";
                    break;
            }
            //En txtestadover se guardara el valor del estado
            txtnumestado.Text = valor.ToString();
        }

        private void Closeactprod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnumestado_TextChanged(object sender, EventArgs e)
        {
            





        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
