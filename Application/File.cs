namespace Application;

/// <summary>
/// File
/// </summary>
public class File
{
	/// <summary>
	/// Constructor
	/// </summary>
	public File()
	{
	}

	/// <summary>
	/// Size
	/// </summary>
	public int Size { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// File Attributes
	/// </summary>
	public Enums.FileAttributes Attributes { get; set; }
}
