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

namespace Application;

internal static class Program
{
	private static void Main()
	{
		var person =
			new Person
			{
				FullName =
					"Ali Reza Alavi",

				Gender =
					Enums.Gender.Male,

				Marriage =
					Enums.Marriage.Married,
			};

		if (person.Gender == Enums.Gender.Female)
		{
			System.Console.WriteLine
				(value: "You are female!");
		}

		System.Console.WriteLine(value: person.Gender);
		System.Console.WriteLine(value: (byte)person.Gender);

		switch (person.Marriage)
		{
			case Enums.Marriage.Single:
			{
				break;
			}

			case Enums.Marriage.Married:
			{
				break;
			}

			case Enums.Marriage.Divorced:
			{
				break;
			}
		}

		var file =
			new File
			{
				Attributes =
					Enums.FileAttributes.System,
			};

		file.Attributes =
			Enums.FileAttributes.Hidden
			|
			Enums.FileAttributes.System
			|
			Enums.FileAttributes.Archive;

		if (file.Attributes == Enums.FileAttributes.System)
		{
		}

		if ((file.Attributes & Enums.FileAttributes.System) == Enums.FileAttributes.System)
		{
		}

		if ((file.Attributes &
			(Enums.FileAttributes.Hidden | Enums.FileAttributes.System)) ==
			(Enums.FileAttributes.Hidden | Enums.FileAttributes.System))
		{
		}
	}
}
