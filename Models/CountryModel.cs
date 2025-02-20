using System.ComponentModel.DataAnnotations;

namespace AdressBook.Models;

public class CountryModel
{
    // public int CountryId { get; set; }
    // public string CountryName { get; set; }
    // public string CountryCode { get; set; }
    // public DateTime CreationDate { get; set; }
    // public int UserId { get; set; }
    
    public int CountryId { get; set; }

    [Required(ErrorMessage = "Country name is required")]
    [Display(Name = "Country Name")]
    public string CountryName { get; set; }

    [Required(ErrorMessage = "Country code is required")]
    [Display(Name = "Country Code")]
    public string CountryCode { get; set; }

    [Display(Name = "Created On")]
    public DateTime CreationDate { get; set; }

    public int UserId { get; set; }
}