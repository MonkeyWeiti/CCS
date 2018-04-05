using Invoice.Database.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Shared;

namespace Invoice.Database.MongoDb
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public void Delete(InvoiceModel invoice)
        {
            throw new NotSupportedException();
        }

        public InvoiceModel Load(Guid invoiceId)
        {
            var customerId = Guid.NewGuid();
            var positions = new List<InvoicePosition>();
            positions.Add(new InvoicePosition());
            return InvoiceModel.Create(invoiceId, customerId, positions);
        }

        public IEnumerable<InvoiceModel> LoadAll()
        {
            var models = new List<InvoiceModel>();

            models.Add(CreateMockedData(Guid.NewGuid()));
            models.Add(CreateMockedData(Guid.NewGuid()));
            models.Add(CreateMockedData(Guid.NewGuid()));
            models.Add(CreateMockedData(Guid.NewGuid()));
            models.Add(CreateMockedData(Guid.NewGuid()));

            return models;
        }

        public InvoiceModel Save(InvoiceModel invoice)
        {
            throw new NotSupportedException();
        }

        private InvoiceModel CreateMockedData(Guid invoiceId)
        {
            var customerId = Guid.NewGuid();
            var positions = new List<InvoicePosition>();
            positions.Add(new InvoicePosition());
            positions.Add(new InvoicePosition());
            positions.Add(new InvoicePosition());
            positions.Add(new InvoicePosition());
            positions.Add(new InvoicePosition());
            return InvoiceModel.Create(invoiceId, customerId, positions);
        }
    }
}
