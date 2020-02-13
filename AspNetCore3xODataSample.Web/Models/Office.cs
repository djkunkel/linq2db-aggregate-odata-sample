using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore3xODataSample.Web.Models
{
    [Table(Name = "office")]
    public class Office
    {
        [Column("Id"), PrimaryKey]
        public int Id { get; set; }
        
        [Column("Name"), NotNull]
        public string Name { get; set; }

        
    }
}
