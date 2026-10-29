using Soenneker.Tests.HostedUnit;

namespace Soenneker.Incident.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class IncidentOpenApiClientRunnerTests : HostedUnitTest
{
    public IncidentOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
