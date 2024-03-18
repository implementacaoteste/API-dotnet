Esse exemplo para ser utilizando com WSL rodando Ubuntu

```
sudo apt update && sudo apt upgrade
```

O comando abaixo vai retornar a versão do Ubuntu para ser usada no próximo script
```
lsb_release -rs
```

```
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
```

```
sudo dpkg -i packages-microsoft-prod.deb
```

```
sudo apt update
sudo apt install -y apt-transport-https
sudo apt update
sudo apt install -y dotnet-sdk-8.0
```

```
dotnet --version
```

[[Início]]

