namespace GeometriaAPI.Models
{
    public class Triangulo : Geometria, iGeometriaFormulas
    {
        public double CalcularArea(string[] m)
        {
            double basev;
            double alturav;
            try
            {
                basev = double.Parse(m[0]);
                alturav = double.Parse(m[1]);
            }
            catch (System.Exception)
            {
                
                return -1;
            }
        
            return (basev*alturav)/2;
        }

        public double CalcularPerimetro(string[] m)
        {
            double lado1;
            double lado2;
            double lado3;
            try
            {
                lado1 = double.Parse(m[0]);
                lado2 = double.Parse(m[1]);
                lado3 = double.Parse(m[2]);
            }
            catch (System.Exception)
            {
                
                return -1;
            }
        
            return lado1+lado2+lado3;
        }
    }
        
    
}