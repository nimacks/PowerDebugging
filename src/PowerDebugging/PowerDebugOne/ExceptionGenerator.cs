using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDebugOne
{
    /// <summary>
    /// Generates a set of pre-defined Exceptions
    /// </summary>
    public static class ExceptionGenerator
    {

        /// <summary>
        /// Generates a File Not Found Exception by attempting to open a non-existent File
        /// </summary>
        public static void GenerateFileNotFoundException()
        {
            try
            {
                var openFile = File.OpenRead(@"C:\non-existentFile.txt");
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Throws Divide by Zero Exception
        /// </summary>
        public static void GenerateDivideByZeroException()
        {
            try
            {
                int y = 0;
                int b = 1;
                int z = b / y;
            }
            catch (DivideByZeroException)
            {

                throw;
            }
        }
    }
}
