# DataBeef
Proyecto en C#

## Comandos útiles

### 1. Mark of the Web
Busca todos los archivos y carpetas dentro de la carpeta actual (.) y en todas sus subcarpetas (por el -Recurse). Toma cada uno de esos archivos y les quita el bloqueo de seguridad que Windows les pone cuando vienen de internet (el famoso "Mark of the Web"):
```powershell
Get-ChildItem -Path . -Recurse | Unblock-File
```

### 2. Restaurar paquetes de Nuget
```powershell
dotnet nuget locals all --clear
```
```powershell
Remove-Item -Recurse -Force .\packages -ErrorAction SilentlyContinue
```
```powershell
Update-Package -Reinstall
```

## Agradecimientos
Íconos de:

https://phosphoricons.com

https://lucide.dev
