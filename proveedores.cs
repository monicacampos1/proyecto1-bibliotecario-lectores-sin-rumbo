using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Practica_semana_10
{
    public partial class proveedores : Form
    {

        //Variables globales
        //Conexion  de la base de datos
        public string cadena_conexion = " server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca;persistsecurityinfo=True";
        public proveedores()
        {
            InitializeComponent();
        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            agregarproveedores ven = new agregarproveedores();
            ven.Show();
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            try
            {

                string consulta = "select * from tproveedores";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "biblioteca");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca";

            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            bbuscar.Enabled = false;
            txtbuscar.Enabled = false;
            txtIDeditorial.Enabled = false;
            txtIDproveedores.Enabled = false;
            txtNombreProveedores.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tproveedores Where idproveedor = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        txtIDeditorial.Text = (myReader.GetString(0));
                        txtIDproveedores.Text = (myReader.GetString(1));
                        txtNombreProveedores.Text = (myReader.GetString(2));
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    myReader.Close();
                    myConnection.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else

            {
                if (rnombre.Checked == true)
                {
                    {
                        try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tproveedores Where nombrepro = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtIDeditorial.Text = (myReader.GetString(0));
                        txtIDproveedores.Text = (myReader.GetString(1));
                        txtNombreProveedores.Text = (myReader.GetString(2));

                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    myReader.Close();
                    myConnection.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            txtIDeditorial.Text = "";
            txtIDproveedores.Text = "";
            txtNombreProveedores.Text = "";
            radioButton1.Checked = false;
            rnombre.Checked = false;
            bbuscar.Enabled = false;

        }

        //Funciones de los botones y otros elementos
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}