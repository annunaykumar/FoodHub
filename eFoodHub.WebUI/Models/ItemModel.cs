using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eFoodHub.WebUI.Models
{
    public class ItemModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Name")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Please enter the valid Name")]

        public string Name { get; set; }

        public IFormFile File { get; set; }


        [Required(ErrorMessage = "Please Enter Description")]

        public string Description { get; set; }


        [Required(ErrorMessage = "Please Enter UnitPrice")]
        [RegularExpression(@"^(?!(?:0|0\.0|0\.00)$)[+]?\d+(\.\d|\.\d[0-9])?$", ErrorMessage = "Please enter valid price")]

        public decimal UnitPrice { get; set; }

        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Please Select Category")]

        public int CategoryId { get; set; }


        [Required(ErrorMessage = "Please Select Item")]

        public int ItemTypeId { get; set; }

    }
}
