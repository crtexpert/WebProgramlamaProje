using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Classes
{
    public class Kullanici
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage ="İsim alanı boş bırakılamaz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim alanı boş bırakılamaz.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage ="Doğru formatta mail adresi giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcıadı alanı boş bırakılamaz.")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}