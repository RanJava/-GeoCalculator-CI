using System; 
 
namespace GeoApp.Models 
{ 
    public static class Calculadora 
    { 
        //Rectangulo
        public static double AreaRectangulo(double baseR, double altura) => baseR * altura; 

        //Circulo
        public static double AreaCirculo(double radio) => Math.PI * Math.Pow(radio, 2);
        //Triangulo
        public static double AreaTriangulo(double baseT, double altura) => (baseT * altura) / 2; 
        
    } 
} 