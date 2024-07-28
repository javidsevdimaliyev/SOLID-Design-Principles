using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_IdealCode;
interface IPrint
{
    void Print();
}
interface IScan
{
    void Scan();
}
interface IFax
{
    void Fax();
}
interface IPrintDuplex
{
    void PrintDuplex();
}
class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
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
class SamsungPrinter : IPrint, IFax
{
    public void Fax()
    {
        //... Fax processes ...
    }

    public void Print()
    {
        //... Print processes ...
    }
}
class LexmarkPrinter : IFax, IPrint, IScan
{
    public void Fax()
    {
        //... Fax processes ...
    }

    public void Print()
    {
        //... Print processes ...
    }

    public void Scan()
    {
        //... Scan processes ...
    }
}