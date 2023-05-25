using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prueba2
{
    public partial class Form1 : Form
    {

        public class CConexion
        {
            SqlConnection conex = new SqlConnection();
            static string servidor="127.0.0.1";
            static string db="Prueba";
            static string usuario="angel";
            static string password="1234";
            static string puerto="1433";

            string cadenaconexion = "Data Source="+servidor+","+puerto+";"+"user id="+usuario+";"+"password ="+password+";"+"Initial Catalog="+db+";"+"Persist Security Info=true";

            public SqlConnection establece()
            {
            try
            {
                conex.ConnectionString=cadenaconexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente");

            }catch(SqlException e){

            MessageBox.Show("No se logro la conexion"+ e.ToString());
            }
                return conex;

            }
            public void crearregistro(bool a, bool b, bool c, String d)
            {
                using (SqlConnection connection = new SqlConnection(cadenaconexion))
                {
                    String query = "INSERT INTO Sheet1$ (a,b,c,d) VALUES (@a,@b,@c, @d)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@a", a);
                        command.Parameters.AddWithValue("@b", b);
                        command.Parameters.AddWithValue("@c", c);
                        command.Parameters.AddWithValue("@d", d);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                    }
                }
            }

        }

        public CConexion conexion;
        public Form1()
        {
            InitializeComponent();
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            bool resultado = comparacion();
            label1.Text = resultado ? "Prendido" : "Apagado";
            Console.WriteLine(resultado);
            
        }

        private void a_CheckedChanged(object sender, EventArgs e)
        {
            bool resultado = comparacion();
            Console.WriteLine(resultado);
            label1.Text = resultado ? "Prendido" : "Apagado";
        }

        private void b_CheckedChanged(object sender, EventArgs e)
        {
            bool resultado = comparacion();
            Console.WriteLine(resultado);
            label1.Text = resultado ? "Prendido" : "Apagado";
        }

        private void c_CheckedChanged(object sender, EventArgs e)
        {
            bool resultado = comparacion();
            Console.WriteLine(resultado);
            label1.Text = resultado ? "Prendido" : "Apagado";
        }

        private bool comparacion()
        {
         bool ab = false;
         bool ac = false;
         bool abYac= false;
         conexion = new CConexion();
         
         
         if (!b.Checked)
         {
             ab = false;
         }
         if (b.Checked || (!a.Checked && !b.Checked))
         {
             ab = true;
         }
         if ((!a.Checked && !c.Checked) || (a.Checked && c.Checked))
         {
             ac = true;
         }
         abYac = ab && ac;
         conexion.crearregistro(a.Checked, b.Checked, c.Checked, abYac ? "Prendido" : "Apagado");
         return abYac;
        }

 
    }
}
