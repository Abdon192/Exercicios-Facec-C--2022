
namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Informe um valor");
            
            decimal real,dolar,resultado;
            decimal.TryParse(Console.ReadLine(),out real);
            dolar = 0.1932m;
            resultado = real * dolar;

            Console.WriteLine("Resultado:"+resultado.ToString());
        }
    }
    
}
