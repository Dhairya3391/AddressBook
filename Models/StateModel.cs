using System.ComponentModel.DataAnnotations;

namespace AdressBook.Models;

// public class StateModel
// {
//     public int StateId { get; set; }
//     public int CountryId { get; set; }
//     public string StateName { get; set; }
//     public string StateCode { get; set; }
//     public DateTime CreationDate { get; set; }
//     public int UserId { get; set; }
// }

public class StateModel
{
    public required int StateId { get; set; }

    [Required(ErrorMessage = "Country is required")]
    [Display(Name = "Country")]
    public required int CountryId { get; set; }

    // [Required(ErrorMessage = "State name is required")]
    [Display(Name = "State Name")]
    public required  string StateName { get; set; }

    [Required(ErrorMessage = "State code is required")]
    [Display(Name = "State Code")]
    public required string StateCode { get; set; }

    [Display(Name = "Std Code")]
    public required string StdCode { get; set; }

    [Display(Name = "Pin Code")]
    public required string PinCode { get; set; }

    [Display(Name = "Created On")]
    public required DateTime CreationDate { get; set; }

    public required int UserId { get; set; }
}
