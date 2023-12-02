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
    public partial class FormCentro : Form
    {
        
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public FormCentro()
        {
            InitializeComponent();
        }

        private void FormCentro_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog= Kamil;Integrated Security=True");
            cn.Open();
            //bind data in data grid view  
            ObtenerCentros();

            //disable delete and update button on load  
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ObtenerCentros()
        {
            SqlCommand cmd = new SqlCommand("Centro_Trabajo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Centro", 0);
            cmd.Parameters.AddWithValue("@Nombre_centro", "");
            cmd.Parameters.AddWithValue("@Ciudad", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCentros.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtbCentro.Text != String.Empty && txtbNombre.Text != String.Empty && txtbCiudad.Text != String.Empty)
            {
                cmd = new SqlCommand("Centro_Trabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                string sqlquery = "INSERT INTO Centro_Trabajo (Centro, Nombre_centro, Ciudad) VALUES (@Centro, @Nombre_centro, @Ciudad)";
                cmd = new SqlCommand(sqlquery, cn);
                cmd.Parameters.AddWithValue("@Centro", txtbCentro.Text);
                cmd.Parameters.AddWithValue("@Nombre_centro", txtbNombre.Text);
                cmd.Parameters.AddWithValue("@Ciudad", txtbCiudad.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCentros();
                txtbCentro.Text = "";
                txtbNombre.Text = "";
                txtbCiudad.Text = "";
                
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtbCentro.Text != string.Empty)
            {

                cmd = new SqlCommand("Centro_Trabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Centro", txtbCentro.Text);
                cmd.Parameters.AddWithValue("@Nombre_centro", "");
                cmd.Parameters.AddWithValue("@Ciudad", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbNombre.Text = dr["Nombre_centro"].ToString();
                    txtbCiudad.Text = dr["Ciudad"].ToString();
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
            if (txtbCentro.Text != string.Empty && txtbNombre.Text != string.Empty && txtbCiudad.Text != string.Empty)
            {
                cmd = new SqlCommand("Centro_Trabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Centro", txtbCentro.Text);
                cmd.Parameters.AddWithValue("@Nombre_centro", txtbNombre.Text);
                cmd.Parameters.AddWithValue("@Ciudad", txtbCiudad.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCentros();
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
            if (txtbCentro.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Center ? ", "Delete Center", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {

                    cmd = new SqlCommand("Centro_Trabajo", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Centro", txtbCentro.Text);
                    cmd.Parameters.AddWithValue("@Nombre_centro", "");
                    cmd.Parameters.AddWithValue("@Ciudad", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerCentros();
                    txtbCentro.Text = "";
                    txtbNombre.Text = "";
                    txtbCiudad.Text = "";
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

