using System;
using System.Runtime.Remoting;

namespace Server
{
	class Host
	{

		[STAThread]
		static void Main(string[] args)
		{
			//configure remoting and then wait for the user to close the app
			RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

			Console.WriteLine("Ready for requests");
			Console.ReadLine();
		}

	}
}
