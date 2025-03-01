namespace Parcial.Models
{
    public class Dado
    {
        private static readonly Random aleatorio = new Random();

        public int Lanzar()
        {
            return aleatorio.Next(1, 7);
        }
    }
}
