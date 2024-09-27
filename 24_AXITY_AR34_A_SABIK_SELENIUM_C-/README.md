## Arquetipo Selenium 

Este repositorio contiene un arquetipo personalizado para la generación de scripts automatizados utilizando Selenium Web Driver, C# y NUnit como framework de testing. La estructura propuesta está diseñada con el objetivo de estandarizar la creación y el mantenimiento de scripts automatizados, siguiendo las buenas prácticas recomendadas por la industria.

## Índice

1. [Istalacion](#Instalación)
2. [Uso](#Uso)
3. [Configuración](#Configuración)
4. [Ejemplos](#Ejemplos)
5. [Contribución](#Contribución)
6. [Créditos](#Créditos)
7. [Licencia](#Licencia)
8. [Contacto](#Contacto)

## Instalación 
Las versiones requeridas y probadas para su implementación son:  
- Visual Studio 2022 <br>
  https://visualstudio.microsoft.com/es/ 
- GitHub <br>
  https://git-scm.com/downloads
- Chrome 124

1. Ubicados sobre la direccion donde queremos almacenar el proyectp, debemos abrir un simbolo de sistema
   donde ejecutaremos el siguiente codigo: <br>

            git clone https://github.com/Valeria-2/APPIUM_PYTHON.git

2. Una vez clonado el repositorio: <br>
   1. Abrir la carpeta *_ 24_AXITY_AR34_A_SABIK_SELENIUM_C- _*
   2. Entrar a la carpeta *_SeleniumArquetipo_*
   3. Localizar el archivo *_SeleniumArquetipo.sln_* y abrirlo con _Visual Studio 2024_
     
3. En la sección de Explorador de Soluciones: <br>
   1. Se debe seleccionar el archivo raíz Selenium Arquetipo
   2. Se debe dar clic derecho y seleccionar la opción **Limpiar**
   3. Se debe dar clic derecho y seleccionar la opción **Compilar**

NOTA : Cuando se compila la solución se debe validar que los paquetes Nuget de la sección de Dependencias se hayan descargado de manera satisfactoria. 

## Uso 


## Configuración 

  Es de vital importancia que los paquetes Nuget se han instalado de forma satisfactoria. Respecto a las configuraciones fueron detalladas a nivel de cada uno de los archivos aquí mencionados.

## Ejemplos 


  1. UnitTest1.cs <br>
Esta clase de prueba NUnit realiza una prueba simple donde abre una URL específica en el navegador Chrome y luego cierra el navegador al finalizar la prueba. Este tipo de estructura de prueba es comúnmente utilizada para realizar pruebas de funcionalidades básicas de un sitio web utilizando Selenium WebDriver y NUnit. 
  
  2. WaitsExameple.cs <br>
Demuestran diferentes formas de implementar esperas en Selenium WebDriver para manejar la sincronización en pruebas automatizadas, desde retrasos estáticos hasta esperas implícitas y explícitas más sofisticadas
  
## Contribución <br>
  Si la solución es de código abierto, incluye pautas sobre cómo contribuir al proyecto, como instrucciones para enviar solicitudes de extracción, reportar problemas, etc.
  
  Para realizar contribuciones a este proyecto se debe realizar un backup de la solución de manera local para que se adapte a las necesidades del proyecto en donde se desea implementar

## Créditos <br>
- Mauricio Gurrola Sánchez
- Gustavo David Ramírez Ledesma
- Osvaldo Alfredo Zamora Reyes

## Licencia <br>

Especifica la licencia bajo la cual se distribuye la solución y cualquier otra información legal relevante.

## Contacto <br>

- Mauricio Gurrola Sánchez (mauricio.gurrola@axity.com)
- Gustavo David Ramírez Ledesma (gustavo.ramirez@axity.com)
- Osvaldo Alfredo Zamora Reyes (osvaldo.zamor@axity.com)
