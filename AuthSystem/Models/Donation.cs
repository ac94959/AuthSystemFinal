using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class Donation
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name :")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name :")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email :")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter Phone Number")]
        [Display(Name = "PhoneNumber :")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = "Address :")]

        public string Suburb { get; set; }
        [Required(ErrorMessage = "Enter Suburb")]
        [Display(Name = "Suburb :")]

        public string City { get; set; }
        [Required(ErrorMessage = "Enter City")]
        [Display(Name = "City :")]

        public string PostCode { get; set; }
        [Required(ErrorMessage = "Enter Post Code")]
        [Display(Name = "PostCode :")]

        public string DonationAmount { get; set; }
        [Required(ErrorMessage = "Enter Donation Amount")]
        [Display(Name = "DonationAmount :")]

        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Enter CardNumber")]
        [Display(Name = "CaardNumber :")]

        public string CVV { get; set; }
        [Required(ErrorMessage = "Enter CVV")]
        [Display(Name = "CVV :")]

        public string ExpirationDate { get; set; }
        [Required(ErrorMessage = "Enter ExpirationDate")]
        [Display(Name = "ExpirationDate :")]

    }
}