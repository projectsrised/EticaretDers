using Eticaret.DAL.Models.Concrate;

namespace Eticaret.DAL.Models
{
    public class Kategori:BaseClass
    {
        
        public int Id { get; set; }
        public string Adi { get; set; }

        public virtual List<Makale>? Makales { get; set; }
    }
}