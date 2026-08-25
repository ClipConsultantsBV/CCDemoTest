# CCDemoTest

Een .NET-solution met een data-project om XUnit tests te oefenen.

## Projectstructuur

```
CCDemoTest/
├── CCDemo.Data/                # Data-laag / kernproject
├── CCDemo.Data.Tests.Unit/     # Unit tests voor CCDemo.Data
├── CCDemoTest/                 # (extra project/map)
└── CCDemoTest.slnx             # Solution-bestand
```

De solution (`CCDemoTest.slnx`) bevat in ieder geval:
- **CCDemo.Data** — het hoofdproject
- **CCDemo.Data.Tests.Unit** — unit tests, georganiseerd onder de map `TestSuite/Unit`

## Vereisten

- [.NET SDK](https://dotnet.microsoft.com/download) (recente versie)
- Een IDE zoals Visual Studio, Visual Studio Code of Rider

## Aan de slag

Clone de repository:

```bash
git clone https://github.com/ClipConsultantsBV/CCDemoTest.git
cd CCDemoTest
```

Bouw de solution:

```bash
dotnet build CCDemoTest.slnx
```

## Tests uitvoeren

```bash
dotnet test CCDemo.Data.Tests.Unit/CCDemo.Data.Tests.Unit.csproj
```
