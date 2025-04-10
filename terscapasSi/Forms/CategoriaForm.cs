using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using terscapasSi.Controllers;
using terscapasSi.Model.Entities;
using terscapasSi.Model.Services;

namespace terscapasSi.UI
{

    public partial class CategoriaForm : Form
    {
        private readonly CategoriaControllers _controller;

        public CategoriaForm()
        {
            _controller = new CategoriaControllers();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //CREAMOS UNA NUEVA INSTANCIA DEL OBJETO CATEGORIA
            var newCat = new Categoria();
            newCat.Id = Convert.ToInt32(nudId.Value);
            newCat.Name = txtNombre.Text;
            newCat.Activa = chkActiva.Checked;
            //*************************************************

            //INVOCANDO AL CONTROLLER DE CATEGORIAS ALMACENAREMOS
            //EN LA BBDD ESTE OBJETO
            bool result = _controller.CrearCategoria(newCat);
            if (result == true)
            {
                RefrescarTabla();
                MessageBox.Show("Registro Guardado Correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un Problema al tratar de guardar el registro");
            }
        }
        private void RefrescarTabla()
        {
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = _controller.ObtenerTodas();
            dgvCategoria.Refresh();
            dgvCategoria.Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //CREAMOS UNA NUEVA INSTANCIA DEL OBJETO CATEGORIA
            var newCat = new Categoria();
            newCat.Id = Convert.ToInt32(nudId.Value);
            newCat.Name = txtNombre.Text;
            newCat.Activa = chkActiva.Checked;
            //*************************************************

            //INVOCANDO AL CONTROLLER DE CATEGORIAS ALMACENAREMOS
            //EN LA BBDD ESTE OBJETO
            bool result = _controller.ActualizarCategoria(newCat.Id, newCat);
            if (result == true)
            {
                RefrescarTabla();
                MessageBox.Show("Registro Actualizado Correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un Problema al tratar de Actualizar el registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminar = MessageBox.Show(
                 "¿Realmente desea eliminar este registro?",
                 "Categorias",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (eliminar == DialogResult.Yes)
            {
                //CREAMOS UNA NUEVA INSTANCIA DEL OBJETO CATEGORIA
                int catId = Convert.ToInt32(nudId.Value);
                //*************************************************

                //INVOCANDO AL CONTROLLER DE CATEGORIAS ALMACENAREMOS
                //EN LA BBDD ESTE OBJETO
                bool result = _controller.EliminarCategoria(catId);
                if (result == true)
                {
                    RefrescarTabla();
                    MessageBox.Show("Registro Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un Problema al tratar de Eliminar el registro");
                }
            }
        }
    }
}
