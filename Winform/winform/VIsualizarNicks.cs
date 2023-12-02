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
            if (dataGridViewVisualizar != null)
            {

                Nickname seleccionado = (Nickname)dataGridViewVisualizar.CurrentRow.DataBoundItem;
            }

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
            comboBoxCampo.Items.Add("ID");
            comboBoxCampo.Items.Add("Nicknames");
            comboBoxCampo.Items.Add("Raza");
            comboBoxCampo.Items.Add("Clase");



        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Nickname seleccionado;
            if (dataGridViewVisualizar.Rows.Count > 0)
            {

            if(dataGridViewVisualizar != null)
            {
            seleccionado = (Nickname)dataGridViewVisualizar.CurrentRow.DataBoundItem;//aqui me da null reference osea que el objeto esta vacio
             if(seleccionado != null)
                {
            AgregarPalabras modificar = new AgregarPalabras(seleccionado);
            modificar.ShowDialog();
            cargar();
                    
              
                }
                else
                {
                    MessageBox.Show("no hay datos para modificar");
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila antes de intentar modificar");
                
            }

            }
            else
            {
                MessageBox.Show("No hay filas a seleccionar");
            }
            

        }

        private void Eliminarfisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonEliminacionLogica_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {
            
            NicknameDatos datos = new NicknameDatos();
            Nickname seleccionado;
            try
            {
                    if(dataGridViewVisualizar.Rows.Count < 0)
                    {

                    DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar este Nickname?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                    
                    seleccionado = (Nickname)dataGridViewVisualizar.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        datos.EliminarLogico(seleccionado.id);
                        MessageBox.Show("Se elimino exitosamente.");
                        cargar();

                    }
                    else
                    {
                        datos.Eliminar(seleccionado.id);
                        cargar();
                        MessageBox.Show("Se elimino exitosamente");

                    }
                    }
                    }
                    else
                    {
                    MessageBox.Show("No hay nada para eliminar");
                    }



                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidarFiltro()
        {
            if(comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo para filtrar");
                return true;

            }
            if (comboBoxCriterio.SelectedIndex <0)
            {
                MessageBox.Show("Por favor seleccione el Criterio para filtrar");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "ID")
            {
                if (string.IsNullOrEmpty(textBoxfiltroavanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro numerico.");
                    return true;
                }
                if (!(validarNumero(textBoxfiltroavanzado.Text)))
                {
                    MessageBox.Show("Ingresa solo numeros, Por favor.");
                return true;
                }


                    
            }
            return false;
            
        }
        private bool validarNumero(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            NicknameMostrarDatos datos = new NicknameMostrarDatos();

            try
            {
                if (ValidarFiltro())
                    return;
            string campo = comboBoxCampo.SelectedItem.ToString();
            string criterio = comboBoxCriterio.SelectedItem.ToString();
            string filtro = textBoxfiltroavanzado.Text;

               

                dataGridViewVisualizar.DataSource = datos.filtrar(campo, criterio, filtro);
                
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        //private void textBoxFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        //{
            


        //}

        private void textBoxFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Nickname> listafiltrada;//creo la lista sin instancia porque la linea de abajo devuelve una lista
            string filtro = textBoxFiltrar.Text;
            if (filtro.Length >= 2)//siempre que la texbox tenga algo me lo filtra

            {

                listafiltrada = listanickmostrar.FindAll(x => x.nicknames.ToLower().Contains(filtro.ToLower()));
            }
            else//y si el texbox no tiene nada me devuelve mi lista normal es decir me muestra todo de nuevo
            {
                listafiltrada = listanickmostrar;
            }

            dataGridViewVisualizar.DataSource = null;//limpio la lista
            dataGridViewVisualizar.DataSource = listafiltrada;//asigno la lista limpiada y filtrada
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();
            if (opcion == "ID")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private void comboBoxFiltroAvanzado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
