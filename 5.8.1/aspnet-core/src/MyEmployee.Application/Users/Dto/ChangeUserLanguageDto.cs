using System.ComponentModel.DataAnnotations;

namespace MyEmployee.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}