namespace Open_Closed_Principle_NotIdealCode;
class BankService
{
    public void SendMoney(BaseBankOperation bankOp)
    {        
        if (bankOp is MasterCard m)
        {
            m.AccountNo = "123";
            m.SendMoney(m.Price);             
        } 
        else if (bankOp is Visa v)
        {
            v.SetSenderAccountNo("123");
            v.Send(v.Price);
        }
       
    }
}

public abstract class BaseBankOperation
{
    public int Price { get; set; }
    public string AccountNo { get; set; }
}

class MasterCard : BaseBankOperation
{
    public void SendMoney(int price)
    {
        //...
    }
}
class Visa : BaseBankOperation
{
   

    public void SetSenderAccountNo(string accountNo)
    {
        AccountNo = accountNo;
    }
    public void Send(int price)
    {
        //...
    }
}