using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    class LoadCursor
    {
        public void CreateCursor()
        {
            Byte[] buffer = Resource.Cursor;
            FileStream temp = new FileStream("temp.cur", FileMode.Create);
            
            temp.Write(buffer, 0, buffer.Length);
            temp.Close();
        }

        ~ LoadCursor()
        {
            try
            {
                if (File.Exists("temp.cur"))
                {
                    File.Delete("temp.cur");
                }
            }
            catch
            {
                Console.WriteLine("Delete File ERROR!");
            }
        }
    }
}
