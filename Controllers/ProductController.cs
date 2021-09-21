using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ApiAspnetCore.Models;
using Microsoft.EntityFrameworkCore;
using ApiAspnetCore.Data;

namespace ApiAspnetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController: ControllerBase
    {
        private DataContext Context { get; }

        public ProductController(DataContext Context)
        {
            this.Context = Context;
        }

        [HttpGet("")]
        public async Task<ActionResult> Index()
        {
            var data = await Context.Products.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public Product Select(int id)
        {
            Product product = Context.Products.Find(id);
            return product;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Register([FromBody]Product product)
        {
            Context.Products.Add(product);
            await Context.SaveChangesAsync();
            return Created("product",product);
        }

        [HttpPut("update")]
        public async Task<ActionResult> Update([FromBody] Product product)
        {
            var data =  Context.Products.Update(product);
            await Context.SaveChangesAsync();

            return Ok(data);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = Context.Products.Find(id);
            Context.Remove(product);
            await Context.SaveChangesAsync();
            return Ok();
        }
    }
}