using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace restfull_API_with_ASP.Net5._0.model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("first_name")]
        public string FistName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("address")]
        public string AddressName { get; set; }

        [Column("gender")]
        public string Gender { get; set; }
    }
}
