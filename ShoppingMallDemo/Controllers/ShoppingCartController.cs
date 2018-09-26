﻿using Microsoft.AspNetCore.Mvc;

namespace ShoppingMallDemo.Controllers
{
    [Route("Cart")]
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetCart()
        {
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public IActionResult PlaceOrder()
        {
            return Ok();
        }
    }
}