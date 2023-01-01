using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProgramlamaProje.Models.Classes
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        public string postResim { get; set; }
        public string postBaslik { get; set; }
        public string postTarih { get; set; }
        public string postIcerik { get; set; }
    }
}