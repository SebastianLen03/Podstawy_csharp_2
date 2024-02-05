using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class ExcelFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing ExcelFile");
        }
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report...");
        }

    }
}
