﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace AllupMVC.Models
{
    public class Slide:BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
