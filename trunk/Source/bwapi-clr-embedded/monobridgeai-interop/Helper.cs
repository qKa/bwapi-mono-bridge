using System;
using System.Collections.Generic;
using System.Text;

namespace BWAPI
{
	public class Helper
	{
		public static BWAPI.Player NewPlayer(IntPtr ptr)
		{
			return ((ptr == IntPtr.Zero) ? null : new BWAPI.Player(ptr, false));
		}

		public static BWAPI.Unit NewUnit(IntPtr ptr)
		{
			return ((ptr == IntPtr.Zero) ? null : new BWAPI.Unit(ptr, false));
		}

		public static BWAPI.Position NewPosition(IntPtr ptr)
		{
			return ((ptr == IntPtr.Zero) ? null : new BWAPI.Position(ptr, false));
		}
	}
}
