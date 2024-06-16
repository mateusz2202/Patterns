namespace Builder.Models;

public class Invoice
{
    public Invoice()
    {
        LineItems = [];
    }
    public string Vendor { get; set; }
    public string Vendee { get; set; }
    public string Note { get; set; }
    public string PeymentMethod { get; set; }

    public List<InvoiceLine> LineItems { get; set; }
}
