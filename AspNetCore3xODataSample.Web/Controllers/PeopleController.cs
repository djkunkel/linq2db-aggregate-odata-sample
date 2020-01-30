// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using AspNetCore3xODataSample.Web.LinqToDb;
using AspNetCore3xODataSample.Web.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore3xODataSample.Web.Controllers
{
    public class PeopleController : ODataController
    {
        private readonly SampleDataConnection _context;

        public PeopleController(SampleDataConnection context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Person> Get()
        {
            return _context.Person;
        }

        [EnableQuery]
        public IActionResult Get(string key)
        {
            return Ok(_context.Person.Where(x => x.Name == key));
        }
    }
}
