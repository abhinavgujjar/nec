using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            //logs to file
            using (TextWriter tw = new StreamWriter(@"d:\log.txt"))
            {
                tw.WriteLine(message);  
            }
            
        }
    }
}
