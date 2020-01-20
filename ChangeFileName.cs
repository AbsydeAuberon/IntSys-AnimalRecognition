using System;
using System.IO;

namespace ChangeFileName
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(@"C:\Users\auber\Desktop\MACHINELEARNING\Rooms");
                int i = 1;

                foreach (var file in d.GetFiles())
                {
                    Directory.Move(file.FullName, @"C:\Users\auber\Desktop\MACHINELEARNING\Rooms\" + "Room_" + i.ToString() + ".jpg");
                    i++;
                }

                Console.WriteLine("Satisfactory rename of the files.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
