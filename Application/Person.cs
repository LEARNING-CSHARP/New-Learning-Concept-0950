namespace Application;

/// <summary>
/// Person
/// </summary>
public class Person
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public Person()
	{
	}
	#endregion /Constructor

	#region Properties

	#region public string FullName { get; set; }
	/// <summary>
	/// Full Name
	/// </summary>
	public string FullName { get; set; }
	#endregion /public string FullName { get; set; }

	#region public Enums.Gender Gender { get; set; }
	/// <summary>
	/// Gender
	/// </summary>
	public Enums.Gender Gender { get; set; }
	#endregion /public Enums.Gender Gender { get; set; }

	#region public Enums.Marriage Marriage { get; set; }
	/// <summary>
	/// Marriage
	/// </summary>
	public Enums.Marriage Marriage { get; set; }
	#endregion /public Enums.Marriage Marriage { get; set; }

	#endregion /Properties
}
