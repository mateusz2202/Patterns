using Builder.Models;

namespace Builder.Builders;

public interface IInvocieBuilder
{
    InvoiceBuilder SetVendor(string vendor);
    InvoiceBuilder SetVendee(string vendee);
    InvoiceBuilder SetNote(string note);
    InvoiceBuilder AddLine(InvoiceLine line);
    InvoiceBuilder SetMethodPeyment(string methodPeyment);
    Invoice Build();
}