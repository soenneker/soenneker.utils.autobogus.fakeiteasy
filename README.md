[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.fakeiteasy.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.fakeiteasy/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.fakeiteasy/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.fakeiteasy.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.fakeiteasy/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.fakeiteasy/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy/actions/workflows/codeql.yml)

# Soenneker.Utils.AutoBogus.FakeItEasy

A FakeItEasy binder that lets `Soenneker.Utils.AutoBogus` create and populate interfaces and abstract classes.

## Installation

```bash
dotnet add package Soenneker.Utils.AutoBogus.FakeItEasy
```

## Usage

```csharp
var faker = new AutoFaker
{
    Binder = new FakeItEasyAutoFakerBinder()
};

IOrderService service = faker.Generate<IOrderService>();
```

Concrete types continue to use AutoBogus's default construction path. Interface and abstract-type requests are created with `A.Fake<T>()`, then their writable members are populated by AutoBogus where the generated proxy permits it. Retain the configured `AutoFaker` when generating repeatedly so its binder and reflection caches can be reused.
