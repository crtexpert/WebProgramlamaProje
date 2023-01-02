using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProgramlamaProje.Models.Classes
{
    public class ViewModelDemo
    {
        public List<Anasayfa> tumAnasayfalar { get; set; }
        public List<Kullanici> tumKullanicilar { get; set; }
        public List<Yorum> tumYorumlar { get; set; }
    }

}