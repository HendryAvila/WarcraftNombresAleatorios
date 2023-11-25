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
using WarcraftDatos;


namespace winform
{
    public partial class Form1 : Form
    {
        private List<Raza> listaRaza; //creo un atributo privado de tipo lista para poder manipular la lista
        private List<Genero> listaGenero; //creo un atributo privado de tipo lista para poder manipular la lista
        private List<TipoPersonaje> listaTipoPersonaje; //creo un atributo privado de tipo lista para poder manipular la lista
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        
            RazaDatos dato = new RazaDatos();
            listaRaza = dato.ListarRaza();
            comboBoxRaza.DisplayMember = "nombreRaza";
            comboBoxRaza.DataSource = listaRaza;//al data source le agrego la lista
            CargarImagen(listaRaza[0].UrlImagen);//en el pctrBox al cargar el load le paso el primer elementode la lista.URL


            GeneroDato datos = new GeneroDato();
            listaGenero = datos.ListarGeneros();
            comboBoxGenero.DisplayMember = "Genero";
            comboBoxGenero.DataSource = listaGenero;

            TipoPersonajeDato clase = new TipoPersonajeDato();
            listaTipoPersonaje = clase.ListarClase();
            comboBoxClase.DisplayMember = "NombreTipoPersonaje";
            comboBoxClase.DataSource = listaTipoPersonaje;


        }

   

        private void agregarNicknamesDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPalabras ventana = new AgregarPalabras();
            ventana.ShowDialog();
        }

        private void comboBoxRaza_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Raza Seleccionada = (Raza)comboBoxRaza.SelectedItem;
            string UrlImagen = Seleccionada.UrlImagen;
            CargarImagen(Seleccionada.UrlImagen);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBoximagenRaza.Load(imagen);
                pictureBoximagenRaza.BackColor = Color.Transparent;


            }
            catch (Exception ex)
            {
                //todo una exepcion
                pictureBoximagenRaza.Load("https://th.bing.com/th/id/OIP.dxt2_gkvMt-3ZUVo8RF9SQHaHa?pid=ImgDet&rs=1"); // si no carga nada que me cargue esa imagen
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SendToBack(); // Esto enviará el PictureBox de fondo al fondo.

        }

        private void pictureBoximagenRaza_Click(object sender, EventArgs e)
        {
            pictureBoximagenRaza.BackColor = Color.Transparent;
        }

       

        private void mostrarNickGaurdadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIsualizarNicks ventana = new VIsualizarNicks();
            ventana.ShowDialog();
            
        }

        

        
    }
}
