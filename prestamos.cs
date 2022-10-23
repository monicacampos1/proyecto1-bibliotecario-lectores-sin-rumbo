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
    public partial class prestamos : Form
    {

        //Variables globales
        public string cadena_conexion = " server=localhost;user id=biblioteca;password=trejo1090;database=biblioteca;persistsecurityinfo=True";
        public prestamos()
        {
            InitializeComponent();
        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            agregarprestamos ven = new agregarprestamos();
            ven.Show();
        }

        private void prestamos_Load(object sender, EventArgs e)
        {
            try
            {

                string consulta = "select * from tprestamos";

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
            txtdevolucion.Enabled = false;
            txtlibro.Enabled = false;
            txtusuarios.Enabled = false;

        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = ("select * from tprestamos Where idprestamo = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {
                        txtdevolucion.Text = (myReader.GetString(5));
                        txtlibro.Text = (myReader.GetString(2));
                        txtusuarios.Text = (myReader.GetString(3));
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
                    string myInsertQuery = ("select * from tprestamos Where nombrelip = '" + txtbuscar.Text + "'");
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read() == true)
                    {

                        txtdevolucion.Text = (myReader.GetString(5));
                        txtlibro.Text = (myReader.GetString(2));
                        txtusuarios.Text = (myReader.GetString(3));

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

            private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            txtdevolucion.Text = "";
            txtlibro.Text = "";
            txtusuarios.Text = "";
            radioButton1.Checked = false;
            bbuscar.Enabled = false;
            rnombre.Checked = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
             try
            {

                string consulta = "select * from tprestamos";

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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }

        private void rnombre_CheckedChanged(object sender, EventArgs e)
        {
            bbuscar.Enabled = true;
        }
    }
}