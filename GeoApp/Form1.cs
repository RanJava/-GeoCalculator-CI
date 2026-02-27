// Archivo: FormMenu.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class Form1 : Form
    {
        private Button btnRectangulo = new Button { Text = "Rectángulo", Location = new Point(80, 20), Size = new Size(150, 35) };
        private Button btnCirculo = new Button { Text = "Círculo", Location = new Point(80, 70), Size = new Size(150, 35) };
        private Button btnTriangulo = new Button { Text = "Triángulo", Location = new Point(80, 120), Size = new Size(150, 35) };

        public Form1()
        {
            this.Text = "GeoCalculator - Menú";
            this.Size = new Size(320, 230);

            this.Controls.Add(btnRectangulo);
            this.Controls.Add(btnCirculo);
            this.Controls.Add(btnTriangulo);

            btnRectangulo.Click += (s, e) => new FormRectangulo().ShowDialog();
            btnCirculo.Click += (s, e) => new FormCirculo().ShowDialog();
            // btnTriangulo.Click += (s, e) => new FormTriangulo().ShowDialog();
        }
    }
}