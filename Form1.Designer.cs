
namespace FormularioDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Confirmacion = new System.Windows.Forms.Label();
            this.LblOblig1 = new System.Windows.Forms.Label();
            this.LblOblig2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 59);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 99);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Apellido";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(19, 75);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(20, 115);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 3;
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(44, 255);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtGuardar.TabIndex = 4;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(146, 255);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 5;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 13);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(147, 17);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Bienvenido usuario";
            // 
            // Fecha
            // 
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(20, 165);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(104, 20);
            this.Fecha.TabIndex = 7;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(17, 149);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Fecha de nacimiento";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 30);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(153, 13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Ingrese sus datos en el registro";
            // 
            // Confirmacion
            // 
            this.Confirmacion.AutoSize = true;
            this.Confirmacion.Location = new System.Drawing.Point(17, 203);
            this.Confirmacion.Name = "Confirmacion";
            this.Confirmacion.Size = new System.Drawing.Size(35, 13);
            this.Confirmacion.TabIndex = 10;
            this.Confirmacion.Text = "label6";
            // 
            // LblOblig1
            // 
            this.LblOblig1.AutoSize = true;
            this.LblOblig1.BackColor = System.Drawing.SystemColors.Control;
            this.LblOblig1.ForeColor = System.Drawing.Color.Red;
            this.LblOblig1.Location = new System.Drawing.Point(125, 78);
            this.LblOblig1.Name = "LblOblig1";
            this.LblOblig1.Size = new System.Drawing.Size(35, 13);
            this.LblOblig1.TabIndex = 11;
            this.LblOblig1.Text = "label6";
            this.LblOblig1.VisibleChanged += new System.EventHandler(this.LblOblig1_VisibleChanged);
            // 
            // LblOblig2
            // 
            this.LblOblig2.AutoSize = true;
            this.LblOblig2.ForeColor = System.Drawing.Color.Red;
            this.LblOblig2.Location = new System.Drawing.Point(126, 118);
            this.LblOblig2.Name = "LblOblig2";
            this.LblOblig2.Size = new System.Drawing.Size(35, 13);
            this.LblOblig2.TabIndex = 12;
            this.LblOblig2.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 305);
            this.Controls.Add(this.LblOblig2);
            this.Controls.Add(this.LblOblig1);
            this.Controls.Add(this.Confirmacion);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Formulario de Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Confirmacion;
        private System.Windows.Forms.Label LblOblig1;
        private System.Windows.Forms.Label LblOblig2;
    }
}

