using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzIMDB.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string FilmAd { get; set; }
        public int? Puan { get; set; }  //BOŞ OMA DURUMU OLDUĞU ZAMAN İNT? YAZARIZ
        public Image Foto { get; set; }

        public override string ToString()
        {
            return FilmAd;
        }
    }
}
