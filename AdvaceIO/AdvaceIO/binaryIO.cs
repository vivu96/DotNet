using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdvaceIO
{
    internal class binaryIO
    {
        public static void Main(string[] args)
        {
            BinaryReader br;
            BinaryWriter bw;
            int i = 75;
            double d = 45.54;
            bool b = true;
            string str = "vivek ";
            try
            {
                bw = new BinaryWriter(new FileStream("fileData", FileMode.Create));
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Opps it seems some error");
                return;
            }
            //writing into file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Cannot write into file");
                return;
            }
            bw.Close();
            try
            {
                br = new BinaryReader(new FileStream("FileData", FileMode.Open));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Cannot Read into file");
            }

            try
            {
                //i = br.ReadInt32();
                //Console.WriteLine("inter data : " + i);
                i = br.ReadInt32();
                Console.WriteLine("Interger data : " + i);
                d = br.ReadDouble();
                Console.WriteLine("Double data : " + d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean Data : "+ b);
                str = br.ReadString();
                Console.WriteLine("String Data : "+ str);
            }
            catch(Exception e)
            {
                Console.WriteLine("throughing some error....");
                return;
            }
            br.Close();

            Console.ReadKey();
        }
    }
}
