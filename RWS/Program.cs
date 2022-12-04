using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RWS.Implementations;



try
{
    var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Document1.xml");
    var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Document1.json");

    var xmlService = new ConvertXmlService();
    using Stream sr = File.Open(sourceFileName, FileMode.Open, FileAccess.Read);
    var document = xmlService.DeserializeDocument(sr);
    if (document == null)
        throw new Exception("Failed to deserialize document from xml");

    var jsonService = new ConvertJsonService();
    using Stream sw = File.Open(targetFileName, FileMode.Create, FileAccess.Write);
    jsonService.SerializeDocument(sw, document);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("success");
