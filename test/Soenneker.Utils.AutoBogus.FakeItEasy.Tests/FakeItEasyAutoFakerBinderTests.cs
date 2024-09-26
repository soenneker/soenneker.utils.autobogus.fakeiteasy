using FluentAssertions;
using Soenneker.Tests.FixturedUnit;
using Soenneker.Utils.AutoBogus.FakeItEasy.Tests.Dtos;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Utils.AutoBogus.FakeItEasy.Tests;

[Collection("Collection")]
public class FakeItEasyAutoFakerBinderTests : FixturedUnitTest
{
    private readonly AutoFaker _faker;

    public FakeItEasyAutoFakerBinderTests(Fixture fixture, ITestOutputHelper testOutputHelper) : base(fixture, testOutputHelper)
    {
        _faker = new AutoFaker
        {
            Binder = new FakeItEasyAutoFakerBinder()
        };
    }

    [Fact]
    public void Should_Generate()
    {
        var result = _faker.Generate<TestClass>();
        result.Should().NotBeNull();
    }

    [Fact]
    public void Should_Generate_Abstract()
    {
        var result = _faker.Generate<TestAbstractClass>();
        result.Should().NotBeNull();
    }
}
