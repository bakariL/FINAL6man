using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TV5.Models
{
    public class VideoPlayer
    {
        [Key]
        public int VideoID { get; set; }
    }
}