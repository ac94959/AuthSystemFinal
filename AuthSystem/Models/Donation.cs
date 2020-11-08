using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AuthSystem.Models
{
    public class Donation
    {
        //stores data for donation page
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [Display(Name = "Name: ")] 
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email:")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Phone Number")]
        [Display(Name = "PhoneNumber:")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please Enter Address")]
        [Display(Name = "Address:")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Please Enter Suburb")]
        [Display(Name = "Suburb:")]
        public string Suburb { get; set; }


        [Required(ErrorMessage = "Pleae Enter City")]
        [Display(Name = "City:")]
        public string City { get; set; }


        [Required(ErrorMessage = "Please Enter Post Code")]
        [Display(Name = "PostCode:")]
        public string PostCode { get; set; }


        [Required(ErrorMessage = "Please Enter Donation Amount")]
        [Display(Name = "DonationAmount:")]
        public string DonationAmount { get; set; }

        [Required(ErrorMessage = "Please Enter CardNumber")]
        [Display(Name = "CardNumber:")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Please Enter CVV")]
        [Display(Name = "CVV:")]
        public string CVV { get; set; }


        [Required(ErrorMessage = "Please Enter ExpirationDate")]
        [Display(Name = "ExpirationDate:")]
        public string ExpirationDate { get; set; }
        
    } 
}
