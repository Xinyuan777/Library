using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace onlinestore.Models
{
    public class MessageData_Cs
    {

        public int No_P { get; set; }
        [Required]
        public string UserID_From_P { get; set; }
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9\._%+-]+@[a-zA-Z0-9\.-]+\.([a-z]{2}|com|org|net|edu|gov|mil|biz|info|mobi|name|aero|asia|jobs|museum)$")]
        public string Email_P { get; set; }
        [Required]
        public string Content_P { get; set; }
        [Required]
        public bool IsSecret_P { get; set; }
        [Required]
        public string JoinTime_P { get; set; }
    }
}