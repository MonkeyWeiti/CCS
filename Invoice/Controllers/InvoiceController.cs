using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Invoice.Service;
using Invoice.Service.Contract;

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController()
        {
            _invoiceService = new InvoiceService();
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            //var invoices = _invoiceService.LoadAll();
            //var allTheGuids = new List<Guid>();
            //foreach (var invoice in invoices)
            //{
            //    allTheGuids.Add(invoice.InvoiceId);
            //}
            //return allTheGuids;

            return Ok(_invoiceService.LoadAll().Select(x => x.InvoiceId));
        }

        // GET api/values/5
        [HttpGet("{invoiceId}")]
        public ActionResult Get(Guid invoiceId)
        {
            return Ok(_invoiceService.Load(invoiceId));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
