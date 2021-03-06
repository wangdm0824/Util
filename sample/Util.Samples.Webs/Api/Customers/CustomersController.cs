﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Donau.Services.Abstractions.Customers;
using Donau.Services.Dtos.Customers;
using Donau.Services.Queries.Customers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.Prerendering;
using Util.Exceptions;
using Util.Webs.Controllers;

namespace Util.Samples.Webs.Api.Customers
{
    public class CustomersController : CrudControllerBase<CustomersDto, CustomersQuery>
    {
        public CustomersController(ICustomersService customersService) : base(customersService)
        {
        }

        [HttpGet("test")]
        public IActionResult Test() {
            List<Item> items = new List<Item> {
                new Item( "B","1",2,"Group1" ),
                new Item( "A","2",1,"Group2" ),
                new Item( "D","3",4,"Group1" ),
                new Item( "C","4",3,"Group2" ),
            };
            return Success( items );
        }
    }
}
