using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiAspnetCore.Data;
using ApiAspnetCore.Models;
using Microsoft.AspNetCore.Mvc;


namespace ApiAspnetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController: ControllerBase
    {
        private DataContext Context { get; }
        
        public CategoryController(DataContext Context)
        {
            this.Context = Context;
        }

        [HttpGet("")]
        public async Task<ActionResult> Index()
        {
            var products = await Context.Categories.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public Category Select(int id)
        {
            Category category = Context.Categories.Find(id);
            return category;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Register([FromBody] Category category)
        {
            Context.Categories.Add(category);
            await Context.SaveChangesAsync();
            return Created("category",category);
        }

        [HttpPut("update")]
        public async Task<ActionResult> Update([FromBody] Category category) 
        {
            Context.Categories.Update(category);
            await Context.SaveChangesAsync();
            return Ok(category);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var category = Context.Categories.Find(id);
            Context.Categories.Remove(category);
            await Context.SaveChangesAsync();
            return Ok();
        }
    }
}