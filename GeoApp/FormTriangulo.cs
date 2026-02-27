using System;
using System.Windows.Forms;
using GeoApp.Models; 
namespace GeoApp
{
    public partial class FormTriangulo : Form
    {
        private TextBox txtBase;
        private TextBox txtAltura;
        private Label lblResultado;

        public FormTriangulo()
        {
            this.Text = "Calculo de Triangulo ";
            this.Size = new System.Drawing.Size(300, 300);

            // Crear controles
            Label lblBase = new Label { Text = "Base:", Location = new System.Drawing.Point(20, 20) };
            txtBase = new TextBox { Location = new System.Drawing.Point(20, 45), Width = 100 };
            
            Label lblAlt = new Label { Text = "Altura:", Location = new System.Drawing.Point(20, 80) };
            txtAltura = new TextBox { Location = new System.Drawing.Point(20, 105), Width = 100 };

            Button btnCalcular = new Button { Text = "Calcular", Location = new System.Drawing.Point(20, 150) };
            lblResultado = new Label { Text = "Resultado: ", Location = new System.Drawing.Point(20, 190), Width = 200 };

            // Evento del botón
            btnCalcular.Click += (sender, e) => {
                try {
                    double b = double.Parse(txtBase.Text);
                    double h = double.Parse(txtAltura.Text);
                    double res = Calculadora.AreaTriangulo(b, h);
                    lblResultado.Text = $"Area: {res} u²";
                } catch {
                    MessageBox.Show("Ingresa números válidos");
                }
            };

            this.Controls.AddRange(new Control[] { lblBase, txtBase, lblAlt, txtAltura, btnCalcular, lblResultado });
        }
    }
}