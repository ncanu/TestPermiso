using CapaDatos;
using InicioSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPermiso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string app = textBox2.Text;
            InicioSesion.Usuario inicioSesion = new InicioSesion.Usuario();
            Permiso p = inicioSesion.obtenerPermisos(Convert.ToInt32(user), Convert.ToInt32(app));
            String info = "";
            if (p != null)
            {
                info = info + "Aplicación: " + p.aplicacion + "   Borrar: " + p.borrar + "    Buscar: " + p.buscar + "    Consultar: " + p.buscar + "    Editar: " + p.buscar + "    Guardar: " + p.buscar + "    Imprimir: " + p.buscar + "    Ingresar: " + p.buscar + "\n";
                richTextBox1.Text = info;
            }
            else {
                richTextBox1.Text = "Usuario sin permios en modulo";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string app = textBox2.Text;



            InicioSesion.Usuario inicioSesion = new InicioSesion.Usuario();
            List<Permiso> perm = inicioSesion.obtenerPermisosList(Convert.ToInt32(user), Convert.ToInt32(app));

            if (perm.Count == 0)
            {
                richTextBox1.Text = "Usuario sin permios en modulo";
            }
            else
            {
                String info = "";
                foreach (Permiso x in perm)
                {
                    info = info + "Aplicación: "+ x.aplicacion + "   Borrar: " + x.borrar + "    Buscar: " + x.buscar + "    Consultar: " + x.buscar+ "    Editar: " + x.buscar + "    Guardar: " + x.buscar + "    Imprimir: " + x.buscar + "    Ingresar: " + x.buscar + "\n";
                }
                richTextBox1.Text = info;
            }
        }
    }
}
