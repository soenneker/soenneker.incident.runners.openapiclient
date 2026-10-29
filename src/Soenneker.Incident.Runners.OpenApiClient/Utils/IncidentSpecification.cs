using System.Text.RegularExpressions;

namespace Soenneker.Incident.Runners.OpenApiClient.Utils;

/// <summary>Removes API-key examples from the public specification before checking it into source control.</summary>
public static class IncidentSpecification
{
    /// <summary>Replaces incident.io key-shaped example values with a non-secret placeholder.</summary>
    public static string RedactApiKeyExamples(string document) =>
        Regex.Replace(document, @"\binc_[A-Za-z0-9_-]{20,}\b", "EXAMPLE_INCIDENT_API_KEY");
}
