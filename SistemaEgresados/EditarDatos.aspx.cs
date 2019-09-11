﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaEgresados
{
    public partial class EditarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDatos();
            }
            
        }

        SqlConnection conn = new SqlConnection("Data Source=SQL5045.site4now.net;Initial Catalog=DB_A4CEA1_graduadosmgp;User Id=DB_A4CEA1_graduadosmgp_admin;Password=graduados19;");

        public void cargarDatos()
        {
            SqlCommand cmd = new SqlCommand("obtieneDatos", conn);                     //usa el sp
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = Session["UserActual"];
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBoxNombre.Text = dr.GetValue(0).ToString();
                LabelSetCedula.Text = dr.GetValue(1).ToString();
                LabelSetCarnet.Text = dr.GetValue(2).ToString();
                genero.Text = dr.GetValue(3).ToString();
                TextBoxCorreo.Text = dr.GetValue(4).ToString();
                TextBoxTelefono.Text = dr.GetValue(5).ToString();
                TextBoxProvincia.Text = dr.GetValue(6).ToString();
                TextBoxDistrito.Text = dr.GetValue(7).ToString();
                TextBoxCanton.Text = dr.GetValue(8).ToString();
                TextBoxPais.Text = dr.GetValue(9).ToString();
            }

            dr.Close();
            conn.Close();
        }

        public void editarDatos(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("editarDatos", conn);                     //usa el sp
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cedula", SqlDbType.Float).Value = Convert.ToDecimal(Session["UserActual"]);
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBoxNombre.Text;
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero.Text;
            System.Diagnostics.Debug.WriteLine(genero.Text);
            cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = TextBoxCorreo.Text;
            cmd.Parameters.Add("@telCasa", SqlDbType.Float).Value = Convert.ToDecimal(TextBoxTelefono);           //He intentado de todo
            cmd.Parameters.Add("@provincia", SqlDbType.VarChar).Value = TextBoxProvincia.Text;                      //El problema es que no agarra lo que el user pone en el text box, sino lo que ser carga en el OnLoad
            cmd.Parameters.Add("@distrito", SqlDbType.VarChar).Value = TextBoxDistrito.Text;
            cmd.Parameters.Add("@canton", SqlDbType.VarChar).Value = TextBoxCanton.Text;
            cmd.Parameters.Add("@pais", SqlDbType.VarChar).Value = TextBoxPais.Text;

            try
            {
                conn.Open();
                Int32 rowsAffected = cmd.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine("RowsAffected: {0}", rowsAffected);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            conn.Close();
            Response.Redirect("EditarDatos.aspx");
        }
    }
}