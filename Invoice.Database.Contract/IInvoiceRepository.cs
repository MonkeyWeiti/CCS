using Invoice.Shared;
using System;
using System.Collections.Generic;

namespace Invoice.Database.Contract
{
    public interface IInvoiceRepository
    {
        IEnumerable<InvoiceModel> LoadAll();
        InvoiceModel Load(Guid invoiceId);
        InvoiceModel Save(InvoiceModel invoice);
        void Delete(InvoiceModel invoice);
    }
}
