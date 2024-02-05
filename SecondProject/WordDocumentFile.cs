using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    
    internal class WordDocumentFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing WordDocumentFile");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing...");
        }
    }
}
