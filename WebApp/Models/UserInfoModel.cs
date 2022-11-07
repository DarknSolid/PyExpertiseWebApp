using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserInfoModel
    {
            [Required]
            [MinLength(1)]
            public string Username { get; set; }

            public bool IsItu { get; set; }
    }
}
