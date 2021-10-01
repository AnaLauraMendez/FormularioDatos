using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        public void BtGuardar_Click(object sender, EventArgs e)
        {

            ///Validacion de campo vacio
            if (TxtNombre.Text == String.Empty)
                LblOblig1.Text = "*Campo obligatorio";

            if (TxtApellido.Text == String.Empty)
                LblOblig2.Text = "*Campo obligatorio";

            ///Aca deberia mostrar un mensaje que diga contacto guardado


          if (TxtNombre.Text != String.Empty)
            mostrarConfirmacion();

         

        }
        public void mostrarConfirmacion() {
            ///Aca deberia mostrar un mensaje que diga contacto guardado
            DialogResult C = MessageBox.Show("Registro exitoso", "Confirmación", MessageBoxButtons.OK);
            if (C == DialogResult.OK)
                this.Close();


        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            //Cancelar formulario con mensaje de confirmacion
            DialogResult M= MessageBox.Show("¿Desea salir del registro?","Atención", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (M == DialogResult.OK)
                this.Close();

        }   

       private void Fecha_ValueChanged(object sender, EventArgs e)
        {

            ///Aca muestro lo que selecciono el usuario
            DateTime dt = this.Fecha.Value.Date;
            Confirmacion.Text= "Esta por registrar \r\n"+ "Fecha de nacimiento: " + dt.ToShortDateString() + "\r\nUsuario: " + TxtNombre.Text.ToString() + " " +
            TxtApellido.Text.ToString();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {  ///Validar vacios









            ///-------------------------------------
           /// do
            //{
             ///   LblOblig1.Text = "*Campo obligatorio";
            ///}
           /// while (TxtNombre.Text == String.Empty);
              //7  LblOblig1.Text = "*Campo obligatorio";
         
            ///while (TxtApellido.Text == String.Empty)
               /// LblOblig2.Text = "*Campo Obligatorio";
        }

        private void LblOblig1_VisibleChanged(object sender, EventArgs e)
        {
           /// if (TxtNombre.Text == String.Empty)
              ///  LblOblig1.Visible=true;
        }

        private void LblOblig2_VisibleChanged(object sender, EventArgs e)
        {
            ///if (TxtNombre.Text == String.Empty)
               /// LblOblig2.Visible = true;
        }








    }




}
