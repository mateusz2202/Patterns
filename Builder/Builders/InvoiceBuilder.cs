using Builder.Models;

namespace Builder.Builders;

public class InvoiceBuilder : IInvocieBuilder
{
    private readonly Invoice _invoice;

    public InvoiceBuilder()
    {
        _invoice = new Invoice();
    }

    public InvoiceBuilder SetVendor(string vendor)
    {
        _invoice.Vendor = vendor;
        return this;
    }

    public InvoiceBuilder SetVendee(string vendee)
    {
        _invoice.Vendee = vendee;
        return this;
    }

    public InvoiceBuilder SetNote(string note)
    {
        _invoice.Note = note;
        return this;
    }

    public InvoiceBuilder AddLine(InvoiceLine line)
    {
        _invoice.LineItems.Add(line);
        return this;
    }

    public InvoiceBuilder SetMethodPeyment(string method)
    {
        _invoice.PeymentMethod = method;
        return this;
    }

    public Invoice Build()
    {
        return _invoice;
    }
}

