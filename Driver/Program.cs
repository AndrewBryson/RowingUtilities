using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RowingUtilities;
using System.IO;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {            
            HeadEventDraw draw = new HeadEventDraw();
            draw.LoadFromFile("crewexport.csv");
            
            // Sort the draw.
            draw.SortDraw();

            // Save it out to a new file.
            draw.SaveToFile(@"saved.csv");

            // Or save it somewhere via a Stream by getting the draw as a string?
            //using (FileStream fsOut = new FileStream(@"d:\String-saved.csv", FileMode.Create, FileAccess.Write))
            //{   
            //    using (StreamWriter sw = new StreamWriter(fsOut))
            //    {
            //        sw.Write(draw.GetAsString());
            //    }
            //}

            //// Or save it somewhere via a Stream?
            //using (FileStream fsOut = new FileStream(@"d:\Stream-saved.csv", FileMode.Create, FileAccess.Write))
            //{
            //    using (StreamWriter sw = new StreamWriter(fsOut))
            //    {
            //        draw.SaveToStream(sw);
            //    }
            //}
        }
    }
}
