using Builder.Builders;
using Builder.Models;

namespace Builder;

public class SampleInvoice
{
    IInvocieBuilder _builder;
    public SampleInvoice()
    {
        _builder = new InvoiceBuilder();
    }

    public Invoice CreateMonthlyInvoice()
    {
        return _builder.SetVendor("xd").Build();
    }
    public Invoice CreateBlankInvoice()
    {
        return _builder.Build();
    }
}
