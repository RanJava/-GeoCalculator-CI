using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models; 

namespace GeoApp
{
    public partial class FormTriangulo : Form
    {
        private TextBox txtBase = new TextBox { Location = new Point(100, 20), Size = new Size(150, 25) };
        private TextBox txtAltura = new TextBox { Location = new Point(100, 60), Size = new Size(150, 25) };
        private Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 100), Size = new Size(90, 30) };

        public FormTriangulo()
        {
            this.Text = "Cálculo de Triángulo";
            this.Size = new Size(320, 200);

            this.Controls.Add(new Label { Text = "Base:", Location = new Point(20, 23), AutoSize = true });
            this.Controls.Add(txtBase);
            this.Controls.Add(new Label { Text = "Altura:", Location = new Point(20, 63), AutoSize = true });
            this.Controls.Add(txtAltura);
            this.Controls.Add(btnCalcular);

            btnCalcular.Click += (sender, e) => {
                try {
                    double b = double.Parse(txtBase.Text);
                    double h = double.Parse(txtAltura.Text);
                    double res = Calculadora.AreaTriangulo(b, h);
                    MessageBox.Show("El área es: " + res);
                } catch {
                    MessageBox.Show("Ingresa números válidos");
                }
            };
        }
    }
}