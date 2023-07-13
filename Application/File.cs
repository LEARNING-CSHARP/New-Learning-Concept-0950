namespace Application;

/// <summary>
/// File
/// </summary>
public class File
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public File()
	{
	}
	#endregion /Constructor

	#region Properties

	#region public int Size { get; set; }
	/// <summary>
	/// Size
	/// </summary>
	public int Size { get; set; }
	#endregion /public int Size { get; set; }

	#region public string Name { get; set; }
	/// <summary>
	/// Name
	/// </summary>
	public string Name { get; set; }
	#endregion /public string Name { get; set; }

	#region public Enums.FileAttributes Attributes { get; set; }
	/// <summary>
	/// File Attributes
	/// </summary>
	public Enums.FileAttributes Attributes { get; set; }
	#endregion /public Enums.FileAttributes Attributes { get; set; }

	#endregion /Properties
}
