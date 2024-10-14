using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DataSerializationLibrary
{
    public class XmlSerializer : IDataSerializer
    {
        /// <summary>
        /// Serializes an object to an XML string.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>An XML string representation of the serialized object.</returns>
        public string Serialize(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Cannot serialize a null object.");
            }

            // Create a new StringBuilder to hold the XML data
            var stringBuilder = new StringBuilder();

            // Use StringWriter to serialize the object to XML
            using (var stringWriter = new StringWriter(stringBuilder))
            {
                var xmlSerializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                xmlSerializer.Serialize(stringWriter, obj);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Deserializes an XML string back to an object of specified type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="data">The XML string representation of the serialized object.</param>
        /// <returns>The deserialized object.</returns>
        public T Deserialize<T>(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException("Cannot deserialize a null or empty XML string.", nameof(data));
            }

            // Use StringReader to read the XML data
            using (var stringReader = new StringReader(data))
            {
                var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(stringReader);
            }
        }
    }
}
