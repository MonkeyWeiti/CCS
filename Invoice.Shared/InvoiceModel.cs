using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Invoice.Shared
{
    public class InvoiceModel
    {
        public readonly Guid InvoiceId;
        public readonly Guid CustomerId;
        public readonly IEnumerable<InvoicePosition> Positions;

        private InvoiceModel(Guid invoiceId, Guid customerId, IList<InvoicePosition> positions)
        {
            InvoiceId = invoiceId;
            CustomerId = customerId;
            Positions = new ReadOnlyCollection<InvoicePosition>(positions);
        }

        public static InvoiceModel Create(Guid invoiceId, Guid customerId, IList<InvoicePosition> positions)
        {
            if (invoiceId == Guid.Empty)
            {
                throw new ArgumentException();
            }
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException();
            }
            if (positions.Count == 0)
            {
                throw new ArgumentException();
            }

            return new InvoiceModel(invoiceId, customerId, positions);
        }
    }
}
