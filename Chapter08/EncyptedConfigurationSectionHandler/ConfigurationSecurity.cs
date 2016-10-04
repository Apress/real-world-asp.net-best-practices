using System;
using System.Security.Cryptography;

namespace APress.ASPNetBestPractices
{
	/// <summary>
	/// Provides encryption related services for the configuration section handler
	/// </summary>
	public class ConfigurationSecurity
	{

		/// <summary>
		/// Decrypts the given string
		/// </summary>
		/// <param name="encryptedValue">The value to be decrypted</param>
		/// <returns>The decrypted value for the encryptedValue</returns>
		public static string Decrypt(string encryptedValue)
		{
			return Decrypt(encryptedValue, false);
		}

		/// <summary>
		/// Decrypts an encrypted string. 
		/// </summary>
		/// <param name="encryptedValue">The value to be decrypted</param>
		/// <param name="base64Encoded">Indicates if the string is base64 encoded</param>
		/// <returns></returns>
		public static string Decrypt(string encryptedValue, bool base64Encoded)
		{
			byte[] encryptedValueBytes;

			if(base64Encoded)
				encryptedValueBytes = System.Convert.FromBase64String(encryptedValue);
			else
				encryptedValueBytes = System.Text.UTF8Encoding.UTF8.GetBytes(encryptedValue);

			CspParameters param = new CspParameters();
			param.KeyContainerName = "APressAspNetBestPractices";

			RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param);
			
			return System.Text.UTF8Encoding.UTF8.GetString(rsa.Decrypt(encryptedValueBytes, false));

		}

		/// <summary>
		/// Encrypts a string
		/// </summary>
		/// <param name="plainText">The string to be encrypted</param>
		/// <returns>The string encrypted with the default key</returns>
		public static string Encrypt(string plainText)
		{
			return Encrypt(plainText, false);
		}


		/// <summary>
		/// Encrypts a string
		/// </summary>
		/// <param name="plainText">the string to be encrypted</param>
		/// <param name="base64Encode">Indicates whether the resulting string should be base64 encoded</param>
		/// <returns>the encrypted string, optionally base64 encoded</returns>
		public static string Encrypt(string plainText, bool base64Encode)
		{
			byte[] encryptedValue;

			CspParameters param = new CspParameters();
			param.KeyContainerName = "APressAspNetBestPractices";

			RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param);
			
			encryptedValue = rsa.Encrypt(System.Text.UTF8Encoding.UTF8.GetBytes(plainText),false);

			if(base64Encode)
				return System.Convert.ToBase64String(encryptedValue);
			else
				return System.Text.UTF8Encoding.UTF8.GetString(encryptedValue);

		}
	}
}
