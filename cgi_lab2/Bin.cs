using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgi_lab2
{
     internal class Bin
     {
          public static int X, Y, Z;
          public short[] arr;
          public Bin() { }
          public void readBin(string path)
          {
               if (File.Exists(path))
               {
                    BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
                    X = reader.ReadInt32();
                    Y = reader.ReadInt32();
                    Z = reader.ReadInt32();

                    int arr_size = X * Y * Z;

                    arr = new short[arr_size];
                    for(int i = 0; i < arr_size; i++)
                    {
                         arr[i] = reader.ReadInt16();
                    }
               }
          }
     }
}
