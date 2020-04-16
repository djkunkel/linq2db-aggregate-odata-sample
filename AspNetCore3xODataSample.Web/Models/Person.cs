using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore3xODataSample.Web.Models
{
    [Table(Name = "person")]
    public class Person
    {
        [Column("Name"), PrimaryKey]
        public string Name { get; set; }
        
        [Column("YearsExperience"), NotNull]
        public int YearsExperience { get; set; }
        
        [Column("Title"), NotNull]
        public string Title { get; set; }

        [Column("OfficeId")]
        public int OfficeId { get; set; }

        [Column("StartDate")]
        public DateTimeOffset StartDate { get; set; }

        [Association(OtherKey = "Id", ThisKey ="OfficeId")]
        public Office Office { get; set; }
    }
}
