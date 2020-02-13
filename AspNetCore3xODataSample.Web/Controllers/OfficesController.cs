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
    public class OfficesController : ODataController
    {
        private readonly SampleDataConnection _context;

        public OfficesController(SampleDataConnection context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Office> Get()
        {
            return _context.Offices;
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_context.Offices.Where(x => x.Id == key));
        }
    }
}
