using Eticaret.DAL.Models.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.DAL.Models
{
    public class Makale:BaseClass
    {
        public int Id { get; set; }
        public int? KategoriId { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public string? Icerik { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        public string? Yazar { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
        public virtual List<Etiket>? Etikets { get; set;}
    }
}
