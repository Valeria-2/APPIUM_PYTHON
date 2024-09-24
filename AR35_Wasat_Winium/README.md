#################### Arquetipo Winium & SikuliX ####################

Este repositorio cuenta con un arquetipo el cual está customizado para la generación de scripts automatizados basados en Winium, SikuliX, Csharp y NUnit como Framework de Testing. La estructura aquí presentada está diseñada con el objetivo de estandarizar la generación y mantenimiento del script automatizado basado en buenas practicas que dicta la industria.

#################### Instalación ####################

Para implementar el arquetipo se necesitas seguir los siguientes pasos:

1. Ingresar a la URL: https://github.com/Axitymx/24_AXITY_AR35_A_WASAT_WINIUM_C-

2. Ingresar a la sección Code (Seleccionar alguna de las opciones para clonar el repositorio de manera local)
      - ** Utilizando la URL** https://github.com/Axitymx/24_AXITY_AR35_A_WASAT_WINIUM_C-.git por HTTPS
      - ** Utilizando la instrucción** gh repo clone Axitymx/24_AXITY_AR35_A_WASAT_WINIUM_C-
        - **Abrirlo con GitHub Desktop**
        - **Abrirlo con Visual Studio**
        - **Descargarlo con ZIP**

3. Una vez descargada la solución tendremos la siguiente estructura de carpetas:
      - **WiniumSikulixArquetipo**
          - **src**
            - **drivers**
            - **main**
              - **config**
              - **core**
              - **pages**
                - **cientifica**
                    - **image_patterns**
                - **estandar**
                    - **image_patterns**
                - **general**
                    - **image_patterns**
              - **utils**
                - **Actions**
            - **test**
                - **screenshots**
                - **test_cases**
                    - **test_suite_botones**
                    - **test_suite_division**
                    - **test_suite_funciones_trigonometricas**
                    - **test_suite_multiplicacion**
                    - **test_suite_resta**
                    - **test_suite_sumas**
                - **test_data**
                    - **excel**
                - **test_report**
                    - **insumos**
                        - **A4**
                        - **Fonts**
                    - **lectura_archivos**
                    - **models**
                    - **utility**
            - **app.config**
            - **app.config.jar**
            - **packages.config**
            - **README.md**
            - **sikulirestapi-1.0.jar**

5. Abrir el archivo "WiniumSikulixArquetipo.sln" en el IDE Microsoft Visual Studio 2022 (Community, Professional o Enterprise).

6. En la sección de Explorador de Soluciones, se debe seleccionar el archivo raíz WiniumSikulix Arquetipo

7. Se debe dar clic derecho y seleccionar la opción Limpiar para prepararla solución para su compilación.

8. Se debe dar clic derecho y seleccionar la opción Compilar. (Cuando se compila la solución se debe validar que los paquetes Nuget de la sección de Dependencias se hayan descargado de manera satisfactoria). 

#################### Uso #################### 

1. En la sección de Explorador de Soluciones, encontraremos las siguientes carpetas: 

    - **drivers**
    - **main**
    - **test**

2. En la carpeta de drivers encontraremos los drivers necesarios para poder automatizar en los distintos navegadores como lo son Google Chrome, Mozilla FireFox y Microsoft Edge, Así mismo encontraremos el driver de Winium Winium.Desktop.Driver, el cual es una herramienta para inspeccionar los elementos de tipo Desktop.

3. En la carpeta de main encontraremos las carpetas:

   - **Config**: En la clase AppConfig.cs, actúa como un contenedor para almacenar configuraciones relacionadas con la ruta del aplicativo que se está probando y la ruta en donde se encuentra el driver de SikuliX. Al definir esta configuración como una propiedad estática en una clase separada, permite que la rutas sean fácilmente accesibles y modificables desde otras partes del código sin necesidad de cambiar el valor directamente en cada lugar donde se utiliza las rutas. Esto hace que el código sea más modular y fácil de mantener.

   - **Core**: Las clases BaseTest.cs establecen una base común para las pruebas de interfaz de usuario en aplicaciones de Windows, utilizando Selenium para la automatización del navegador web y Sikuli para interactuar con elementos de la interfaz de usuario fuera del navegador. Y XposFlujo.cs este código se utiliza para automatizar la interacción con la aplicación "Xpos", incluido el inicio de sesión y algunas configuraciones iniciales. Utiliza las bibliotecas Sikuli y Winium para identificar elementos de la interfaz de usuario y realizar acciones en ellos.

   - **Pages**: En resumen, esta sección nos permite segmentar nuestra interfaz en este caso una calculadora en tipo cientifica, estandar o general, con la finalidad de que sus elementos como las image_patterns puedan ser ubidacadas de manera rapida.

   - **Util**: En resumen, la clase Accions.cs este código proporciona una forma de tomar capturas de pantalla de la aplicación bajo prueba utilizando Selenium y Winium, y guardarlas en un directorio específico del proyecto. Esto puede ser útil para fines de depuración y seguimiento del estado de la aplicación durante la ejecución de pruebas automatizadas, la clase DataHelper.cs proporciona una forma conveniente de leer datos de un archivo Excel y utilizarlos como datos de prueba en pruebas NUnit. Esto puede ser útil para ejecutar pruebas con diferentes conjuntos de datos sin tener que cambiar manualmente los datos en el código de prueba. En el caso de la clase Constantes.cs, se definen para facilitar la modificación y reutilización de estos valores en diferentes partes del código. Al definirlos como constantes en una clase separada, se pueden modificar fácilmente si cambian en el futuro y se pueden acceder desde cualquier parte del código donde se necesiten. Dentro de esta misma carpeta encontraremos una subcarpeta con el nombre de ImagePattern en donde podremos colocar las imagenes que serán consumidas por las instrucciones de Sikulix.

5. En la carpeta de Test encontraremos las carpetas:

   - ** Screenshots**: En esta carpeta encontraremos los screenshot tomados para la generación del reporte
   
   - ** TestCases**:
   
     - ** TestSuiteBotones.cs: este código representa una suite de pruebas para probar los botones de una calculadora utilizando Selenium y Sikuli. Cada método de prueba se centra en probar un botón específico de la calculadora.**

     - ** TestSuiteDiv.cs: este código representa una prueba de división de dos números en una calculadora utilizando Selenium y Sikuli. El método de prueba hace clic en los botones correspondientes para realizar la división y no realiza ninguna verificación específica en este momento.**

     - ** TestSuiteFnTrigo.cs: este código representa pruebas automatizadas para verificar el funcionamiento de la función trigonométrica de seno en una calculadora científica, utilizando Selenium y Sikuli para interactuar con la interfaz de usuario**

     - ** TestSuiteMulti.cs: este código representa una prueba automatizada de la función de multiplicación en una calculadora, utilizando Selenium y Sikuli para interactuar con la interfaz de usuario y simular las acciones del usuario.**

     - ** TestSuiteResta.cs: este código representa una prueba automatizada de la función de resta en una calculadora, utilizando Selenium y Sikuli para interactuar con la interfaz de usuario y simular las acciones del usuario**

     - ** TestSuiteSumas.cs: este código representa una prueba automatizada de la función de suma en una calculadora, utilizando Selenium y Sikuli para interactuar con la interfaz de usuario y simular las acciones del usuario**

   - **TestData**

     - ** Encontraremos insumos (Archivos Excel), los cuales nos apoyaran en caso de necesitar realizar iteraciones sobre algun flujo o proceso automatizado.**
   
   - **TestReport**

     - ** Insumos**: En esta carpeta encontraremos dos subcarpetas, la primera A4 en donde están las imágenes correspondientes al layout que utilizará el reporte en su generación y la de Fonts que como su nombre lo dice son las fuentes utilizadas para la generación del reporte.
   
     - ** Lectura Archivos**: En resumen, esta clase proporciona funcionalidad para leer un archivo CSV que contiene datos de informes de pruebas y convertir cada línea del archivo en objetos ReportModel, que contienen información específica de cada informe de prueba.

     - ** Models**: En resumen, esta clase proporciona una estructura de datos para almacenar información detallada sobre los informes de prueba, incluyendo detalles sobre el proyecto, la ejecución, los casos de prueba y los resultados de los pasos de prueba.

     - ** Utility**: Estas constantes proporcionan nombres y textos predefinidos que se utilizan en la generación de informes de pruebas automatizadas, lo que hace que el proceso de generación de informes sea más consistente y fácil de mantener.

#################### Software Requerido ####################

- **Se requiere Java 1.8**

#################### Configuración #################### 

  - ** Es de vital importancia que los paquetes Nuget se han instalado de forma satisfactoria. Respecto a las configuraciones fueron detalladas a nivel de cada uno de los archivos aquí mencionados.**

#################### Ejemplos #################### 

  - ** En la sección test_cases, encontraremos las clases TestSuiteDS50.cs, TestSuiteSEL.cs y TestSuiteTAE.cs, estas clases de prueba NUnit realiza una prueba simple donde se consume el punto de venta. Este tipo de estructura de prueba es comúnmente utilizada para realizar pruebas de funcionalidades básicas de un sitio web utilizando Winium, Sikulix y NUnit. **
  
#################### Contribución ####################: Si la solución es de código abierto, incluye pautas sobre cómo contribuir al proyecto, como instrucciones para enviar solicitudes de extracción, reportar problemas, etc.
  
  - ** Para realizar contribuciones a este proyecto se debe realizar un backup de la solución de manera local para que se adapte a las necesidades del proyecto en donde se desea implementar**

#################### Créditos ####################

Las personas que han contribuido a la solución.

  - **Mauricio Gurrola Sánchez**
  - **Gustavo David Ramírez Ledesma**
  - **Osvaldo Alfredo Zamora Reyes**

#################### Licencia ####################

// Especifica la licencia bajo la cual se distribuye la solución y cualquier otra información legal relevante.

#################### Contacto ####################

  - **Mauricio Gurrola Sánchez         mauricio.gurrola@axity.com**
  - **Gustavo David Ramírez Ledesma    gustavo.ramirez@axity.com**
  - **Osvaldo Alfredo Zamora Reyes      osvaldo.zamor@axity.com**
