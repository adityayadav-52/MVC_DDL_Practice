using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DDL.Models
{
    public class State
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public int CId { get; set; }
    }
}