using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12
{
    internal class WordDocumentFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compresing WordDocument file");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing...");
        }
    }
}
