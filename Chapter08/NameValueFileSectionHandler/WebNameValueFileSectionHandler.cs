using System;
using System.Collections.Specialized;
using System.Collections;
using System.IO;
using System.Xml;
using System.Configuration;
using System.Web;

namespace Apress.AspNetBestPractices
{
	/// <summary>
	/// Configuration section handler that allows key-value pairs and specifying
	/// a user specific file of key-value pairs to include
	/// </summary>
	public class WebNameValueFileSectionHandler : IConfigurationSectionHandler
	{
		public WebNameValueFileSectionHandler()
		{}


		/// <summary>
		/// Creates a NameValueCollection of the keys and values in the 
		/// configuration section
		/// </summary>
		/// <param name="parent">The parent configuration section as a namevaluecollection</param>
		/// <param name="configContext">For webconfig only, this is the context of the configuration</param>
		/// <param name="section">The xmlnode representing the config section</param>
		/// <returns>A name value collection with hte values in the config file, or the referenced
		/// user specific settings file.</returns>
		public object Create(object parent, object configContext, System.Xml.XmlNode section)
		{
			string fileName;
			string fileDirectory;
			
			XmlNode fileNameNode;
			NameValueCollection currentSettings;

			//get parent settings merged with local settings
			NameValueSectionHandler helperHandler = new NameValueSectionHandler();
			currentSettings = (NameValueCollection)parent;

			//if there was no parent, then create a new collection
			if(currentSettings == null)
				currentSettings = new NameValueCollection();

			try{
				MapNodeToCollection(section, ref currentSettings);


				//get file name if there is one
				fileNameNode = section.Attributes.RemoveNamedItem("file");

				//as long as there is a file, process it
				if(fileNameNode != null && fileNameNode.Value.Length > 0)
				{
					fileName = fileNameNode.Value;

					fileDirectory = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

					//fileDirectory = Path.GetDirectoryName("web.config");

					fileName = Path.Combine(fileDirectory, fileName);

					if(File.Exists(fileName))
					{
						ConfigXmlDocument doc = new ConfigXmlDocument();

						//load the file
						try
						{
							doc.Load(fileName);
						}
						catch(XmlException xex)
						{
							throw new ConfigurationException(xex.Message, xex, fileName, xex.LineNumber);
						}

						//make sure the section name in the file matches the 
						//one in the config file
						if(!section.Name.Equals(doc.DocumentElement.Name))
						{
							throw new ConfigurationException("Document root element in the file must match the section name in the original configuration file.", section);
						}
					
						//merge the current settings with the ones from the file
						MapNodeToCollection(doc.DocumentElement, ref currentSettings);

					}
				}

			}
			catch(Exception ex)
			{
				throw new ConfigurationException("Error in config file",ex);

			}
			
			return currentSettings;
		}


		/// <summary>
		/// Maps a config section to a namevaluecollection
		/// </summary>
		/// <param name="section">THe xml block to map to a single collection</param>
		/// <param name="coll">The collection to update with values from the xml</param>
		private void MapNodeToCollection(XmlNode section, ref NameValueCollection coll)
		{

			string keyval;
			string valueval;

			try
			{
				foreach(XmlNode node in section.ChildNodes)
				{
					//add all add elements
					if(node.Name.Equals("add"))
					{
						keyval = node.Attributes.RemoveNamedItem("key").Value;
						valueval = node.Attributes.RemoveNamedItem("value").Value;
						coll[keyval] = valueval;
					}
				
					//if removing, then remove from the collection
					if(node.Name.Equals("remove"))
					{
						keyval = node.Attributes.RemoveNamedItem("key").Value;
						coll.Remove(keyval);
					}

					//if clear, then clear the collection
					if(node.Name.Equals("clear"))
					{
						coll.Clear();
					}
				}
			}
			catch(Exception ex)
			{
				throw new ConfigurationException("Error mapping node to collection", ex);
			}
		}
	}

	
}
