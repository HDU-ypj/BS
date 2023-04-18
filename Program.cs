using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpprogramming
{
	class Program
	{
		static void Main(string[] args)
		{
			Type type = typeof(string);
			char[] arr = { 'h','e','l','l'};
			string a = new string(arr);
			Console.WriteLine(type.FullName);
			Console.ReadLine();
		}
	}
	class Name
	{
		object obj = 100;
		//dynamic动态类型实际上就是编译时检测类型和auto类似
	}

	/*
	 
	 abstract	as	base	byte	
catch	char	checked			decimal
delegate	event
explicit	extern	false	finally	fixed	float	for
foreach			implicit	in	in (generic
modifier)	
interface	internal	is	lock
	object	operator	out	out
(generic
modifier)	override	params
private	protected	public	readonly	ref	return	sbyte
sealed	short	sizeof	stackalloc	static	string	struct
switch	this	throw	true	try	typeof	uint
ulong	unchecked	unsafe	ushort	using	virtual	void
volatile	while
	 */
}
