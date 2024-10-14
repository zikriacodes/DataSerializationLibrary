using System;

namespace DataSerializationLibrary
{
    public interface IDataSerializer
    {
        /// <summary>
        /// Serializes an object to a string format.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A string representation of the serialized object.</returns>
        string Serialize(object obj);

        /// <summary>
        /// Deserializes a string representation of an object back to its original type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="data">The string representation of the serialized object.</param>
        /// <returns>The deserialized object.</returns>
        T Deserialize<T>(string data);
    }
}
