namespace Liskov_Substitution_Principle_IdealCode;

//LSP principle requires subtypes (Aws,Azure,Google) to be able to replace supertype (Cloud - class, abstract class, interface, doesn't matter).
//LSP prinsipi subtypelar-in (Aws, Azure, Google) supertype (Cloud - class, abstract class, interface ferq etmir) yerine kece bilmesini teleb edir.

class Operate
{
    public void OperateCloud(Cloud cloud)
    {
        cloud.MachineLearning();

        // cloud.Translate(); 

        //Translate metodunun Cloud classindan ayirdiq
        // cunki Cloud classinin inherit etdiyi classlarin yerine kece bilme ozelliyinin qarshisini alirdi
        // cunki Azure da translate ozelliyi yoxdur ve method mecbur sekilde istifadeye aciqdir.
    }
}



//(Supertype)
abstract class Cloud
{
    public abstract void MachineLearning();
}

interface ITranslatable
{
    void Translate();
}



//(Subtypes)
class AWS : Cloud, ITranslatable
{
    public void Translate()
       => Console.WriteLine("AWS Translate");
    override public void MachineLearning()
        => Console.WriteLine("AWS Machine Learning");
}

class Azure : Cloud
{
    override public void MachineLearning()
        => Console.WriteLine("Azure Machine Learning");
}

class Google : Cloud, ITranslatable
{
    public void Translate()
       => Console.WriteLine("Google Translate");

    override public void MachineLearning()
        => Console.WriteLine("Google Machine Learning");
}

