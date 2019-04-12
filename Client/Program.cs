using System.Linq;

namespace Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var one = new One.BookServiceOneClient())
            using (var two = new Two.BookServiceTwoClient())
            {
                var rOne = one.GetAll();
                var rTwo = two.GetAll();
                var both = rOne.Concat(rTwo);
            }
        }
    }
}