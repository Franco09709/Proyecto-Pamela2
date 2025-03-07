using Capa_de_Negocio;
using Salon.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Clientes
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnAgregclient_Click(object sender, EventArgs e)
        {
            AñadirProducto añadirCliente =new AñadirProducto();
            añadirCliente.ShowDialog();
        }

        public void ListarProducto()
        {
            try
            {
                DgvDatosProductos.DataSource = NProducto.ListarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {   
            DgvDatosProductos.ReadOnly = true;
            this.ListarProducto();
        }

        private void DgvDatosProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Añadiendo el boton de editar al datagridview
            if (e.ColumnIndex == DgvDatosProductos.Columns["editar"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Cargar la imagen
                Image editImage = Properties.Resources.editardef1;

                // Dibujar la imagen centrada
                int imageX = e.CellBounds.Left + (e.CellBounds.Width - editImage.Width) / 2;
                int imageY = e.CellBounds.Top + (e.CellBounds.Height - editImage.Height) / 2;
                e.Graphics.DrawImage(editImage, new Point(imageX, imageY));

                e.Handled = true;
            }
        }

        private void DgvDatosProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDatosProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaseleccionada = DgvDatosProductos.SelectedRows[0];
                string Nombreprod= filaseleccionada.Cells["NombreProducto"].Value.ToString();
                decimal precio = Convert.ToDecimal(filaseleccionada.Cells["Precio"].Value);
                string Proveedor = filaseleccionada.Cells["Proveedor"].Value.ToString();
                string Estado = filaseleccionada.Cells["Estado"].Value.ToString();

                ActualizarProducto actualizarProducto = new ActualizarProducto();
                actualizarProducto.ShowDialog();
            }
        }
    }
}
