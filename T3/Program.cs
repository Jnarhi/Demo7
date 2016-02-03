using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TVshow> tvshow = new List<TVshow>();

            tvshow.Add(new TVshow { Name = "Quantico", Channel = "Nelonen", Info = "Amerikkalainen jännitysdraama", Time = "21:00-22:00", });
            tvshow.Add(new TVshow { Name = "Myytinmurtajat", Channel = "Sub", Info = "Adam ja Jamie", Time = "21:00-22:00" });
            tvshow.Add(new TVshow { Name = "Family Guy", Channel = "FOX", Info = "Amerikkalainen animaatiosarja", Time = "17:05-17.35" });
            tvshow.Add(new TVshow { Name = "Simpsonit", Channel = "Sub", Info = "Amerikkalainen animaatiosarja", Time = "20:00-20:30" });


            StreamWriter outputFile = null;
            try
            {
                outputFile = new StreamWriter("tvlista.txt");
                foreach (TVshow show in tvshow)
                {
                    outputFile.WriteLine(tvshow.ToString());
                }


            }
           
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
          
        }
    }
      
}
