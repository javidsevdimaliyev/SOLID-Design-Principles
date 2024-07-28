using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_IdealCode;


class BankService
{
    public void SendMoney(BaseBankOperation bankop)
    {
        bankop.TransferMoney(bankop.Price, bankop.AccountNo);
    }
}

public abstract class BaseBankOperation
{
    public int Price { get; set; }
    public string AccountNo { get; set; }
    public abstract bool TransferMoney(int price, string accountNo);
}

class MasterCard : BaseBankOperation
{
    public string AccountNo { get; set; }
    public void SendMoney(int price)
    {
        //...
    }

    public override bool TransferMoney(int ptice, string accountNo)
    {
        try
        {
            AccountNo = accountNo;
            SendMoney(ptice);
            return true;
        }
        catch
        {
            return false;
        }
    }
}


class Visa : BaseBankOperation
{
    string _accountNumber;
    public void SetSenderAccountNo(string accountNumber)
    {
        _accountNumber = accountNumber;
    }
    public void Send(int price)
    {
        //...
    }

    public override bool TransferMoney(int price, string accountNo)
    {
        try
        {
            SetSenderAccountNo(accountNo);
            Send(price);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
class Payoneer : BaseBankOperation
{
    public override bool TransferMoney(int price, string accountNo)
    {
        throw new NotImplementedException();
    }
}