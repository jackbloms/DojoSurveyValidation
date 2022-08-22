using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models;
#pragma warning disable CS8618
public class Survey
{
    [Required(ErrorMessage = "Username is required")]
    [MinLength(2, ErrorMessage = "Username must be at least 2 chars long")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Location is required")]
    public string Location { get; set; }

    [Required(ErrorMessage = "Favorite Language is required")]
    public string FavLanguage { get; set; }

    [MinLength(10, ErrorMessage = "Comment must be at least 10 chars long")]
    public string? Comment { get; set; }
}

