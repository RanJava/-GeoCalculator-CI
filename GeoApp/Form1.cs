namespace GeoApp;

public partial class Form1 : Form
{
    public Form1()
    {
        Button btnCirculo = new Button { Text = "Círculo", Location = new Point(50, 100) };
this.Controls.Add(btnCirculo);

btnCirculo.Click += (s, e) =>
{
    new FormCirculo().Show();
};
        InitializeComponent();
    }
}
