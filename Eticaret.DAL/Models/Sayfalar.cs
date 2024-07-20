using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticaret.DAL.Models.Concrate;

namespace Eticaret.DAL.Models
{

    public class Sayfalar: BaseClass
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
      
        public string Icerik { get; set; }
        public DateTime DuzenlemeTarihi { get; set; }

    } 
}