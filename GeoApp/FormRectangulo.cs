// Archivo: FormRectangulo.cs 
using System; 
using System.Drawing; 
using System.Windows.Forms; 
using GeoApp.Models; 
 
namespace GeoApp 
{ 
    public partial class FormRectangulo : Form 
    { 
        private TextBox txtBase = new TextBox { Location = new Point(100, 20), Size = new Size(150, 25) }; 
        private TextBox txtAltura = new TextBox { Location = new Point(100, 60), Size = new Size(150, 25) }; 
        private Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 100), Size = new Size(90, 30) }; 
 
        public FormRectangulo() 
        { 
            this.Size = new Size(320, 200);
            this.Controls.Add(new Label { Text = "Base:", Location = new Point(20, 23), AutoSize = true }); 
            this.Controls.Add(txtBase); 
            this.Controls.Add(new Label { Text = "Altura:", Location = new Point(20, 63), AutoSize = true }); 
            this.Controls.Add(txtAltura); 
            this.Controls.Add(btnCalcular); 
            btnCalcular.Click += (s, e) => { 
                double res = Calculadora.AreaRectangulo(double.Parse(txtBase.Text), 
                double.Parse(txtAltura.Text)); 
                MessageBox.Show("El área es: " + res); 
            }; 
        } 
    } 
}