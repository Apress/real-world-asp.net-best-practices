using System;
using SharedLibrary;
using BusinessObjects;

namespace BusinessObjectFactories
{
	/// <summary>
	/// Remote object factory to crate interface based objects
	/// </summary>
	public class RemoteObjectFactory : System.MarshalByRefObject
	{

		public SharedLibrary.IRemoteObject GetRemoteObject()
		{
			RemoteImplementation ri = new RemoteImplementation();
			System.Threading.Thread.Sleep(5000);
			return (SharedLibrary.IRemoteObject)ri;
		}
	}
}
