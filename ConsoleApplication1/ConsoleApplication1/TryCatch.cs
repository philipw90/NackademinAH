using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TryCatch
    {
        public int ConvertStringToInt(string input)
        {
            try
            {
                var convertedString = int.Parse(input);
                return convertedString;
            }
            catch (Exception)
            {
                using (StreamWriter streamWriter = new StreamWriter(@"C:\Projects\felmeddelande\"))
                
            
                {
                    
                }
                throw;
            }
            
        }
    }
}
