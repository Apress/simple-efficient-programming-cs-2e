Console.WriteLine("***A demo that follows ISP.***");

IPrinter printer = new BasicPrinter();
printer.PrintDocument();
printer = new AdvancedPrinter();
printer.PrintDocument();

IFaxDevice faxDevice = new AdvancedPrinter();
faxDevice.SendFax();

interface IPrinter
{
    void PrintDocument();
}
interface IFaxDevice
{
    void SendFax();
}
class BasicPrinter : IPrinter
{
    public void PrintDocument()
    {
        Console.WriteLine("A basic printer prints the document.");
    }
}
class AdvancedPrinter : IPrinter, IFaxDevice
{
    public void PrintDocument()
    {
        Console.WriteLine("An advanced printer prints the document.");
    }
    public void SendFax()
    {
        Console.WriteLine("An advanced printer sends the fax.");
    }
}



