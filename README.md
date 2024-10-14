# Data Serialization Library

A simple and flexible library for serializing and deserializing objects to and from various data formats, including JSON and XML.

## Features

- Serialize objects to JSON and XML.
- Deserialize JSON and XML strings back to objects.
- Easy to use and integrate into your projects.

## Installation

You can add this library to your project by cloning this repository or by downloading the necessary files.

```bash
git clone https://github.com/zikriacodes/DataSerializationLibrary.git
```

# Usage

## JSON Serialization

To use JSON serialization, create an instance of the `JsonSerializer` class and use its `Serialize` and `Deserialize` methods:

```csharp
using DataSerializationLibrary;

// Create a sample object
var sampleObject = new Sample { Name = "John Doe", Age = 30 };

// Create a JSON serializer
var jsonSerializer = new JsonSerializer();

// Serialize the object to JSON
string jsonData = jsonSerializer.Serialize(sampleObject);
Console.WriteLine(jsonData);

// Deserialize the JSON string back to an object
var deserializedObject = jsonSerializer.Deserialize<Sample>(jsonData);
Console.WriteLine($"Name: {deserializedObject.Name}, Age: {deserializedObject.Age}");
```

## XML Serialization

To use XML serialization, create an instance of the `XmlSerializer` class:

```csharp
using DataSerializationLibrary;

// Create a sample object
var sampleObject = new Sample { Name = "Jane Doe", Age = 25 };

// Create an XML serializer
var xmlSerializer = new XmlSerializer();

// Serialize the object to XML
string xmlData = xmlSerializer.Serialize(sampleObject);
Console.WriteLine(xmlData);

// Deserialize the XML string back to an object
var deserializedObject = xmlSerializer.Deserialize<Sample>(xmlData);
Console.WriteLine($"Name: {deserializedObject.Name}, Age: {deserializedObject.Age}");
```

# Classes

- `IDataSerializer`: An interface defining the methods for serialization and deserialization.
- `JsonSerializer`: A class for serializing and deserializing JSON data.
- `XmlSerializer`: A class for serializing and deserializing XML data.

# License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
