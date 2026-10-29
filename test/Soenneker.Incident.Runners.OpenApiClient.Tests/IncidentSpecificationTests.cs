using System;
using System.Text.Json.Nodes;
using Soenneker.Incident.Runners.OpenApiClient.Utils;

namespace Soenneker.Incident.Runners.OpenApiClient.Tests;

public sealed class IncidentSpecificationTests
{
    [Test]
    public void RedactsKeyExamplesWithoutChangingApiShape()
    {
        string example = "inc_" + new string('x', 64);
        string source = """{"paths":{"/v1/api_keys":{"get":{}}},"example":{"token":"TOKEN"},"type":"string"}""".Replace("TOKEN", example);
        string sanitized = IncidentSpecification.RedactApiKeyExamples(source);
        JsonNode document = JsonNode.Parse(sanitized)!;
        if (sanitized.Contains(example) || document["example"]!["token"]!.ToString() != "EXAMPLE_INCIDENT_API_KEY" ||
            document["paths"]!["/v1/api_keys"]!["get"] == null || document["type"]!.ToString() != "string")
            throw new Exception("Example redaction changed the API shape or retained a key.");
    }
}
