using Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominios;
using WarcraftDatos;

namespace winform
{
    public partial class VIsualizarNicks : Form
    {
        

        private List<Nickname> listanickmostrar;
        public VIsualizarNicks()
        {
            InitializeComponent();
        }
       

        public void dataGridViewVisualizar_SelectionChanged(object sender, EventArgs e)
        {
            Nickname seleccionado = (Nickname)dataGridViewVisualizar.CurrentRow.DataBoundItem;

        }
        public void cargar()
        {
            NicknameMostrarDatos datos = new NicknameMostrarDatos();
            try
            {
                listanickmostrar = datos.MostrarNicks();
                dataGridViewVisualizar.DataSource = listanickmostrar;
                
                //



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void VIsualizarNicks_Load(object sender, EventArgs e)
        {
            cargar();



        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Nickname seleccionado;
            seleccionado = (Nickname)dataGridViewVisualizar.CurrentRow.DataBoundItem;

            AgregarPalabras modificar = new AgregarPalabras(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
