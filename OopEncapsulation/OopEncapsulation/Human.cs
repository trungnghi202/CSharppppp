global using System;
namespace OopEncapsulation
{
	public class Human
	{
		private string fullname;
		public string FullName
		{
			set
			{
				fullname = value;

			}
			get
			{
				return fullname;
			}
		}
	}
}

