using System;
using System.Collections.Generic;

namespace Common
{
	public class TreeKeyExistsException : Exception
	{
		public TreeKeyExistsException (object key) : base ("Duplicate key: " + key.ToString())
		{
			
		}
	}

}

