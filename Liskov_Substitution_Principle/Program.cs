using notIdeal = Liskov_Substitution_Principle_NotIdealCode;
using ideal = Liskov_Substitution_Principle_IdealCode;


#region Not Ideal Code

notIdeal.Cloud cloud = new notIdeal.AWS();
cloud.MachineLearning();
cloud.Translate();

cloud = new notIdeal.Google();
cloud.MachineLearning();
cloud.Translate();

cloud = new notIdeal.Azure();
cloud.MachineLearning();
if (cloud is not notIdeal.Azure)
{
    cloud.Translate();
}


#endregion

#region Ideal Code

ideal.Cloud icloud = new ideal.AWS();
icloud.MachineLearning();
(icloud as ideal.ITranslatable)?.Translate();

icloud = new ideal.Google();
icloud.MachineLearning();
(icloud as ideal.ITranslatable)?.Translate();

icloud = new ideal.Azure();
icloud.MachineLearning();
(icloud as ideal.ITranslatable)?.Translate();


#endregion