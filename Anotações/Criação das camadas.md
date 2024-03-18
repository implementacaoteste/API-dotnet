```
dotnet new webapi -n API
```

```
dotnet new classlib -n BLL
```

```
dotnet new classlib -n DAL
```

```
dotnet new classlib -n Models
```

## Adicionando as referências aos projetos

```
cd API
dotnet add reference ../BLL
dotnet add reference ../Models
```

```
cd ../BLL
dotnet add reference ../DAL
dotnet add reference ../Models
```

```
cd ../DAL
dotnet add reference ../Models
```

[[Início]]


