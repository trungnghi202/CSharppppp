global using System;
namespace OopPolymorphismOverloadding
{
	public class BasicMath
	{
			public int NumberOne { get; set; }
			public int NumberTwo { get; set; }
		//	public BasicMath()
		//{

		//}
		//public BasicMath(int numberOne,int numberTwo)
		//{
		//	numberOne = NumberOne;
  //          numberTwo = NumberTwo;
  //      }
		//public BasicMath(int numberOne)
		//{
		//	numberOne = NumberOne;
		//}
  //      public BasicMath(int numberTwo)
  //      {
  //          numberTwo = NumberTwo;
  //      }
	//overloading phuong thuc
	//optinal argument = >doi so truyen cho tham so(parameter)
		public void sum(int num1 =1, int num2 = default)
		{
			NumberOne = num1;
			NumberTwo = num2;
			Console.WriteLine(NumberOne + NumberTwo);
		}
		
    }
}

