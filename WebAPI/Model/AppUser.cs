using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class AppUser
    {
        //[Table("AppUser")]
        //public class User
        //{
            [Key]
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string MobileNo { get; set; }
            public string EmailId { get; set; }
            public int SourceChannelId { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime UpdatedDate { get; set; }




        // [ForeignKey("Category")]
        // public int CategoryId { get; set; }
        //
        // //reference navigation property
        // public Category Category { get; set; }

        //}
    }
}
