using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Incident.Runners.OpenApiClient.Utils.Abstract;

/// <summary>Regenerates the API client from Incident's published OpenAPI specification.</summary>
public interface IFileOperationsUtil
{
    /// <summary>
    /// Downloads the specification, regenerates the client, and verifies a Release build.
    /// Set Incident:LocalRepositoryPath to regenerate a local client repository without pushing by default.
    /// Incident:PushChanges explicitly controls publication; Incident:ClientGenerationUrl overrides the specification source.
    /// Throws when generation or compilation fails.
    /// </summary>
    ValueTask Process(CancellationToken cancellationToken = default);
}
