namespace GeometriaAPI.Models
{
    public class Trapezio : Geometria, iGeometriaFormulas
    {
        public double CalcularArea(string[] m)
        {
            double baseMaior;
            double baseMenor;
            double alturav;
            try
            {
                baseMaior = double.Parse(m[0]);
                baseMenor = double.Parse(m[1]);
                alturav = double.Parse(m[2]);
            }
            catch (System.Exception)
            {
                
                return -1;
            }
        
            return ((baseMaior + baseMenor)*alturav)/2;
        }

        public double CalcularPerimetro(string[] m)
        {
            double lado1;
            double lado2;
            double basemenorr;
            double basemaiorr;

            try
            {
                basemaiorr = double.Parse(m[0]);
                basemenorr = double.Parse(m[1]);
                lado1 = double.Parse(m[2]);
                lado2 = double.Parse(m[3]);
            }
            catch (System.Exception)
            {
                
                return -1;
            }
        
            return (lado1+lado2+basemaiorr+basemenorr);
        }
        
    }
}