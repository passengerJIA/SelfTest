using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelfTestWebMVCKendo.Models
{
    public class TestModel
    {
        [MaxLength(8)]
        public string Content { get; set; }
    }
}