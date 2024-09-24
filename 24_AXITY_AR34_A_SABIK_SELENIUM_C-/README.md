## Arquetipo Selenium 

Este repositorio cuenta con un arquetipo el cual está customizado para la generación de scripts automatizados basados en Selenium Web Driver, Csharp y NUnit como Framework de Testing. La estructura aquí presentada está diseñada con el objetivo de estandarizar la generación y mantenimiento del script automatizado basado en buenas practicas que dicta la industria.

## Instalación 

Para implementar el arquetipo se necesitas seguir los siguientes pasos:

1. Ingresar a la URL: https://github.com/Axitymx/24_AXITY_AR34_A_SABIK_SELENIUM_C-

2. Ingresar a la sección Code (Seleccionar alguna de las opciones para clonar el repositorio de manera local)
      - **Utilizando la URL**: https://github.com/Axitymx/24_AXITY_AR34_A_SABIK_SELENIUM_C-.git
      - **Utilizando la instrucción** gh repo clone Axitymx/24_AXITY_AR34_A_SABIK_SELENIUM_C-:
        - **Abrirlo con GitHub Desktop**
        - **Abrirlo con Visual Studio**
        - **Descargarlo con ZIP**
     

3. Una vez descargada la solución tendremos la siguiente estructura de carpetas:
      
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

5. Abrir el archivo "SeleniumArquetipo.sln" en el IDE Microsoft Visual Studio 2022 (Community, Professional o Enterprise).

6. En la sección de Explorador de Soluciones, se debe seleccionar el archivo raíz Selenium Arquetipo

7. Se debe dar clic derecho y seleccionar la opción Limpiar para prepararla solución para su compilación.

8. Se debe dar clic derecho y seleccionar la opción Compilar. (Cuando se compila la solución se debe validar que los paquetes Nuget de la sección de Dependencias se hayan descargado de manera satisfactoria). 

## Uso 

1. En la sección de Explorador de Soluciones, encontraremos las siguientes carpetas: 

    - **drivers**
    - **Insumos**
    - **main**
    - **main**

2. En la carpeta de drivers encontraremos los drivers necesarios para poder automatizar en los distintos navegadores como lo son Google Chrome, Mozilla FireFox y Microsoft Edge.

3. En la carpeta Insumos encontraremos dos subcarpetas, la primera A4 en donde están las imágenes correspondientes al layout que utilizará el reporte en su generación y la de Fonts que como su nombre lo dice son las fuentes utilizadas para la generación del reporte.

4. En la carpeta de main encontraremos las carpetas:

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

   - **screenshots**: En esta carpeta encontraremos los screenshot tomados para la generación del reporte
   
   - **test_cases**: Encontraremos 5 carpetas
   
     - **tc_botones**: Contiene una carpeta de Chrome: 

       - **TestSuiteBotones.cs**: 
       Contiene un caso de prueba de Selenium escrito en C#. Comienza inicializando una página web en un navegador Chrome y luego realiza una acción específica: hacer clic en un botón de inicio de sesión. Después de hacer clic, busca un elemento en la página correspondiente al mensaje de error que debería mostrarse si el inicio de sesión falla. Finalmente, verifica si el elemento está visible. Si no lo está, el caso de prueba falla. Este código forma parte de una suite de pruebas para probar la funcionalidad de los botones en una página web utilizando Selenium WebDriver.

     - **tc_data_driven**: Contiene 2 clases:

       - **TCDataDriven.cs**: 
       Se centra en verificar el proceso de inicio de sesión en una página web. Utiliza datos parametrizados para ejecutar varios casos de prueba. La prueba incluye pasos como acceder a la URL deseada, ingresar credenciales de usuario, verificar la correcta escritura de los datos, intentar iniciar sesión y confirmar la redirección a la página principal. Además, genera un informe detallado de cada paso y exporta los resultados a un archivo CSV. En esencia, automatiza y documenta exhaustivamente el proceso de prueba del inicio de sesión en la aplicación web.

       - **TestDataDrivenExcel.cs**: 
       Contiene un caso de prueba Selenium en C# que utiliza datos provenientes de un archivo Excel para realizar pruebas de inicio de sesión en una página web. La prueba verifica varios pasos, como acceder a la página de inicio de sesión, ingresar credenciales de usuario, y verificar la redirección a la página principal después del inicio de sesión. Además, genera un informe detallado de cada paso, incluyendo capturas de pantalla, y exporta los resultados a un archivo CSV. En resumen, automatiza y documenta exhaustivamente el proceso de prueba del inicio de sesión utilizando datos provenientes de un archivo Excel.

     - **tc_end_to_end**: Contiene una carpeta Chrome con 1 clase.

       - **TestSuiteChromeE2E.cs**: 
       Contiene un caso de prueba de extremo a extremo (end-to-end) en Selenium WebDriver. En este contexto, "end-to-end" se refiere a la prueba completa de una funcionalidad o flujo de trabajo desde el inicio hasta el final, imitando el comportamiento del usuario real. En este caso, el objetivo es simular el proceso completo de inicio de sesión en una página web, incluyendo la interacción del usuario con la interfaz gráfica, la introducción de credenciales, la validación de las acciones y la verificación del resultado final, que es la correcta redirección a la página principal después del inicio de sesión.

      - **tc_navegacion**: Contiene 2 carpetas, Chrome y Edge con 2 clases.

        - **TestSuiteChrome.cs**: 
        Contiene un caso de prueba NUnit en C# que verifica la navegación a una página web específica utilizando el navegador Chrome. Inicia una sesión en el sitio web proporcionado en la configuración y verifica si la URL coincide con la esperada para la página de inicio de sesión. Se utiliza WebDriverWait para asegurar que la página se cargue completamente antes de realizar la verificación. En resumen, este caso de prueba automatiza la comprobación de la navegación exitosa a una página web.

        - **TestSuiteEdge.cs**: 
        Contiene un caso de prueba NUnit en C# que utiliza el navegador Microsoft Edge para abrir una página web específica. Utiliza la clase BaseEdgeTest, que probablemente contenga configuraciones específicas para ejecutar pruebas en Microsoft Edge. El caso de prueba simplemente navega a la URL proporcionada en la configuración de WebConfig. En resumen, este caso de prueba automatiza la apertura de una página web en Microsoft Edge 

     - **tc_texto**: Contiene 1 carpeta Chrome con 1 clase:

       - **TestSuiteText.cs**: 
       Contiene en tres casos de prueba NUnit en C#, cada uno probando diferentes escenarios relacionados con la escritura de datos en un formulario de inicio de sesión. Cada prueba realiza acciones como navegar a la página de inicio de sesión, ingresar un nombre de usuario o contraseña (válido o inválido), y luego verificar si los datos se ingresaron correctamente. También genera un informe detallado de cada paso, incluyendo capturas de pantalla, y exporta los resultados a un archivo CSV. En resumen, estos casos de prueba automatizan y documentan la interacción con un formulario de inicio de sesión en una aplicación web


   - **test_data**: contiene 1 carpeta excel con 1 clase y 1 archivo de excel:

     - **DataLogin.xlsx** 
     es un archivo de excel donde se almacenan los datos de prueba que se usaran para data provider, se puede modificar para incrementar o disminuir los casos de prueba.

     -  **Excel.cs** 
     es un método de prueba NUnit que lee un archivo Excel y muestra los datos contenidos en él en la consola. Este tipo de prueba puede ser útil para verificar si los datos en el archivo Excel son correctos y coinciden con lo esperado. Sin embargo, este método no realiza ninguna aserción formal sobre los datos leídos, por lo que es necesario agregar aserciones adicionales según sea necesario para validar los datos. En este mismo podemos encontrar el archivo DataLogin.xlsx que se utilizara como un insumo para la generación de las iteraciones a la hora de la ejecución de los scripts automatizados.
     
   
   - **test_report**
   
     - **Lectura Archivos**: En resumen, esta clase proporciona funcionalidad para leer un archivo CSV que contiene datos de informes de pruebas y convertir cada línea del archivo en objetos ReportModel, que contienen información específica de cada informe de prueba.

     - **Models**: En resumen, esta clase proporciona una estructura de datos para almacenar información detallada sobre los informes de prueba, incluyendo detalles sobre el proyecto, la ejecución, los casos de prueba y los resultados de los pasos de prueba.

     - **Utility**: Estas constantes proporcionan nombres y textos predefinidos que se utilizan en la generación de informes de pruebas automatizadas, lo que hace que el proceso de generación de informes sea más consistente y fácil de mantener.

     - **CreateCSV.cs**: 
     Proporciona funcionalidad para crear un archivo CSV a partir de una lista de modelos de informe. El método CreatFile recibe la ruta del archivo y la lista de modelos de informe. Luego, itera sobre cada modelo de informe y construye una fila de datos en el archivo CSV. Cada fila contiene información como el nombre del proyecto, el tiempo de ejecución, la fecha de inicio y fin de la ejecución, el estado de ejecución, las precondiciones, el nombre y descripción del caso de prueba, el nombre del script, la descripción del paso, el resultado del paso, el estatus del paso y la ruta de entrada. Estos datos se escriben en el archivo CSV separados por comas, lo que permite su fácil lectura y procesamiento posterior. Este proceso de creación de archivos CSV es útil para generar informes estructurados y legibles sobre la ejecución de pruebas automatizadas en entornos de desarrollo y pruebas.

     - **CreateReport.cs** 
     se encarga de generar un informe en formato PDF a partir de los datos proporcionados en un archivo CSV. Este informe incluye información detallada sobre la ejecución de pruebas automatizadas realizadas con Appium, como el nombre del proyecto, el tiempo de ejecución, la fecha de inicio y fin de la ejecución, el estado de la ejecución, las precondiciones, el nombre del caso de prueba, la descripción del caso de prueba, el nombre del script, la descripción del paso, el resultado del paso, el estado del paso y la ruta de entrada. 
     Para la generación del PDF, se utilizan las librerías iText para manejar el formato y el diseño del documento. Se crea una tabla que contiene los datos generales del proyecto, como el nombre, el tiempo de ejecución y las precondiciones. Luego, se agregan secciones para la descripción del caso de prueba y los detalles de los pasos ejecutados, incluyendo su descripción, resultado y evidencia en forma de imágenes. Ee incluyen elementos visuales como un encabezado, un logotipo y una base gráfica para mejorar la presentación del informe. Se utilizan diferentes colores y estilos de fuente para resaltar la información importante y mejorar la legibilidad del documento. Finalmente, se añade un número de página en la parte inferior de cada página del informe para facilitar la navegación y la referencia en caso de ser necesario. El informe se guarda en la ubicación especificada y se devuelve la ruta del archivo generado.

## Configuración 

  Es de vital importancia que los paquetes Nuget se han instalado de forma satisfactoria. Respecto a las configuraciones fueron detalladas a nivel de cada uno de los archivos aquí mencionados.

## Ejemplos 

  En la sección Example, encontraremos la clase UnitTest1.cs, esta clase de prueba NUnit realiza una prueba simple donde abre una URL específica en el navegador Chrome y luego cierra el navegador al finalizar la prueba. Este tipo de estructura de prueba es comúnmente utilizada para realizar pruebas de funcionalidades básicas de un sitio web utilizando Selenium WebDriver y NUnit. Adicionalmente en la clase WaitsExameple.cs, demuestran diferentes formas de implementar esperas en Selenium WebDriver para manejar la sincronización en pruebas automatizadas, desde retrasos estáticos hasta esperas implícitas y explícitas más sofisticadas
  
## Contribución 
  Si la solución es de código abierto, incluye pautas sobre cómo contribuir al proyecto, como instrucciones para enviar solicitudes de extracción, reportar problemas, etc.
  
  Para realizar contribuciones a este proyecto se debe realizar un backup de la solución de manera local para que se adapte a las necesidades del proyecto en donde se desea implementar

## Créditos 
  ---Mauricio Gurrola Sánchez
  ---Gustavo David Ramírez Ledesma
  ---Osvaldo Alfredo Zamora Reyes

## Licencia 

// Especifica la licencia bajo la cual se distribuye la solución y cualquier otra información legal relevante.

## Contacto

  ---Mauricio Gurrola Sánchez         mauricio.gurrola@axity.com
  ---Gustavo David Ramírez Ledesma    gustavo.ramirez@axity.com
  ---Osvaldo Alfredo Zamora Reyes     osvaldo.zamor@axity.com
