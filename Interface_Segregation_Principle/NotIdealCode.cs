using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_NotIdealCode;
interface IPrinter
{
    void Print();
    void Scan();
    void Fax();
    void PrintDuplex();
}

class HPPrinter : IPrinter
{
    public void Fax()
    {
        //... Fax processes ...
    }

    public void Print()
    {
        //... Print processes ...
    }

    public void PrintDuplex()
    {
        //... Print Duplex processes ...
    }

    public void Scan()
    {
        //... Scan processes ...
    }
}
class SamsungPrinter : IPrinter
{
    public void Fax()
    {
        //... Fax processes ...
    }

    public void Print()
    {
        //... Print processes ...
    }

    public void PrintDuplex()
        => throw new NotSupportedException();

    public void Scan()
        => throw new NotSupportedException();
}
class LexmarkPrinter : IPrinter
{
    public void Fax()
    {
        //... Fax processes ...
    }

    public void Print()
    {
        //... Print processes ...
    }

    public void PrintDuplex()
        => throw new NotSupportedException();

    public void Scan()
    {
        //... Scan processes ...
    }
}