using Xunit; 
using GeoApp.Models; 

public class UnitTest1 
{ 
    [Fact] 
    public void TestAreaRectangulo() 
    { 
        double resultado = Calculadora.AreaRectangulo(10, 5); 
        Assert.Equal(50, resultado); 
    } 

    [Fact] 
    public void TestAreaCirculo() 
    { 
        double resultado = Calculadora.AreaCirculo(7); 
        Assert.Equal(Math.PI * 49, resultado); 
    } 

    [Fact] 
    public void TestAreaTriangulo() 
    { 
        double resultado = Calculadora.AreaTriangulo(10, 5); 
        Assert.Equal(25, resultado); 
    } 
}