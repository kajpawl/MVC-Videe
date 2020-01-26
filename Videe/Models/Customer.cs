using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videe.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(235)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershiTypeId { get; set; }
    }
}