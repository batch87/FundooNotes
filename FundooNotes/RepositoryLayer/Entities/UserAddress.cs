﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryLayer.Entities
{
    public class UserAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int AddressId { get; set; }
        [ForeignKey("User")]
        public int? Userid { get; set; }
        [Required]
        public string Type { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        
        public string City { get; set; }
        [Required]
       
        public string State { get; set; }

        

        public virtual User User { get; set; }


    }
}
