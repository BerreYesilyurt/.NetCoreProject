﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string Tittle { get; set; }    
        public string ImageUrl { get; set; }    
    }
}
