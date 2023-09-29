# Template Solidaria

Este template es para crear una aplicación con una arquitectura limpia. El template está diseñado para los servicios backend de Aseguradora Solidaria.

## Estructura del Proyecto

El proyecto se divide en varias capas, cada una con su propio propósito:

- `src\Application`: Contiene la lógica de la aplicación y coordina las interacciones entre las otras capas.
- `src\Domain`: Contiene la lógica de negocio y las entidades del dominio.
- `src\Infrastructure`: Contiene la lógica para interactuar con recursos externos, como bases de datos y servicios web.

Cada capa tiene su propio proyecto en la solución:

- `Application.Host`: Este es el proyecto principal que ejecuta la aplicación.
- `Domain.Model`: Este proyecto contiene las entidades del dominio.
- `Domain.UseCase`: Este proyecto contiene la lógica de negocio.
- `Infrastructure.EntryPoints`: Este proyecto contiene los puntos de entrada a la aplicación, como controladores web.
- `Infrastructure.DrivenAdapters`: Este proyecto contiene adaptadores para interactuar con recursos externos.

## Instalacion el template

Es necesario configurar las fuentes de los paquetes para poder descargarlos de Azure Artifacts.

# IMPORTANTE ⚠️

Es necesario instalar el credential provider de azure para poder descargar los paquetes de artifacts.

Para instalarlo ejecuta en powershell esta expresión (Herramintas > Linea de comandos > Powershell)

```powershell
iex "& { $(irm https://aka.ms/install-artifacts-credprovider.ps1) }"
```

![commandLine menu](assets/0.jpg)
![pwsh expression](assets/pwsh.jpg)

Para más información visita su repositorio de [github](https://github.com/microsoft/artifacts-credprovider#setup)

---

Primero necesitamos saber el nombre y la url del feed que vamos a agregar. Esto lo podemos consultar en azure artifacts.

![azure aritfacts](assets/1.jpg)
![azure aritfacts](assets/2.jpg)
![azure aritfacts](assets/3.jpg)

---

Ahora tomamos el name y el source y lo agregamos a nuestra configuracion de visual studio.

Para ello simplemente tenemos que seguir los pasos que vemos en las imagenes. (Herramientas > Administrador de paquetes NuGet > Configuración del Administrador de paquetes)
![Alt config packageSource](assets/4.jpg)

---

Nos dirigimos a la pestaña de "Orígenes de paquetes" y agregamos el nombre y la url del feed que vamos a agregar presionando el boton "+". Estos deben coincidir con los que vimos en azure artifacts.

# IMPORTANTE ⚠️

Debes aceptar los cambios antes de ir al siguiente paso. Sino no aparecerá el feed que acabamos de agregar.

![Alt config packageSource](assets/5.jpg)

---

Ahora nos dirigimos a la sección "Package Source Mapping" para configurar el feed que acabamos de agregar. Para ello presionamos Add y ponemos tal cual aparece en la imagen. Esto nos permitirá descargar los paquetes de nuget.org y de nuestro feed. En pocas palabras, todos los paquetes que empiecen con "Solidaria" se descargarán de nuestro feed. Los demás se descargarán de nuget.org.
![Alt config packageSource](assets/6.jpg)
![Alt config packageSource](assets/7.jpg)

---

Ahora necesitamos instalar el template. Para ello utilizaremos una terminal de comandos. (Herramientas > Linea de comandos > Simbolo del sistema para desarrolladores)
![Alt config packageSource](assets/8.jpg)

---

Ahora ponemos el siguiente comando para instalar el template.
dotnet new install <NombreDelPaquete>. En ste caso concreto sería

```powershell
dotnet new install Solidaria.WebApp.Solution.Template
```

![Alt config packageSource](assets/9.jpg)

La salida el comando anterior debería ser algo como esto:

![Alt config packageSource](assets/10.jpg)

Ahora ya podemos crear proyectos con la plantilla a través del asistente de visual studio.
![Alt config packageSource](assets/11.jpg)

```

Template
├── Directory.Build.props
├── Directory.Packages.props
├── README.md
├── TemplateSolidaria.nuspec
├── TemplateSolidaria.sln
└── src
    ├── Application
    │   └── Application.Host
    │       ├── Application.Host.csproj
    │       ├── Dockerfile
    │       ├── Program.cs
    │       ├── Properties
    │       │   └── launchSettings.json
    │       ├── appsettings.Development.json
    │       └── appsettings.json
    ├── Domain
    │   ├── Domain.Model
    │   │   └── Domain.Model.csproj
    │   └── Domain.UseCase
    │       └── Domain.UseCase.csproj
    ├── Infrastructure
    │   ├── DrivenAdapters
    │   │   └── DrivenAdapter.SqlServer
    │   │       └── DrivenAdapter.SqlServer.csproj
    │   └── EntryPoints
    │       └── EntryPoint.Web
    │           ├── Controllers
    │           │   └── Example.cs
    │           └── EntryPoint.Web.csproj
    └── Test
        └── TestProject1
            ├── TestProject1.csproj
            ├── UnitTest1.cs
            └── Usings.cs

15 directories, 19 files

```
