<h4 align="center">Unit Test Project con .Net Core 3.1 (dotnet)</h4>

Se realizo un unit test basico a un proyecto llamado 'helloworld' que contiene un unico metodo que se pondra a prueba, a este metodo le enviamos como argumento un numero entero ya sea positivo o negativo y nos devuelve un true si es mayor a 0 o un false si es menor a 0.

En el unit test el resultado esperado es un true.
### 📌 Requisitos a tomar en cuenta
 - `.NET Core 3.1`
 - `VsCode`

### 🌎️ Paquetes Utilizados(Los siguientes paquetes vienen instalados por defecto en dotnet 3.1)
 - `coverlet.collector=1.2.0`
 - `Microsoft.NET.Test.Sdk=16.5.0`
 - `MSTest.TestAdapter=2.1.0`
 - `MSTest.TestFramework=2.1.0` 

### 🚨️ Extras
 - `Se descargo la extension de C# en VsCode para poder correr la app`
 - `Para utilizar una clase de un proyecto A en un proyecto B se utiliza el siguiente comando: dotnent add reference "direccion del otro proyecto/se agrega el archivo .csproj"`
 - `Ejemplo del comando utilizado para este proyecto: dotnet add reference ../helloworld/helloworld.csproj`
