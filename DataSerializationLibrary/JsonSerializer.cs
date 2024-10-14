using System;
using System.Text.Json;

namespace DataSerializationLibrary
{
    public class JsonSerializer : IDataSerializer
    {
        /// <summary>
        /// Serializes an object to a JSON string.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A JSON string representation of the serialized object.</returns>
        public string Serialize(object obj)
        {
            // Check if the object is null to prevent serialization errors
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Cannot serialize a null object.");
            }

            // Serialize the object to a JSON string
            return System.Text.Json.JsonSerializer.Serialize(obj);
        }

        /// <summary>
        /// Deserializes a JSON string back to an object of specified type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="data">The JSON string representation of the serialized object.</param>
        /// <returns>The deserialized object.</returns>
        public T Deserialize<T>(string data)
        {
            // Check if the JSON string is null or empty to prevent deserialization errors
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException("Cannot deserialize a null or empty JSON string.", nameof(data));
            }

            // Deserialize the JSON string back to the specified object type
            return System.Text.Json.JsonSerializer.Deserialize<T>(data);
        }
    }
}
