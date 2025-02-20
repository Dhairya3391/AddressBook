using System.ComponentModel.DataAnnotations;

namespace AdressBook.Models;

// public class CityModel
// {
    // public int CityId { get; set; }
    // public int StateId { get; set; }
    // public int CountryId { get; set; }
    // public string CityName { get; set; }
    // public string StdCode { get; set; }
    // public string PinCode { get; set; }
    // public DateTime CreationDate { get; set; }
    // public int UserId { get; set; }
// }

public class CityModel
{
    public int CityId { get; set; }

    [Required(ErrorMessage = "Country is required")]
    [Display(Name = "Country")]
    public int CountryId { get; set; }

    [Required(ErrorMessage = "State is required")]
    [Display(Name = "State")]
    public int StateId { get; set; }

    [Required(ErrorMessage = "City name is required")]
    [Display(Name = "City Name")]
    public string CityName { get; set; }
    
    
}