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

        private Nickname nickname = null;
       
        public AgregarPalabras() //duplicando los "initialize" y pasando por parametros hago un pasaje entre ventanas
        {
            InitializeComponent();//se ejecuta al agregar
        }
        public AgregarPalabras(Nickname nickname)
        {
            InitializeComponent();//se ejecuta al modificar
            this.nickname = nickname;
            Text = "Modificar Nickname";
        }

        private void buttonCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarname_Click(object sender, EventArgs e)
        {
            //Nickname nick = new Nickname();
            NicknameDatos agregarnick = new NicknameDatos();
            
           
            
            try
            {
                if(nickname == null)
                nickname  = new Nickname();
                
                nickname.nicknames = textBoxAgregarNick.Text;
                //nickname.nombreraza = (string)comboBoxRazaAG.SelectedItem;
                nickname.nombreraza = ((Dominios.Raza)comboBoxRazaAG.SelectedItem).Nombreraza;

                //nickname.genero = (string)comboBoxGeneroAG.SelectedItem;
                nickname.genero = ((Dominios.Genero)comboBoxGeneroAG.SelectedItem).Generos;

                //nickname.NombreTipoPersonaje = (string)comboBoxClaseAG.SelectedItem;
                nickname.NombreTipoPersonaje = ((Dominios.TipoPersonaje)comboBoxClaseAG.SelectedItem).nombreTipoPersonaje;

                if (nickname.id != 0)
                {
                agregarnick.modificar(nickname);
                MessageBox.Show("Se modifico exitosamente");

                }
                else
                {
                agregarnick.agregar(nickname);
                MessageBox.Show("Se agrego exitosamente");
                

                }
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
            //comboBoxRazaAG.ValueMember = "id";
            comboBoxRazaAG.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxGeneroAG.DataSource = generodato.ListarGeneros();
            comboBoxGeneroAG.DisplayMember = "Genero";
            //comboBoxGeneroAG.ValueMember = "id";
            comboBoxGeneroAG.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBoxClaseAG.DataSource = tipoPersonajeDato.ListarClase();
            comboBoxClaseAG.DisplayMember = "NombreTipoPersonaje";
            //comboBoxClaseAG.ValueMember = "id";
            comboBoxClaseAG.DropDownStyle = ComboBoxStyle.DropDownList;

             if (nickname != null)
                {
                    textBoxAgregarNick.Text = nickname.nicknames;
                    comboBoxRazaAG.Text = nickname.nombreraza;
                    comboBoxGeneroAG.Text = nickname.genero;
                    comboBoxClaseAG.Text = nickname.NombreTipoPersonaje;

                   //comboBoxRazaAG.SelectedValue = nickname.id;
                   //comboBoxGeneroAG.SelectedValue = nickname.id;
                   // comboBoxClaseAG.SelectedValue = nickname.id; 
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
