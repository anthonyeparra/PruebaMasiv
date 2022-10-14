using Microsoft.AspNetCore.Mvc;
using PruebaMasiv.Model;
using PruebaMasiv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaMasiv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesTableController : ControllerBase
    {
        private readonly ISalesTableRepository _salesTable;

        public SalesTableController(ISalesTableRepository salesTable)
        {
            _salesTable = salesTable;
        }
        // GET: api/<SalesTableController>
        [HttpGet]
        public async Task<IActionResult> GetDiscountSales()
        {
            try
            {
                return Ok(await _salesTable.GetDiscountSales());
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // GET api/<SalesTableController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SalesTableController>
        [HttpPost]
        [Route("CreateSales")]
        public async Task<IActionResult> CreateSales([FromBody] SalesTableModel salesTable)
        {
            try
            {
                if (salesTable == null) return BadRequest();
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var created = await _salesTable.InsertSales(salesTable);
                return Created("created", created);
            }
            catch (Exception ex)
            {
                return  Ok(ex.Message);
            }
        }

        // PUT api/<SalesTableController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalesTableController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
