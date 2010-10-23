/*
 * Created by SharpDevelop.
 * User: David
 * Date: 21/12/2009
 * Time: 9:06 PM
 * 
 * This is an example of a class that adds functions to swig generated Unit.cs. Note the class has the same declaration 
 * and is in the same namespace.
 * 
 */
namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Unit : IDisposable {
		public bool isImmobilised() {
			return (this.isStasised() || this.isLockedDown() || this.isMaelstrommed());
		}
	}
}
