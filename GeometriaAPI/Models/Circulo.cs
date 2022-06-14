namespace GeometriaAPI.Models
{
    public class Circulo : Geometria, iGeometriaFormulas
    {
        public double CalcularArea(string[] m)
        {
            double raio;
            double pi = 3.14;
            
            try
            {
                raio = double.Parse(m[0]);
                
            }
            catch (System.Exception)
            {
                
                return -1;
            }
        
            return pi*(raio*raio);
        }

        public double CalcularPerimetro(string[] m)
        {
            double raio;
            double pi = 3.14;
            
            try
            {
                raio = double.Parse(m[0]);
                
            }
            catch (System.Exception)
            {
                
                return -1;
            }
        
            return 2*pi*raio;
        }

            
               
    }
}