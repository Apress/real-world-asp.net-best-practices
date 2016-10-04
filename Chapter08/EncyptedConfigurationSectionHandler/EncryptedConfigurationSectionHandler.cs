using System;
using System.Configuration;
using System.Xml;
using System.Collections;
using System.Collections.Specialized;

namespace APress.ASPNetBestPractices
{
	/// <summary>
	/// Handles reading of encrypted configuration items and returning 
	/// the decrypted values in a NameValueCollection
	/// </summary>
	public class EncyptedConfigurationSectionHandler : System.Configuration.IConfigurationSectionHandler
	{

		/// <summary>
		/// Creates the name value collection of entries decrypting the values
		/// as it reads them from the file.
		/// </summary>
		/// <param name="parent">The parent section from a higher directory</param>
		/// <param name="configContext">For the web, the context of the request</param>
		/// <param name="section">The xml representing the config section</param>
		/// <returns>A NameValueCollection of entries from the file.</returns>
		public object Create(object parent, object configContext, System.Xml.XmlNode section)
		{
			NameValueCollection settings;
			NameValueCollection parentSettings;
			string key;
			string encryptedValue;
			string decryptedValue;
			XmlNodeList entries;

			//if there is not parent, we need a new empty collection
			//but if there is, we need a new collection which includes the 
			//parent information
			if(parent == null)
				settings = new NameValueCollection();
			else
			{
				parentSettings = (NameValueCollection)parent;
				settings = new NameValueCollection(parentSettings);
			}

			
			try
			{
				//get all of the items to be added
				entries = section.SelectNodes("//add");
				if(entries == null)
					throw new ConfigurationException(String.Format("The {0} section must have at least one \"add\" element in it.", section.Name), section);

				//walk through the items and add each one to the collection, 
				//decrypting as we go
				for(int entryIndex = 0; entryIndex < entries.Count; entryIndex++)
				{
					//get the key and value from the element
					key = entries[entryIndex].Attributes.RemoveNamedItem("key").Value;
					encryptedValue = entries[entryIndex].Attributes.RemoveNamedItem("value").Value;

					//just set this without worrying about the decryption
					//if there is no value
					if(encryptedValue == "")
					{
						settings[key] = encryptedValue;
					}
					else
					{
						decryptedValue = APress.ASPNetBestPractices.ConfigurationSecurity.Decrypt(encryptedValue, true);
						settings[key] = decryptedValue;
					}
				}
			}
			catch(Exception ex)
			{
				throw new ConfigurationException("Error trying to process configuration section", ex, section);
			}

			return settings;
		}
	}
}
