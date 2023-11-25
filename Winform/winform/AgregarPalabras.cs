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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform
{
    public partial class AgregarPalabras : Form
    {

        private NicknamesMostrar nicknamesmostrar = null;
        public AgregarPalabras() //duplicando los "initialize" y pasando por parametros hago un pasaje entre ventanas
        {
            InitializeComponent();//se ejecuta al agregar
        }
        public AgregarPalabras(NicknamesMostrar nicknamesMostrar)
        {
            InitializeComponent();//se ejecuta al modificar
            this.nicknamesmostrar = nicknamesMostrar;
        }

        private void buttonCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarname_Click(object sender, EventArgs e)
        {
            Nickname nick = new Nickname();
            NicknameDatos agregarnick = new NicknameDatos();
            Raza raza = new Raza();
            RazaDatos rdatos = new RazaDatos();
            try
            {
                nick.nickname = textBoxAgregarNick.Text;               
                nick.Nombreraza = (Raza)comboBoxRazaAG.SelectedItem;
                nick.genero = (Genero)comboBoxGeneroAG.SelectedItem;
                nick.TipoPersonaje = (TipoPersonaje)comboBoxClaseAG.SelectedItem;


                agregarnick.agregar(nick);
                MessageBox.Show("Se agrego exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        private void AgregarPalabras_Load(object sender, EventArgs e)
        {

            RazaDatos razadatos = new RazaDatos();
            GeneroDato generodato = new GeneroDato();
            TipoPersonajeDato tipoPersonajeDato = new TipoPersonajeDato();

            try
            {
            comboBoxRazaAG.DataSource = razadatos.ListarRaza();//invoco la pediticion de datoa de la clase RAZA DATOS
            comboBoxRazaAG.DisplayMember = "NombreRaza";
            comboBoxRazaAG.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxGeneroAG.DataSource = generodato.ListarGeneros();
            comboBoxGeneroAG.DisplayMember = "Genero";
            comboBoxGeneroAG.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBoxClaseAG.DataSource = tipoPersonajeDato.ListarClase();
            comboBoxClaseAG.DisplayMember = "NombreTipoPersonaje";
            comboBoxClaseAG.DropDownStyle = ComboBoxStyle.DropDownList;

             if (nicknamesmostrar != null)
                {
                    textBoxAgregarNick.Text = nicknamesmostrar.nicknames;
                    comboBoxRazaAG.Text = nicknamesmostrar.raza;
                    comboBoxGeneroAG.Text = nicknamesmostrar.genero;
                    comboBoxClaseAG.Text = nicknamesmostrar.tipopersonaje;
                }   

            }
            catch (Exception)
            {

                throw;
            }
            


        }
        //(NicknamesMostrar) dataGridViewVisualizar.CurrentRow.DataBoundItem;//c asteo explicito
        private void modificarNicknamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            

            
        }
    }
}
