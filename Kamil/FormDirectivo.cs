using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Coppel
{
    public partial class FormDirectivo : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public FormDirectivo()
        {
            InitializeComponent();
        }

        private void FormDirectivo_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog= Kamil;Integrated Security=True");
            cn.Open();
            //bind data in data grid view  
            ObtenerDirectivos();

            //disable delete and update button on load  
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ObtenerDirectivos()
        {
            SqlCommand cmd = new SqlCommand("Directivo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Centro_Supervisa", "");
            cmd.Parameters.AddWithValue("@Prestacion_Combustible", 0);
            cmd.Parameters.AddWithValue("@OperationType", "5");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDirectivo.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtbNumero.Text != String.Empty && txtbCentroSupervisado.Text != String.Empty && txtbCiudad.Text != String.Empty && txtbNumeroEmpleado.Text != String.Empty)
            {
                cmd = new SqlCommand("Directivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                string sqlquery = "INSERT INTO Directivo (Centro_Supervisa, Prestacion_Combustible) VALUES (@Centro_Supervisa, @Prestacion_Combustible)";
                cmd = new SqlCommand(sqlquery, cn);
                cmd.Parameters.AddWithValue("@Centro_Supervisa", "");
                cmd.Parameters.AddWithValue("@Prestacion_Combustible", 0);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerDirectivos();
                txtbNumero.Text = "";
                txtbCentroSupervisado.Text = "";
                txtbCiudad.Text = "";
                txtbNumeroEmpleado.Text = "";

            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtbNumero.Text != string.Empty)
            {

                cmd = new SqlCommand("Directivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Centro_Supervisa", "");
                cmd.Parameters.AddWithValue("@Prestacion_Combustible", 0);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbCentroSupervisado.Text = dr["Centro_Supervisado"].ToString();
                    txtbCiudad.Text = dr["Ciudad"].ToString();
                    txtbNumeroEmpleado.Text = dr["ID_Empleado"].ToString();
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No record found with this id", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please enter Center id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtbNumero.Text != String.Empty && txtbCentroSupervisado.Text != String.Empty && txtbCiudad.Text != String.Empty && txtbNumeroEmpleado.Text != String.Empty)
            {
                cmd = new SqlCommand("Directivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Centro_Supervisa", "");
                cmd.Parameters.AddWithValue("@Prestacion_Combustible", 0);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerDirectivos();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtbNumero.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Center ? ", "Delete Center", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {

                    cmd = new SqlCommand("Directivo", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Centro_Supervisa", "");
                    cmd.Parameters.AddWithValue("@Prestacion_Combustible", 0);
                    cmd.Parameters.AddWithValue("@OperationType", "1");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerDirectivos();
                    txtbNumero.Text = "";
                    txtbCentroSupervisado.Text = "";
                    txtbCiudad.Text = "";
                    txtbNumeroEmpleado.Text = "";
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter Center id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
