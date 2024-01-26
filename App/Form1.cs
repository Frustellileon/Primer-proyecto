using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {

            //El que lee esto lo amo
            InitializeComponent();
            

        }

        public void HabilitarAceptar()
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != ""
            && txtDireccion.Text != "")
                btnAceptar.Enabled = true;
            else
                btnAceptar.Enabled = false;
        }



        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!");
             
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
           
            //HabilitarAceptar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            bool ban = true;
            string mensaje;

            if (txtApellido.Text.Equals(""))
                txtApellido.BackColor = Color.Coral;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Window;

            ////////////////////////////////////////
            
            if (txtNombre.Text.Equals(""))
                txtNombre.BackColor = Color.Coral;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Window;

            ////////////////////////////////////////


            if (txtEdad.Text.Equals(""))
                txtEdad.BackColor = Color.Coral;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Window;

            ////////////////////////////////////////
            

            if (txtDireccion.Text.Equals(""))
                txtDireccion.BackColor = Color.Coral;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;

            /////////////////////////////////////////


            if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtEdad.Text != ""
                && txtDireccion.Text != "")
            {
                MessageBox.Show("Se han cargado datos.", "Atencion");

                txtResultado.Text = txtNombre.Text + " " + txtApellido.Text + "\r\n" + txtEdad.Text + "\r\n" + txtDireccion.Text;
            }


            else
                MessageBox.Show("Complete todos los campos para confirmar:");
        } 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.Cursor = Cursors.Hand;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //HabilitarAceptar();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            //HabilitarAceptar();

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            //HabilitarAceptar();

        }

        //private void txtApellido_Validating(object sender, CancelEventArgs e)
        //{
          //  if (txtApellido.Text.Equals(""))
              //  txtApellido.BackColor = Color.Coral;
            //else
                //txtApellido.BackColor = System.Drawing.SystemColors.Window;

        //}

        private void DatosPersonales_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por su tiempo. Hasta luego!");
        }
    }
}
