﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12
{
    internal class ExcelFile : File
    {        
        public void GenerateReport()
        {
            // error string prop = PrivateProp;
            string prop = ProtectedProp;
            Console.WriteLine($"{FileName} report...");
        }
    }
}