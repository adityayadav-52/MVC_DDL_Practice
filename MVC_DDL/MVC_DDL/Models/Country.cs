using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DDL.Models
{
    public class Country
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
    }
}