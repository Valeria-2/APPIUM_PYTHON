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
Una Vez realizada la limpieza <br><br>
| ![Captura de pantalla 2024-09-27 101745](https://github.com/user-attachments/assets/617472fd-b507-4d86-bf9a-a92288ece676) |
|--------------|

Y la compilación <br><br>
| ![Captura de pantalla 2024-09-27 101732](https://github.com/user-attachments/assets/e5bc1f0f-9e9e-4bd0-8485-72081d2a17b1) |
|-------------|

Procederemos a darle click en Ejecutar Pruebas <br><br>
| ![Captura de pantalla 2024-09-27 105944](https://github.com/user-attachments/assets/35904eb9-3229-4fd6-a045-792ea248d587) |
|-------------|

Se nos desplegaran varias cosas:
- El Exprorador de pruebas
| ![Captura de pantalla 2024-09-27 110353](https://github.com/user-attachments/assets/e71a931a-5d96-4e6d-a829-5d62fa485b25) |
|-------------|

- Varias pestañas de chrome que se cerraran automaticamente una vez finalizadas las pruebas.

Una vez terminadas las pruebas tendremos los siguientes resultados:

| Prueba | Descripcion |
|--------|-------------|
|![Captura de pantalla 2024-09-27 111256](https://github.com/user-attachments/assets/61bfb97e-f8d1-4fda-abda-c8f14d277a51) | Estas pruebas estan diseñadas para probar las funciones de selenium basicas |
| ![Captura de pantalla 2024-09-27 112313](https://github.com/user-attachments/assets/8281ad1a-6129-411b-a9e5-10013ad66880) | Estas pruebas dan error debido a que no se cuenta con las versiones requeridad de Edge y Firefox |
|![Captura de pantalla 2024-09-27 113446](https://github.com/user-attachments/assets/4fce892b-594c-4f38-916b-5c66deb72ea2) |Esta prueba tiene como funcion validar que se haya entrado a la pagina|
|![image](https://github.com/user-attachments/assets/43544ce7-329d-4837-b9d8-3d94489dcaa7) |Esta prueba realiza un click en el boton de LogIn|
|![Captura de pantalla 2024-09-27 113841](https://github.com/user-attachments/assets/09ff14d4-6b12-4589-99bf-6e99be948d12) | Estas pruebas validan que los usuarios con contraseña sean correctas, la diferencia radica es que en la primer prueba es con las credenciales directamente en el codigo y en la segunda es atravez de un archivo excel. Apesar de que se muestran errores estos esta programados para fallar |
|![Captura de pantalla 2024-09-27 114247](https://github.com/user-attachments/assets/a6650952-50dc-4570-9a2b-fec404c31c91) | Esta prueba entra a una pagina y compara que sea la misma |
|![Captura de pantalla 2024-09-27 114353](https://github.com/user-attachments/assets/5cd3d889-2909-4e3c-9a4f-ada02d818b7a) | Estra prueba realiza encritura y confirmacion  de usuario y contraseña en la pagina web. Esta diseñada para fallar en la primera prueba |
|![Captura de pantalla 2024-09-27 114802](https://github.com/user-attachments/assets/897a5217-397c-4197-90aa-60e2e0781f28) | Esta prueba lee un archivo Excel |









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
