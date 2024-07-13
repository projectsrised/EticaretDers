using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.DAL.Models
{
    public class Makale
    {
        public int Id { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public string? Icerik { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        public string? Yazar { get; set; }


    }
}
