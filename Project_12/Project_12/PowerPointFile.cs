using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12
{
    internal class PowerPointFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compresing PowerPoint file");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting...");
        }
    }
}
