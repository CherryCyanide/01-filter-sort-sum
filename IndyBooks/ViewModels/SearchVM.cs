using System;
using System.ComponentModel.DataAnnotations;
namespace IndyBooks.ViewModels
{
    public class SearchVM
    {
        [Display(Name = "Title to Find: ")]
        public String Title { get; set; } = "";

        [Display(Name = "Half-Price Sale: ")]
        public Boolean HalfPriceSale { get; set; }
        //DONE: Add properties with Display annotation needed for searching
        
        [Display(Name = "Author's Last Name: " )]
        public String Author {get; set;} = "";

        [Display(Name = "Minimum Price: ")]
        public decimal MinPrice {get; set;} 

        [Display(Name = "Maximum Price: ")]
        public decimal MaxPrice {get; set;} 
    }
}
