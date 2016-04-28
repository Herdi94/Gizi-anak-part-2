using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiziUntukAnak.Models
{
    public class Gizi
    {
        public string Judul
        {
            get;
            set;
        }
        public string Sub
        {
            get;
            set;
        }

        public string Image
        {
            get;
            set;
        }
    }

    public class GiziManager
    {
        public static List<Gizi> GetGizi2()
        {
            var gizi2 = new List<Gizi>();
            gizi2.Add(new Gizi
            {
                Judul = "Gizi Seimbang",
                Sub = "untuk usia 0 - 2 tahun",
                Image = "Assets/anakUmur2.png"
            });
            gizi2.Add(new Gizi
            {
                Judul = "Gizi Seimbang",
                Sub = "untuk usia 3 - 5 tahun",
                Image = "Assets/anakUmur5.png"
            });

            gizi2.Add(new Gizi
            {
                Judul = "Gizi Seimbang",
                Sub = "untuk usia 6 - 9 tahun",
                Image = "Assets/anakUmur9.png"
            });
            return gizi2;
        }
    }
}