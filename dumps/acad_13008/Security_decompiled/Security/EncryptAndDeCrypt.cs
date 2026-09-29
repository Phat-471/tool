using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Security;

public class EncryptAndDeCrypt
{
	private static byte[] bytes = Encoding.ASCII.GetBytes("ZeroCool");

	public static string Encrypt(string inpString)
	{
		if (string.IsNullOrEmpty(inpString))
		{
			throw new ArgumentNullException("Null Input String");
		}
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
		StreamWriter streamWriter = new StreamWriter(cryptoStream);
		streamWriter.Write(inpString);
		streamWriter.Flush();
		cryptoStream.FlushFinalBlock();
		streamWriter.Flush();
		return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
	}

	public static string Decrypt(string encryptedString)
	{
		if (string.IsNullOrEmpty(encryptedString))
		{
			throw new ArgumentNullException("Null Input String");
		}
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MemoryStream stream = new MemoryStream(Convert.FromBase64String(encryptedString));
		CryptoStream stream2 = new CryptoStream(stream, dESCryptoServiceProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
		StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}
}
