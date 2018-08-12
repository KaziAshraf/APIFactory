using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleModel sample = new SampleModel();
            sample = APIFactory<SampleModel>.GetJSONData("https://jsonplaceholder.typicode.com/todos/3");
            Console.WriteLine(sample.title);
        }
    }
}
