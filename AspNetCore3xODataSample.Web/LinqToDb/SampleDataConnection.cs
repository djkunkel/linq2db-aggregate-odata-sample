using AspNetCore3xODataSample.Web.Models;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore3xODataSample.Web.LinqToDb
{
    public class SampleDataConnection : LinqToDB.Data.DataConnection
    {
        public SampleDataConnection() : base("Sample")
        {

        }

        public ITable<Person> Person => GetTable<Person>();


    }
}
