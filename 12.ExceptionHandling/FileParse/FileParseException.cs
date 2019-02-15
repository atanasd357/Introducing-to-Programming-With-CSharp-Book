using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParse
{
    class FileParseException : Exception
    {
        public FileParseException(string fileName, int exceptionLine)
            : base(String.Format("Error! Can't parse to int line {1} in file: \"{0}\".", fileName, exceptionLine))
        {

        }
    }
}
