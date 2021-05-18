using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikBlazorApp1.Shared {
    public class SupportData {
        public enum GenderType: byte {
            Female = 1,
            Male
        }

        public static IEnumerable<GenderModel> Genders = new List<GenderModel> {
            new GenderModel {GenderText = "Female", GenderId = 1},
            new GenderModel {GenderText = "Male", GenderId = 2}
        };

        public static IEnumerable<string> Sports = new List<string> {
            "Baseball",
            "Basketball",
            "Tennis",
            "Golf",
            "Cricket",
            "Hockey",
            "Volleyball"
        };

        public static IEnumerable<DropDownModel> Countries = new List<DropDownModel> {
            new DropDownModel {Text = "Brazil", Id = 1},
            new DropDownModel {Text = "Canada", Id = 2},
            new DropDownModel {Text = "Dominican Republic", Id = 3},
            new DropDownModel {Text = "United States", Id = 4}
        };

        public static List<string> CountriesNames => Countries.Select(c => c.Text).ToList();
    }
}
