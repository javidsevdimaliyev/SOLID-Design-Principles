namespace Liskov_Substitution_Principle_NotIdealCode;

//LSP principle requires subtypes (Aws,Azure,Google) to be able to replace supertype (Cloud - class, abstract class, interface, doesn't matter).
//LSP prinsipi subtypelar-in (Aws, Azure, Google) supertype (Cloud - class, abstract class, interface ferq etmir) yerine kece bilmesini teleb edir.
class Operate
{
    public void OperateCloud(Cloud cloud)
    {
        cloud.MachineLearning();

        cloud.Translate(); //Cloud olaraq Azure class gonderildikde xeta verecek, yeni Cloud classi(subtype) inherit etdiyi class-in(supertype) yerine kece bilmir
    }
}

//(Supertype)
abstract class Cloud
{
    public abstract void MachineLearning();
    public abstract void Translate();

}

//(Subtypes)
class AWS : Cloud
{
    override public void MachineLearning()
    => Console.WriteLine("AWS Machine Learning");

    override public void Translate()
        => Console.WriteLine("AWS Translate");
}

class Azure : Cloud
{
    override public void MachineLearning()
      => Console.WriteLine("Azure Machine Learning");

    override public void Translate()
        => throw new NotImplementedException(); ///Error
}

class Google : Cloud
{
    override public void MachineLearning()
    => Console.WriteLine("Google Machine Learning");

    override public void Translate()
        => Console.WriteLine("Google Translate");
}

