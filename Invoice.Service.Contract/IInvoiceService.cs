using Invoice.Shared;
using System;
using System.Collections.Generic;

namespace Invoice.Service.Contract
{
    public interface IInvoiceService
    {
        IEnumerable<InvoiceModel> LoadAll();
        InvoiceModel Load(Guid invoiceId);
        InvoiceModel Save(InvoiceModel invoice);
        void Delete(InvoiceModel invoice);
    }
}
