namespace GeoApp;

public partial class Form1 : Form
{
    
    // Dentro de Form1.cs
public Form1()
{
    // ... código que ya tengas ...
    InitializeComponent();
    Button btnIrATriangulo = new Button();
    btnIrATriangulo.Text = "Area Triángulo";
    btnIrATriangulo.AutoSize = true;
    btnIrATriangulo.Location = new System.Drawing.Point(250, 60); 
    btnIrATriangulo.Click += (s, e) => {
        FormTriangulo f = new FormTriangulo();
        f.ShowDialog();
    };
    this.Controls.Add(btnIrATriangulo);
}
}
