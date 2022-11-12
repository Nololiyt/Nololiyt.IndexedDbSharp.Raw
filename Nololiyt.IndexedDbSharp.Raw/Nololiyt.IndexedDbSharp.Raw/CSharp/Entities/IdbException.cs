using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{

	[Serializable]
	public class IdbException : Exception
	{
		public IdbException() { }
		public IdbException(string message) : base(message) { }
		public IdbException(string message, Exception inner) : base(message, inner) { }
		protected IdbException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		internal static bool TryFromJsException(
			JSException jsException,
			[MaybeNullWhen(false)]out IdbException result)
        {
			var message = jsException.Message;
			var messageSplit = message.Split("KnownError Of Nololiyt.IndexedDbSharp.Raw: ");
			if (messageSplit.Length != 2)
			{
				result = null;
				return false;
            }
            result = new IdbException(messageSplit[1], jsException);
            return true;
        }
	}
}
