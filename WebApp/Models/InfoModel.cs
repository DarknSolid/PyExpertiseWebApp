using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class InfoModel
    {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [Url(ErrorMessage = "Invalid url")]
            public IList<string> Urls { get; set; }
    }
}
