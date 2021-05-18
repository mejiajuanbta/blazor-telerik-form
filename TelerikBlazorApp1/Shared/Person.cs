using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikBlazorApp1.Shared {
    public class Person {

        public Person() {
            FavoriteSports = new List<string>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your first name")]
        [StringLength(10, ErrorMessage = "That name is too long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [StringLength(15, ErrorMessage = "That name is too long")]
        public string LastName { get; set; }

        //[RegularExpression("[0-2]{1}.[0-9]{3}.[0-9]{3}.[0-9]{4}", 
        //    ErrorMessage = "Enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "An email is required")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }

        public int? Gender { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/1930", "1/12/2020",
            ErrorMessage = "Value for {0} must be between {1:dd MMM yyyy} and {2:dd MMM yyyy}")]
        public DateTime Birthday { get; set; }

        public decimal AnnualSalary { get; set; }

        public List<string> FavoriteSports { get; set; }

        public string Comments { get; set; }

        public int Country { get; set; }

        public string CountryName =>
            SupportData.Countries.SingleOrDefault(c => c.Id == Country)?.Text ?? "";

        public string GenderName =>
            SupportData.Genders.SingleOrDefault(c => c.GenderId == Gender)?.GenderText ?? "";

        public string UserName { get; set; }
        public string Password { get; set; }
        public string CountryForShipments { get; set; }

        public List<int> PreferedCountries { get; set; }
    }

    public class GenderModel {
        public int GenderId { get; set; }
        public string GenderText { get; set; }
    }
}