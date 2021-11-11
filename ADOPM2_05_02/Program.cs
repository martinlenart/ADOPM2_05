using System;

namespace ADOPM2_05_02
{
	class Program
	{
#nullable enable
		public class DriversLicense
		{
			public string Number { get; set; }  //Warning: Could be null
			public string? Restrictions { get; set; } //Null is allowed
		}

		static void Main(string[] args)
		{
			var myLicense = new DriversLicense() { Number = "C12345" };

			Console.WriteLine(myLicense.Number.Length);

			//Console.WriteLine(myLicense.Restrictions.Length); //
			Console.WriteLine(myLicense.Restrictions!.Length);

			myLicense.Restrictions = "None";
			Console.WriteLine(myLicense.Restrictions.Length);
		}
#nullable disable
	}

	//Exercises:
	//1.	Modify above code to intialize Restrictions but not Number. What happens?
	//2.	Modify obove code to use normal referencence type. Run and discuss the differece in the group.
	//3.	Create an array of nullable and normal reference types (object type). Access and set some elements to null.
	//		What happens at Compile and Runtime?
}
