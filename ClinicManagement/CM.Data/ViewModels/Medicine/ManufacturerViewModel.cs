﻿using System.ComponentModel.DataAnnotations;

namespace CM.Data.ViewModels.Medicine
{
    public class ManufacturerViewModel : BaseViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This Field is requiered")]
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }
    }
}
