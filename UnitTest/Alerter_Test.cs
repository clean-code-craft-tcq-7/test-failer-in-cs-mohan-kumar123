using System;
using TshirtSpace.TshirtSpace;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Alerter_Test
{

	public int Test_Alert_ForTestServer()
	{
		//Arrange & Act & Assert
		alertInCelcius(networkAlertStub, 392f);
		Console.WriteLine("{0} alerts failed.", alertFailureCount);
		Debug.Assert(alertFailureCount == 0);

		alertInCelcius(networkAlertStub, 303.6f);
		Console.WriteLine("{0} alerts failed.", alertFailureCount);
		Debug.Assert(alertFailureCount == 0);

		alertInCelcius(networkAlertStub, 400.5f);
		Console.WriteLine("{0} alerts failed.", alertFailureCount);
		Debug.Assert(alertFailureCount == 1);
	}

	public int Test_Alert_ForProdServer()
	{
		//Arrange & Act & Assert
		alertInCelcius(networkAlert, 392f);
		Debug.Assert(alertFailureCount == 0);
		alertInCelcius(networkAlert, 303.6f);
		Debug.Assert(alertFailureCount == 0);
		alertInCelcius(networkAlert, 400.5f);
		Debug.Assert(alertFailureCount == 0);
	}

}
