using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models;

namespace GeoApp
{
    public class FormCirculo : Form
    {
        private TextBox txtRadio = new TextBox { Location = new Point(100, 20), Size = new Size(150, 25) };
        private Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 60), Size = new Size(90, 30) };

        public FormCirculo()
        {
            this.Text = "Área del Círculo";
            this.Size = new Size(320, 160);

            this.Controls.Add(new Label { Text = "Radio:", Location = new Point(20, 23), AutoSize = true });
            this.Controls.Add(txtRadio);
            this.Controls.Add(btnCalcular);

            btnCalcular.Click += (s, e) =>
            {
                try
                {
                    double radio = double.Parse(txtRadio.Text);
                    double resultado = Calculadora.AreaCirculo(radio);
                    MessageBox.Show("El área es: " + resultado);
                }
                catch
                {
                    MessageBox.Show("Ingrese un número válido");
                }
            };
        }
    }
}