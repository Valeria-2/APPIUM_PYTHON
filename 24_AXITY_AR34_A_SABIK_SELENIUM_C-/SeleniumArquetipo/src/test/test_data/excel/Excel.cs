using OfficeOpenXml;
using SeleniumArquetipo1.Src.Main.Utils;

namespace SeleniumArquetipo1.Src.Test.TestData.Excel
{ 
        public class ExcelReaderTests
        {
            [Test]
            public void ReadExcelFile_ShouldReturnCorrectData()
            {
                // Ruta del archivo Excel
                //string filePath = "C:\\Users\--\\source\\repos\\SeleniumArquetipo1\\SeleniumArquetipo1\\Src\\Test\\TestData\\Excel\\DataLogin.xlsx";

                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                string filePath = Path.Combine(projectDirectory, Constantes.ExcelFilePath);


                // Verificamos si el archivo existe
                Assert.That(File.Exists(filePath), Is.True, "El archivo no existe en la ruta especificada.");

                // Creamos una instancia de ExcelPackage
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Obtenemos la primera hoja del libro de trabajo
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    // Obtenemos el número de filas y columnas en la hoja
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    // Iteramos sobre las filas y columnas para leer los datos
                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            // Obtenemos el valor en la celda actual
                            object cellValue = worksheet.Cells[row, col].Value;

                            // Hacer algo con el valor de la celda, por ejemplo, imprimirlo
                            Console.Write(cellValue + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }


