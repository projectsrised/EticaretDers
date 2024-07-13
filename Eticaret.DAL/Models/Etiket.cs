using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticaret.DAL.Models.Concrate;

namespace Eticaret.DAL.Models
{
    public class Etiket:BaseClass
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public virtual List<Makale>? Makales { get; set; }
    }
}
