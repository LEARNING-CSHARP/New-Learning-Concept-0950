//namespace Application
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{
//		}
//	}
//}

//namespace Application;

//internal static class Program
//{
//	private static void Main()
//	{
//	}
//}

using System;
using Application.Enums;

namespace Application;

internal static class Program
{
	private static void Main()
	{
		var person =
			new Person
			{
				Gender =
					Gender.Male,

				Marriage =
					Marriage.Married,

				FullName =
					"Ali Reza Alavi",
			};

		if (person.Gender == Gender.Female)
		{
			Console.WriteLine
				(value: "You are female!");
		}

		Console.WriteLine(value: person.Gender);
		Console.WriteLine(value: (byte)person.Gender);

		switch (person.Marriage)
		{
			case Marriage.Single:
			{
				break;
			}

			case Marriage.Married:
			{
				break;
			}

			case Marriage.Divorced:
			{
				break;
			}
		}

		var file =
			new File
			{
				Attributes =
					FileAttributes.System,
			};

		file.Attributes =
			FileAttributes.Hidden
			|
			FileAttributes.System
			|
			FileAttributes.Archive;

		if (file.Attributes == FileAttributes.System)
		{
		}

		if ((file.Attributes & FileAttributes.System) == FileAttributes.System)
		{
		}

		if ((file.Attributes &
			(FileAttributes.Hidden | FileAttributes.System)) ==
			(FileAttributes.Hidden | FileAttributes.System))
		{
		}
	}
}
