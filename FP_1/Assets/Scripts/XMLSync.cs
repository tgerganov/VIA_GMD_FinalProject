using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System;
 
public static class XMLSync 
{
   	public static T DeserializeFile<T>(string filename)
	{
		T obj=default (T);
		string text="";
		if (File.Exists(filename))
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
				byte[] bytes = new byte[file.Length];
				file.Read(bytes, 0, (int)file.Length);
				MemoryStream assetStream = new MemoryStream(bytes);
				XmlTextReader xmlReader = new XmlTextReader(assetStream);
	    		obj = (T)serializer.Deserialize(xmlReader);
				xmlReader.Close();
				assetStream.Close();
				file.Close();
	   		}
	   		catch (System.Exception err)
			{
				text="error:"+err.ToString();
	    	}
		}
		else
		{
			text="error:File Does Not Exist";
		}
	    return obj;
	} 

	public static T DeserializeText<T>(string xml)
	{
		T obj=default (T);
		string text="";
		try {
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			XmlTextReader xmlReader = new XmlTextReader(new StringReader(xml));
    		obj = (T)serializer.Deserialize(xmlReader);
			xmlReader.Close();
   		}
   		catch (System.Exception err) {
			text="error:"+err.ToString();
    	}
	    return obj;
	} 

	public static void SerializeObject<T>(string filename, T data)
	{
	    XmlSerializer serializer = new XmlSerializer(typeof(T));
	    TextWriter textWriter = new StreamWriter(filename);
	    serializer.Serialize(textWriter, data);
	    textWriter.Close();
	}

	public static string GetXMLString<T>(this T toSerialize)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
		
		using(StringWriter textWriter = new StringWriter())
		{
			xmlSerializer.Serialize(textWriter, toSerialize);
			return textWriter.ToString();
		}
	}
}