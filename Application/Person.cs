namespace Application;

/// <summary>
/// Person
/// </summary>
public class Person
{
	/// <summary>
	/// Constructor
	/// </summary>
	public Person()
	{
	}

	/// <summary>
	/// Full Name
	/// </summary>
	public string FullName { get; set; }

	/// <summary>
	/// Gender
	/// </summary>
	public Enums.Gender Gender { get; set; }

	/// <summary>
	/// Marriage
	/// </summary>
	public Enums.Marriage Marriage { get; set; }
}
