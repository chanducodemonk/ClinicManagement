﻿using System.ComponentModel.DataAnnotations;

namespace CM.Data.ViewModels.Medicine
{
    public class CategoryViewModel : BaseViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This Field is requiered")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
