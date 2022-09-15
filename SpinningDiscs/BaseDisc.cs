
using System;
using System.Security.Policy;

public abstract class BaseDisc
{
	public string Name { get; set; }
	public int Capacity { get; set; }
	public string Contents { get; set; }
	public string DiscType { get; set; }
	public Boolean IsSpinning { get; set; }

	public reportData(Name, Capacity, Contents, DiscType, IsSpinning)
	{
		Name = name;
		Capacity = capacity;
		Contents = contents;
		DiscType = discType;
		IsSpinning = isSpinning;
	};
}