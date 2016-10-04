using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using SharedLibrary;

namespace Client
{
	class ClientApp
	{     
		[STAThread]
		static void Main(string[] args)
		{
			//configure remoting - only needed for factory method
			RemotingConfiguration.Configure("client.exe.config");

			//use activation
			IRemoteObject iro = (IRemoteObject)Activator.GetObject(typeof(IRemoteObject), 
				"tcp://localhost:8085/RemoteObjects/RemoteImplementation.rem");
               
			Console.WriteLine(iro.Name);

			//Use Factory
			BusinessObjectFactories.RemoteObjectFactory rof = new BusinessObjectFactories.RemoteObjectFactory();
			IRemoteObject iro2 = rof.GetRemoteObject();

			Console.WriteLine(iro2.Name);


			//Asynchronous remote method call
			AsyncCallback RemoteCallback = new AsyncCallback(TheCallBack);
			RemoteMethodDelegate  remDelegate = new RemoteMethodDelegate(rof.GetRemoteObject);
			IAsyncResult RemAr = remDelegate.BeginInvoke(RemoteCallback, null);
			
			//do work here while the asynchronous method executes

			//wait for the asynchronous method to finish
			RemAr.AsyncWaitHandle.WaitOne();

			
			Console.WriteLine("Press 'Enter' to exit");
			Console.ReadLine();
			
		}

			//delegate for remote method
			public delegate IRemoteObject RemoteMethodDelegate();


			//method called when the asynchronous method is complete
			public static void TheCallBack(IAsyncResult result)
			{
				RemoteMethodDelegate remDel = (RemoteMethodDelegate)((AsyncResult)result).AsyncDelegate;
				IRemoteObject output = remDel.EndInvoke(result);
				Console.WriteLine(output.Name);
			}
	}
}
