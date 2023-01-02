using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProgramlamaProje.Models.Classes
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        [Required(ErrorMessage = "Yorum alanı boş bırakılamaz.")]
        public string Mesaj { get; set; }        
        public int PostID { get; set; }
        public int UserID { get; set; }

        
    }
}