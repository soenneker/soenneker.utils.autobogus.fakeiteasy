[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.fakeiteasy.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.fakeiteasy/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.fakeiteasy/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.fakeiteasy.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.fakeiteasy/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus.FakeItEasy
### An AutoFakerBinder for interfaces and abstract objects using FakeItEasy

## Installation

```
dotnet add package Soenneker.Utils.AutoBogus.FakeItEasy
```

## Usage

```csharp
var faker = new AutoFaker
{
    Binder = new FakeItEasyAutoFakerBinder()
};
```