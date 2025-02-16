using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{

    public class UserInfo {
        public int Id { get; set;}
        [Required(ErrorMessage = "Ad Alanı Zorunludur.")]
        public string? Name { get; set;}
        [Required(ErrorMessage ="Telefon Numaranızı Girin.")]
        public string? Phone { get; set;}
        [Required(ErrorMessage = "Hatalı Email")]
        [EmailAddress(ErrorMessage = "Hatalı Email")]
        public string? Email { get; set;}
        [Required(ErrorMessage ="Katılım Bilgisi Girin.")]
        public bool? WillAttend { get; set;}
    }
}

