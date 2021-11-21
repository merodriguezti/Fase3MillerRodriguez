using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3MillerRodriguez
{
    public partial class FrmAcceso : Form
    {
        
        public FrmAcceso()
        {
            InitializeComponent();
        }

        //METODO PARA CARGAR EL FORMULARIO
        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
        }

        //METODO PARA ESPECIFICAR LA CONTRASEÑA
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals("123"))
            {
                FrmOpciones opciones = new FrmOpciones();
                opciones.Show();
                this.Hide();
            }

            else
            {
                btnEntrar.Enabled = false;
                txtContrasena.Text = "";
                txtContrasena.Focus();
                MessageBox.Show("Contraseña Incorrecta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void controlBotones()
        {
            if (txtContrasena.Text.Trim() != String.Empty && txtContrasena.Text.All(char.IsDigit))
            {
                btnEntrar.Enabled = true;
                epContrasena.SetError(txtContrasena, "");
            }

            else
            {
                if (txtContrasena.Text.Equals(""))
                {
                    epContrasena.SetError(txtContrasena, "Debe ingresar una Contraseña");
                }
                else if (txtContrasena.Text.All(char.IsLetter))
                {
                    epContrasena.SetError(txtContrasena, "la Contraseña es Incorrecta");
                }

                btnEntrar.Enabled = false;
                txtContrasena.Focus();
            }
        }

        //METODO DE LAS ACCIONES DEL TEXBOX
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
