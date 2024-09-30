## Arquetipo Selenium 

Este repositorio contiene un arquetipo personalizado para la generación de scripts automatizados utilizando Selenium Web Driver, C# y NUnit como framework de testing. La estructura propuesta está diseñada con el objetivo de estandarizar la creación y el mantenimiento de scripts automatizados, siguiendo las buenas prácticas recomendadas por la industria.

## Índice

1. [Istalacion](#Instalación)
2. [Uso](#Uso)
3. [Estructura](#Estructura)
4. [Descripcion](#Descripcion)
5. [Configuración](#Configuración)
6. [Ejemplos](#Ejemplos)
7. [Contribución](#Contribución)
8. [Créditos](#Créditos)
9. [Licencia](#Licencia)
10. [Contacto](#Contacto)

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
    - Abrir la carpeta *_ 24_AXITY_AR34_A_SABIK_SELENIUM_C- _*
    - Entrar a la carpeta *_SeleniumArquetipo_*
    - Localizar el archivo *_SeleniumArquetipo.sln_* y abrirlo con _Visual Studio 2024_
     
3. En la sección de Explorador de Soluciones: <br>
   - Se debe seleccionar el archivo raíz Selenium Arquetipo
   - Se debe dar clic derecho y seleccionar la opción **Limpiar**
   - Se debe dar clic derecho y seleccionar la opción **Compilar**

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

Se nos desplegaran varias cosas:<br><br>
1. El Exprorador de pruebas <br><br>


| ![Captura de pantalla 2024-09-27 110353](https://github.com/user-attachments/assets/e71a931a-5d96-4e6d-a829-5d62fa485b25) |
|-------------|

2. Varias pestañas de chrome que se cerraran automaticamente una vez finalizadas las pruebas.

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

## Estructura
A continuacion se muestra la estructura que posee el proyecto <br>
      
- **SeleniumArquetipo**: Directorio raíz del proyecto.
  - **vs.**: Ejemplos de uso del proyecto.
  - **example**: Ejemplos de uso del proyecto.
  - **src**: Código fuente del proyecto.
    - **drivers**: Controladores de Selenium.
    - **Insumos**: Recursos adicionales del proyecto.
      - **A4**: Archivos de tipo A4.
      - **Fonts**: Fuentes utilizadas en el proyecto.
    - **main**: Código principal del proyecto.
      - **config**: Configuraciones del proyecto.
      - **core**: Funcionalidades principales.
      - **pages**: Páginas web a interactuar.
      - **utils**: Utilidades y acciones auxiliares.
        - **actions**: metodos utile para la validaciones y ayudantes.
    - **test**: Pruebas del proyecto.
      - **screenshots**: Capturas de pantalla de las pruebas.
      - **test_cases**: Casos de prueba organizados por tipo.
        - **tc_botones**: Casos de prueba relacionados con botones.
          - **Chrome**: Casos de prueba específicos para Chrome.
        - **tc_data_driven**: Casos de prueba relacionado a data provider
        - **tc_end_to_end**: Casos de prueba de punta a punta
          - **Chrome**: Casos de prueba específicos para Chrome.
        - **tc_navegacion**: Casos de prueba para navegación
        - **tc_texto**: Casos de prueba para textos
          - **Chrome**: Casos de prueba específicos para Chrome.
      - **test_data**: Datos utilizados en las pruebas.
        - **excel**: Datos en formato Excel.
      - **test_report**: Informes de las pruebas.
        - **lectura_archivos**: Clase para leer CSV
        - **models**: Modelo para el Reporte
        - **utility**: Clase de utilidad para la generación del reporte.
  - **bin/Debug/net6.0**: Directorio de salida de compilación del proyecto.
  - **obj**: Directorio de objetos generados durante la compilación.

## Descripcion
A continuacion se describe a detalle la funcionalidad de cada parte de la estructura: <br>

1. En la sección de **Explorador de Soluciones**, encontraremos las siguientes carpetas: 

    - **drivers**
    - **Insumos**
    - **main**
    - **main**

2. En la carpeta de **drivers** encontraremos los drivers necesarios para poder automatizar en los distintos navegadores como lo son Google Chrome, Mozilla FireFox y Microsoft Edge.

3. En la carpeta **Insumos** encontraremos dos subcarpetas, la primera A4 en donde están las imágenes correspondientes al layout que utilizará el reporte en su generación y la de Fonts que como su nombre lo dice son las fuentes utilizadas para la generación del reporte.

4. En la carpeta de **main** encontraremos las carpetas:

   - **config**: <br>
   En la clase WebConfig.cs, actúa como un contenedor para almacenar configuraciones relacionadas con la URL del sitio web que se está probando. Al definir esta configuración de URL como una propiedad estática en una clase separada, permite que la URL sea fácilmente accesible y modificable desde otras partes del código sin necesidad de cambiar el valor directamente en cada lugar donde se utiliza la URL. Esto hace que el código sea más modular y fácil de mantener.

   - **core**: <br>
   Las clases BaseChromeTest.cs, BaseEdgeTest.cs y BaseTestFirefox.cs actúan como una abstracción para la configuración y finalización del controlador de Google Chrome, Microsoft Edge y Mozilla FireFox, lo que permite que las pruebas se centren en la lógica de la aplicación sin preocuparse por la inicialización y limpieza del navegador. Además, proporciona métodos auxiliares para iniciar el navegador con configuraciones específicas, como una versión específica del navegador.

   - **pages**: <br>
   En resumen, la clase LogInPage.cs proporciona métodos para interactuar con los elementos de la página de inicio de sesión, como ingresar credenciales de usuario y hacer clic en el botón de inicio de sesión, y también proporciona un método para verificar si la página de inicio de sesión está completamente cargada, mientras que la clase MainPage.cs permite interactuar con elementos específicos en la página principal de un sitio web, incluido el ingreso de un nombre en un campo de entrada después de haber iniciado sesión con un usuario específico.

   - **util**: <br>
   En resumen, la clase Actions.cs proporciona una abstracción para realizar acciones comunes en páginas web utilizando Selenium WebDriver, lo que permite un código más limpio y mantenible al encapsular la lógica de Selenium en métodos reutilizables mientras que la clase DataHelper.cs proporciona una forma conveniente de leer datos de un archivo Excel y utilizarlos como casos de prueba en pruebas automatizadas. Esto puede ser útil para realizar pruebas de datos múltiples o pruebas de regresión con conjuntos de datos variados. 
   
   La clase constantes.cs proporciona un lugar centralizado para definir y acceder a constantes utilizadas en todo el proyecto, lo que facilita la modificación y la consistencia en el uso de estos valores en diferentes partes del código. Las constantes definidas aquí pueden ser referenciadas desde otras clases dentro del proyecto para evitar la repetición de valores literales en el código y mejorar la legibilidad y mantenibilidad del mismo.

5. En la carpeta de test encontraremos las carpetas:

   - **screenshots**:<br> 
   En esta carpeta encontraremos los screenshot tomados para la generación del reporte
   
   - **test_cases**:<br> 
   Encontraremos 5 carpetas
   
     - **tc_botones**:<br> Contiene una carpeta de Chrome: 

       - **TestSuiteBotones.cs**:<br> 
       Contiene un caso de prueba de Selenium escrito en C#. Comienza inicializando una página web en un navegador Chrome y luego realiza una acción específica: hacer clic en un botón de inicio de sesión. Después de hacer clic, busca un elemento en la página correspondiente al mensaje de error que debería mostrarse si el inicio de sesión falla. Finalmente, verifica si el elemento está visible. Si no lo está, el caso de prueba falla. Este código forma parte de una suite de pruebas para probar la funcionalidad de los botones en una página web utilizando Selenium WebDriver.

     - **tc_data_driven**: <br>
     Contiene 2 clases:

       - **TCDataDriven.cs**:<br> 
       Se centra en verificar el proceso de inicio de sesión en una página web. Utiliza datos parametrizados para ejecutar varios casos de prueba. La prueba incluye pasos como acceder a la URL deseada, ingresar credenciales de usuario, verificar la correcta escritura de los datos, intentar iniciar sesión y confirmar la redirección a la página principal. Además, genera un informe detallado de cada paso y exporta los resultados a un archivo CSV. En esencia, automatiza y documenta exhaustivamente el proceso de prueba del inicio de sesión en la aplicación web.

       - **TestDataDrivenExcel.cs**: <br>
       Contiene un caso de prueba Selenium en C# que utiliza datos provenientes de un archivo Excel para realizar pruebas de inicio de sesión en una página web. La prueba verifica varios pasos, como acceder a la página de inicio de sesión, ingresar credenciales de usuario, y verificar la redirección a la página principal después del inicio de sesión. Además, genera un informe detallado de cada paso, incluyendo capturas de pantalla, y exporta los resultados a un archivo CSV. En resumen, automatiza y documenta exhaustivamente el proceso de prueba del inicio de sesión utilizando datos provenientes de un archivo Excel.

     - **tc_end_to_end**: <br>
     Contiene una carpeta Chrome con 1 clase.

       - **TestSuiteChromeE2E.cs**:<br> 
       Contiene un caso de prueba de extremo a extremo (end-to-end) en Selenium WebDriver. En este contexto, "end-to-end" se refiere a la prueba completa de una funcionalidad o flujo de trabajo desde el inicio hasta el final, imitando el comportamiento del usuario real. En este caso, el objetivo es simular el proceso completo de inicio de sesión en una página web, incluyendo la interacción del usuario con la interfaz gráfica, la introducción de credenciales, la validación de las acciones y la verificación del resultado final, que es la correcta redirección a la página principal después del inicio de sesión.

      - **tc_navegacion**: <br>
      Contiene 2 carpetas, Chrome y Edge con 2 clases.

        - **TestSuiteChrome.cs**:<br> 
        Contiene un caso de prueba NUnit en C# que verifica la navegación a una página web específica utilizando el navegador Chrome. Inicia una sesión en el sitio web proporcionado en la configuración y verifica si la URL coincide con la esperada para la página de inicio de sesión. Se utiliza WebDriverWait para asegurar que la página se cargue completamente antes de realizar la verificación. En resumen, este caso de prueba automatiza la comprobación de la navegación exitosa a una página web.

        - **TestSuiteEdge.cs**: <br>
        Contiene un caso de prueba NUnit en C# que utiliza el navegador Microsoft Edge para abrir una página web específica. Utiliza la clase BaseEdgeTest, que probablemente contenga configuraciones específicas para ejecutar pruebas en Microsoft Edge. El caso de prueba simplemente navega a la URL proporcionada en la configuración de WebConfig. En resumen, este caso de prueba automatiza la apertura de una página web en Microsoft Edge 

     - **tc_texto**: <br>
     Contiene 1 carpeta Chrome con 1 clase:

       - **TestSuiteText.cs**: <br>
       Contiene en tres casos de prueba NUnit en C#, cada uno probando diferentes escenarios relacionados con la escritura de datos en un formulario de inicio de sesión. Cada prueba realiza acciones como navegar a la página de inicio de sesión, ingresar un nombre de usuario o contraseña (válido o inválido), y luego verificar si los datos se ingresaron correctamente. También genera un informe detallado de cada paso, incluyendo capturas de pantalla, y exporta los resultados a un archivo CSV. En resumen, estos casos de prueba automatizan y documentan la interacción con un formulario de inicio de sesión en una aplicación web


   - **test_data**: <br>
   contiene 1 carpeta excel con 1 clase y 1 archivo de excel:

     - **DataLogin.xlsx** <br>
     Es un archivo de excel donde se almacenan los datos de prueba que se usaran para data provider, se puede modificar para incrementar o disminuir los casos de prueba.

     -  **Excel.cs** <br>

     Es un método de prueba NUnit que lee un archivo Excel y muestra los datos contenidos en él en la consola. Este tipo de prueba puede ser útil para verificar si los datos en el archivo Excel son correctos y coinciden con lo esperado. Sin embargo, este método no realiza ninguna aserción formal sobre los datos leídos, por lo que es necesario agregar aserciones adicionales según sea necesario para validar los datos. En este mismo podemos encontrar el archivo DataLogin.xlsx que se utilizara como un insumo para la generación de las iteraciones a la hora de la ejecución de los scripts automatizados.
     
   
   - **test_report**
   
     - **Lectura Archivos**: <br>
     
     En resumen, esta clase proporciona funcionalidad para leer un archivo CSV que contiene datos de informes de pruebas y convertir cada línea del archivo en objetos ReportModel, que contienen información específica de cada informe de prueba.

     - **Models**: <br>
     
     En resumen, esta clase proporciona una estructura de datos para almacenar información detallada sobre los informes de prueba, incluyendo detalles sobre el proyecto, la ejecución, los casos de prueba y los resultados de los pasos de prueba.

     - **Utility**: <br>
     
     Estas constantes proporcionan nombres y textos predefinidos que se utilizan en la generación de informes de pruebas automatizadas, lo que hace que el proceso de generación de informes sea más consistente y fácil de mantener.

     - **CreateCSV.cs**: <br>

     Proporciona funcionalidad para crear un archivo CSV a partir de una lista de modelos de informe. El método CreatFile recibe la ruta del archivo y la lista de modelos de informe. Luego, itera sobre cada modelo de informe y construye una fila de datos en el archivo CSV. Cada fila contiene información como el nombre del proyecto, el tiempo de ejecución, la fecha de inicio y fin de la ejecución, el estado de ejecución, las precondiciones, el nombre y descripción del caso de prueba, el nombre del script, la descripción del paso, el resultado del paso, el estatus del paso y la ruta de entrada. Estos datos se escriben en el archivo CSV separados por comas, lo que permite su fácil lectura y procesamiento posterior. Este proceso de creación de archivos CSV es útil para generar informes estructurados y legibles sobre la ejecución de pruebas automatizadas en entornos de desarrollo y pruebas.

    - **CreateReport.cs** :<br>

     Se encarga de generar un informe en formato PDF a partir de los datos proporcionados en un archivo CSV. Este informe incluye información detallada sobre la ejecución de pruebas             automatizadas realizadas con Appium, como el nombre del proyecto, el tiempo de ejecución, la fecha de inicio y fin de la ejecución, el estado de la ejecución, las precondiciones, el nombre del caso de prueba, la descripción del caso de prueba, el nombre del script, la descripción del paso, el resultado del paso, el estado del paso y la ruta de entrada.
     <br><br>
     Para la generación del PDF, se utilizan las librerías iText para manejar el formato y el diseño del documento. Se crea una tabla que contiene los datos generales del proyecto, como el nombre, el tiempo de ejecución y las precondiciones. Luego, se agregan secciones para la descripción del caso de prueba y los detalles de los pasos ejecutados, incluyendo su descripción, resultado y evidencia en forma de imágenes. Ee incluyen elementos visuales como un encabezado, un logotipo y una base gráfica para mejorar la presentación del informe. Se utilizan diferentes colores y estilos de fuente para resaltar la información importante y mejorar la legibilidad del documento. Finalmente, se añade un número de página en la parte inferior de cada página del informe para facilitar la navegación y la referencia en caso de ser necesario. El informe se guarda en la ubicación especificada y se devuelve la ruta del archivo generado.

## Configuración 
El arquetipo esta construido para descargar NuGet especificos a la version que requiera el poyecto. Sin embargo la siguiente lista se encuantran las versiones de los mismo que se utilizaron:
- DotNetSeleniumExtras.WaitHelpers  Version= 3.11.0  
- EPPlus  Version= 7.1.1  
- ExcelDataReader  Version= 3.6.0  
- ExcelDataReader.DataSet  Version= 3.6.0  
- itext7  Version= 8.0.3  
- Microsoft.NET.Test.Sdk  Version= 17.9.0  
- NUnit  Version= 4.1.0  
- NUnit3TestAdapter  Version= 4.5.0  
- NUnit.Analyzers  Version= 4.1.0 >
- coverlet.collector  Version= 6.0.2 >
- Selenium.Firefox.WebDriver  Version= 0.27.0  
- Selenium.Mozilla.Firefox.Webdriver  Version= 0.6.0.1  
- Selenium.Support  Version= 4.19.0  
- Selenium.WebDriver  Version= 4.19.0  
- Selenium.WebDriver.GeckoDriver  Version= 0.34.0  
- SeleniumExtras.WaitHelpers  Version= 1.0.2  
- SeleniumProxyAuthentication.Firefox  Version= 1.0.2  
- Sl.Selenium.Extensions.Firefox  Version= 2.3.0  

  

## Ejemplos 
En esta sección se presentan diversos ejemplos prácticos que demuestran el uso y las capacidades del proyecto.

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

### Este  ARTE forma parte del CReA de Axity, para mas informacion visitar [CReA] <br>
https://intellego365.sharepoint.com/sites/CentralAxity/Corporativo/CReA/SitePages/Home.aspx?xsdata=MDV8MDJ8fGUwYzYzYzgwOGNmZjRjMzIyY2JhMDhkY2UxNjg5ZmU0fDAwYTA1Y2UwYmQzZDQyMTVhNTY5YzYyNjFhMjBhMzllfDB8MHw2Mzg2MzMwODY2NTUxNDcxOTR8VW5rbm93bnxWR1ZoYlhOVFpXTjFjbWwwZVZObGNuWnBZMlY4ZXlKV0lqb2lNQzR3TGpBd01EQWlMQ0pRSWpvaVYybHVNeklpTENKQlRpSTZJazkwYUdWeUlpd2lWMVFpT2pFeGZRPT18MXxMMk5vWVhSekx6RTVPbTFsWlhScGJtZGZUVWRGZWsweVdtbE5hbGwwV2tkS2FFNURNREJOTWxGNlRGUm5kMXBYU1hSTk1rbDNUMVJqZDFsdFVtaE5iVlpxUUhSb2NtVmhaQzUyTWk5dFpYTnpZV2RsY3k4eE56STNOekV4T0RZME56UTB8N2YzMGEyNjYxOTIzNGJkYTJjYmEwOGRjZTE2ODlmZTR8NjE3Y2VhMTRlZDA3NDY3ZGI1OWQxNDdjNGQ0OWY2NGI%3D&sdata=Yk5iaWpjWkoycW13ODdENUI1b05nNTFyRzI2bnlBUkJOZ1RCM0tYUU1QVT0%3D&ovuser=00a05ce0-bd3d-4215-a569-c6261a20a39e%2CAndres.CortesG%40axity.com&OR=Teams-HL&CT=1727711996589&clickparams=eyJBcHBOYW1lIjoiVGVhbXMtRGVza3RvcCIsIkFwcFZlcnNpb24iOiI0OS8yNDA4MTcwMDQyMSIsIkhhc0ZlZGVyYXRlZFVzZXIiOmZhbHNlfQ%3D%3D <br>
![image](https://github.com/user-attachments/assets/ed6f45b4-446f-45f1-9f02-e640750f5d1d) 

