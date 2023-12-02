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
    public partial class FormEmpleado : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog=Kamil;Integrated Security=True");
            cn.Open();
            //bind data in data grid view  
            ObtenerEmpleados();

            //disable delete and update button on load  
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;


            cn = new SqlConnection(@"Data Source=(local);Initial Catalog=Kamil;Integrated Security=True");
            cn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Centro, Nombre FROM Centro_Trabajo", cn);

            //Fill the DataTable with records from Table.
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            //Assign DataTable as DataSource.
            cbCentroTrabajo.DataSource = dt;
            cbCentroTrabajo.DisplayMember = "Nombre_centro";
            cbCentroTrabajo.ValueMember = "Centro";

            SqlDataAdapter sda_puesto = new SqlDataAdapter("SELECT Puesto, Descripcion FROM Puesto", cn);

            //Fill the DataTable with records from Table.
            DataTable dt_puesto = new DataTable();
            sda_puesto.Fill(dt_puesto);

            //Insert the Default Item to DataTable.
            DataRow row_puesto = dt_puesto.NewRow();
            row_puesto[0] = 0;
            row_puesto[1] = "Please select";
            dt_puesto.Rows.InsertAt(row_puesto, 0);

            //Assign DataTable as DataSource.
            cbPuesto.DataSource = dt_puesto;
            cbPuesto.DisplayMember = "Descripcion";
            cbPuesto.ValueMember = "Puesto";
        }

        private void ObtenerEmpleados()
        {
            SqlCommand cmd = new SqlCommand("Empleados", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Empleaddo", 0);
            cmd.Parameters.AddWithValue("@Nombre", "");
            cmd.Parameters.AddWithValue("@Apellidopaterno", "");
            cmd.Parameters.AddWithValue("@Apellidomaterno", "");
            cmd.Parameters.AddWithValue("@Fec_Nac", "");
            cmd.Parameters.AddWithValue("@Rfc", "");
            cmd.Parameters.AddWithValue("@Centro", 0);
            cmd.Parameters.AddWithValue("@Puesto", "");
            cmd.Parameters.AddWithValue("@Directivo", 0);
            cmd.Parameters.AddWithValue("@OperationType", "5");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmpleados.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtbNumero.Text != String.Empty && txtbNombre.Text != String.Empty && txtbAPaterno.Text != String.Empty && txtbAMaterno.Text != String.Empty && txtbAMaterno.Text != String.Empty && txtbFechaNacimiento.Text != String.Empty && txtbRfc.Text != String.Empty && cbCentroTrabajo.Text != String.Empty && cbPuesto.Text != string.Empty && txtbDirectivo.Text != String.Empty)
            {
                cmd = new SqlCommand("Empleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                string sqlquery = "INSERT INTO Empleados (Empleaddo, Nombre, Apellidopaterno, Apellidomaterno, Fec_Nac, Rfc, Centro, Puesto, Directivo) VALUES (@Empleaddo, @Nombre, @Apellidopaterno, @Apellidomaterno, @Fec_Nac, @Rfc, @Centro, @Puesto, @Directivo)";
                cmd = new SqlCommand(sqlquery, cn);
                cmd.Parameters.AddWithValue("@Empleaddo", txtbNumero.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombre.Text);
                cmd.Parameters.AddWithValue("@Apellidopaterno", txtbAPaterno.Text);
                cmd.Parameters.AddWithValue("@Apellidomaterno", txtbAMaterno);
                cmd.Parameters.AddWithValue("@Fec_Nac", txtbFechaNacimiento.Text);
                cmd.Parameters.AddWithValue("@Rfc", txtbRfc.Text);
                cmd.Parameters.AddWithValue("@Centro", cbCentroTrabajo.Text);
                cmd.Parameters.AddWithValue("@Puesto", cbPuesto.Text);
                cmd.Parameters.AddWithValue("@Directivo", txtbDirectivo.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerEmpleados();
                txtbNumero.Text = "";
                txtbNombre.Text = "";
                txtbAPaterno.Text = "";
                txtbAMaterno.Text = "";
                txtbFechaNacimiento.Text = "";
                txtbRfc.Text = "";
                cbCentroTrabajo.Text = "";
                cbPuesto.Text = "";
                txtbDirectivo.Text = "";

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

                cmd = new SqlCommand("Empleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleaddo", txtbNumero.Text);
                cmd.Parameters.AddWithValue("@Nombre", "");
                cmd.Parameters.AddWithValue("@Apellidopaterno", "");
                cmd.Parameters.AddWithValue("@Apellidomaterno", "");
                cmd.Parameters.AddWithValue("@Fec_Nac", "");
                cmd.Parameters.AddWithValue("@Rfc", "");
                cmd.Parameters.AddWithValue("@Centro", 0);
                cmd.Parameters.AddWithValue("@Puesto", "");
                cmd.Parameters.AddWithValue("@Directivo", 0);
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbNombre.Text = dr["Nombre"].ToString();
                    txtbAPaterno.Text = dr["Apellidopaterno"].ToString();
                    txtbAMaterno.Text = dr["Apellidomaterno"].ToString();
                    txtbFechaNacimiento.Text = dr["Fec_Nac"].ToString();
                    txtbRfc.Text = dr["Rfc"].ToString();
                    cbCentroTrabajo.Text = dr["Centro"].ToString();
                    cbPuesto.Text = dr["Puesto"].ToString();
                    txtbDirectivo.Text = dr["Directivo"].ToString();
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
            if (txtbNumero.Text != String.Empty && txtbNombre.Text != String.Empty && txtbAPaterno.Text != String.Empty && txtbAMaterno.Text != String.Empty && txtbAMaterno.Text != String.Empty && txtbFechaNacimiento.Text != String.Empty && txtbRfc.Text != String.Empty && cbCentroTrabajo.Text != String.Empty && cbPuesto.Text != string.Empty && txtbDirectivo.Text != String.Empty)
            {
                cmd = new SqlCommand("Empleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleaddo", txtbNumero.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombre.Text);
                cmd.Parameters.AddWithValue("@Apellidopaterno", txtbAPaterno.Text);
                cmd.Parameters.AddWithValue("@Apellidomaerno", txtbAMaterno);
                cmd.Parameters.AddWithValue("@Fec_Nac", txtbFechaNacimiento.Text);
                cmd.Parameters.AddWithValue("@Rfc", txtbRfc.Text);
                cmd.Parameters.AddWithValue("@Centro", cbCentroTrabajo.Text);
                cmd.Parameters.AddWithValue("@Puesto", cbPuesto.Text);
                cmd.Parameters.AddWithValue("@Directivo", txtbDirectivo.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerEmpleados();
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

                    cmd = new SqlCommand("Empleados", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Empleaddo", txtbNumero.Text);
                    cmd.Parameters.AddWithValue("@Nombre", "");
                    cmd.Parameters.AddWithValue("@Apellidopaterno", "");
                    cmd.Parameters.AddWithValue("@Apellidomaterno", "");
                    cmd.Parameters.AddWithValue("@Fec_Nac", "");
                    cmd.Parameters.AddWithValue("@Rfc", "");
                    cmd.Parameters.AddWithValue("@Centro", 0);
                    cmd.Parameters.AddWithValue("@Puesto", "");
                    cmd.Parameters.AddWithValue("@Directivo", 0);
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerEmpleados();
                    txtbNumero.Text = "";
                    txtbNombre.Text = "";
                    txtbAPaterno.Text = "";
                    txtbAMaterno.Text = "";
                    txtbFechaNacimiento.Text = "";
                    txtbRfc.Text = "";
                    cbCentroTrabajo.Text = "";
                    cbPuesto.Text = "";
                    txtbDirectivo.Text = "";
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
