using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(5,ErrorMessage = "KC")]
        [Required(ErrorMessage = "Поле login не может быть пустым")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Поле email не может быть пустым")]
        public string Email { get; set; }
        [StringLength(5,ErrorMessage = "KC")]
        [Required(ErrorMessage = "Поле Password не может быть пустым")]
        public string Password { get; set; }
    }
}