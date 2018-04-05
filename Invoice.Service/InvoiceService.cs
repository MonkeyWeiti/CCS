using Invoice.Service.Contract;
using System;
using System.Collections.Generic;
using Invoice.Shared;
using Invoice.Database.Contract;
using Invoice.Database.MongoDb;

namespace Invoice.Service
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;

        public InvoiceService()
        {
            _repository = new InvoiceRepository();
        }

        public void Delete(InvoiceModel invoice)
        {
            throw new NotSupportedException();
        }

        public InvoiceModel Load(Guid invoiceId)
        {
            return _repository.Load(invoiceId);
        }

        public IEnumerable<InvoiceModel> LoadAll()
        {
            return _repository.LoadAll();
        }

        public InvoiceModel Save(InvoiceModel invoice)
        {
            throw new NotSupportedException();
        }
    }
}
