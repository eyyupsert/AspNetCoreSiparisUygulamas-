﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon.Models
{
    public class KategoriGuncelleModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
        public string Ad { get; set; }
    }
}
