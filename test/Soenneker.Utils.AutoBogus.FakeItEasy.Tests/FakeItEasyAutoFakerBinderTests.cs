using AwesomeAssertions;
using Soenneker.Tests.HostedUnit;
using Soenneker.Utils.AutoBogus.FakeItEasy.Tests.Dtos;


namespace Soenneker.Utils.AutoBogus.FakeItEasy.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class FakeItEasyAutoFakerBinderTests : HostedUnitTest
{
    private readonly AutoFaker _faker;

    public FakeItEasyAutoFakerBinderTests(Host host) : base(host)
    {
        _faker = new AutoFaker
        {
            Binder = new FakeItEasyAutoFakerBinder()
        };
    }

    [Test]
    public void Should_Generate()
    {
        var result = _faker.Generate<TestClass>();
        result.Should().NotBeNull();
    }

    [Test]
    public void Should_Generate_Abstract()
    {
        var result = _faker.Generate<TestAbstractClass>();
        result.Should().NotBeNull();
    }
}
