using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospitales
{
    public partial class Pacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Paciente"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void BINGRESAR_Click(object sender, EventArgs e)
        {
            bool Seguro = false;
            string Distrito = "Distrito";
            if (RSEGUROSI.Checked)
                Seguro = true;
            else
                Seguro = false;

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO Paciente VALUES('" + TCedula.Text + "', '" + TNombre.Text + "'," + TEdad.Text + ", '" + DSexo.SelectedValue + "'," +
                " '" + DProvincia.SelectedValue + "', '" + DCanton.SelectedValue + "', '" + Distrito + "', " +
                " '" + TTelefono.Text + "', '" + Seguro + "'  )", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();

            TNombre.Text = "";
            TCedula.Text = "";
            TEdad.Text = "";
            DProvincia.SelectedValue = "";
            DCanton.SelectedValue = "";
            TTelefono.Text = "";
        }

        protected void BBORRAR_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("DELETE Paciente where cedula = '" + TCedula.Text + "'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
            TCedula.Text = "";
        }

        protected void BActualizar_Click(object sender, EventArgs e)
        {
            bool Seguro = false;

            if (RSEGUROSI.Checked)
                Seguro = true;
            else
                Seguro = false;

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE Paciente SET NOMBRE = '" + TNombre.Text + "', EDAD = " + TEdad.Text + "," +
                "SEXO = '" + DSexo.SelectedValue + "', PROVINCIA = '" + DProvincia.SelectedValue + "', DISTRITO =  '" + DDistrito.SelectedValue + "' , TELEFONO = '" + TTelefono.Text + "', Asegurado = '" + Seguro + "' WHERE cedula = '" + TCedula.Text + "'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
            TCedula.Text = "";
        }

        protected void BPromedioEdad_Click(object sender, EventArgs e)
        {
            float sumaedad = 0, promedio, contador = 0;


            String s = System.Configuration.ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select edad from Paciente ", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                sumaedad += int.Parse(registro["Edad"].ToString());
                contador = contador + 1;
            }

            promedio = sumaedad / contador;
            Label1.ForeColor = System.Drawing.Color.DarkGreen;
            Label1.Text = "El promedio de la edad es: " + promedio.ToString();

            conexion.Close();
        }

        protected void BCantidadmujeresyhombres_Click(object sender, EventArgs e)
        {
            int Mujeres = 0, Hombres = 0;
            float promediomujeres = 0, promediohombres = 0;
            int contador = 0;


            String s = System.Configuration.ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from Paciente", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                if (registro["Sexo"].ToString().Equals("F"))
                    Mujeres++;
                if (registro["Sexo"].ToString().Equals("M"))
                    Hombres++;
                contador++;
            }

            promediomujeres = (Mujeres * 100) / contador;
            promediohombres = (Hombres * 100) / contador;

            Label1.Text = "Cantidad de mujeres = " + Mujeres.ToString() +
                "Cantidad de Hombres = " + Hombres.ToString();
            Label2.Text = "% Mujeres = " + promediomujeres.ToString() + "% Hombres = " + promediohombres.ToString();
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["HOSPITALConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Paciente where nombre = '" + TNombre.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
    }
}
