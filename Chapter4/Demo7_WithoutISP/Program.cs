Console.WriteLine("***A demo without ISP.***");
IPrinter printer = new AdvancedPrinter();
printer.PrintDocument();
printer.SendFax();

printer = new BasicPrinter();
printer.PrintDocument();
//printer.SendFax(); // Will throw exception

//List<IPrinter> printers = new()
//{
// new AdvancedPrinter(),
// new BasicPrinter()
// };
//foreach (IPrinter device in printers)
//{
//    device.PrintDocument();
//    device.SendFax(); // Will throw exception
//}


interface IPrinter
{
    void PrintDocument();
    void SendFax();
}


class AdvancedPrinter : IPrinter
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
class BasicPrinter : IPrinter
{
    public void PrintDocument()
    {
        Console.WriteLine("A basic printer prints the document.");
    }

    public void SendFax()
    {
        throw new NotImplementedException();
    }
}



