Esse projeto é uma API .NET em camadas utilizando C#

O nome do repositório é API-dotnet

Neste repositório os pricipais arquivos são:

docker-compos.yml com o conteúdo:
```

```

Dockerfile com o conteúdo:
```

```

Dockerfile.mysql com o conteúdo:
```

```

Makefile com o conteúdo:
```

```

Possui um arquivo de solution com o nome ******* e o seguinte conteúdo: 
```

```

Possui os projetos API, BLL, DAL e Models que são do tipo class library.

Segue o conteúdo do arquivo API.csproj:
```
<Project Sdk="Microsoft.NET.Sdk.Web">

  

  <PropertyGroup>

    <TargetFramework>net8.0</TargetFramework>

    <Nullable>enable</Nullable>

    <ImplicitUsings>enable</ImplicitUsings>

  </PropertyGroup>

  

  <ItemGroup>

    <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="8.0.3" />

    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />

  </ItemGroup>

  

  <ItemGroup>

    <ProjectReference Include="..\BLL\BLL.csproj" />

    <ProjectReference Include="..\Models\Models.csproj" />

  </ItemGroup>

  

</Project>
```

Segue o conteúdo do arquivo BLL.csproj:
```
<Project Sdk="Microsoft.NET.Sdk">

  

  <ItemGroup>

    <ProjectReference Include="..\DAL\DAL.csproj" />

    <ProjectReference Include="..\Models\Models.csproj" />

  </ItemGroup>

  

  <PropertyGroup>

    <TargetFramework>net8.0</TargetFramework>

    <ImplicitUsings>enable</ImplicitUsings>

    <Nullable>enable</Nullable>

  </PropertyGroup>

  

</Project>
```

Segue o conteúdo do arquivo DAL.csproj:
```
<Project Sdk="Microsoft.NET.Sdk">

  

  <ItemGroup>

    <ProjectReference Include="..\Models\Models.csproj" />

  </ItemGroup>

  

  <PropertyGroup>

    <TargetFramework>net8.0</TargetFramework>

    <ImplicitUsings>enable</ImplicitUsings>

    <Nullable>enable</Nullable>

  </PropertyGroup>

  

</Project>
```

Segue o conteúdo do arquivo Models.csproj:
```
<Project Sdk="Microsoft.NET.Sdk">

  

  <PropertyGroup>

    <TargetFramework>net8.0</TargetFramework>

    <ImplicitUsings>enable</ImplicitUsings>

    <Nullable>enable</Nullable>

  </PropertyGroup>

  

</Project>
```

[[Início]]

