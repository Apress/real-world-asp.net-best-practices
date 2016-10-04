using System;
using SharedLibrary;

namespace BusinessObjects
{
	/// <summary>
	/// Implementation of a simple remote object
	/// </summary>
	public class RemoteImplementation : System.MarshalByRefObject,
		IRemoteObject
	{
		public RemoteImplementation()
		{}

		public string Name
		{
			get{return String.Format("{0} running in AppDomain {1}",System.Reflection.Assembly.GetExecutingAssembly().FullName, AppDomain.CurrentDomain.FriendlyName);}
		}
	}
}
