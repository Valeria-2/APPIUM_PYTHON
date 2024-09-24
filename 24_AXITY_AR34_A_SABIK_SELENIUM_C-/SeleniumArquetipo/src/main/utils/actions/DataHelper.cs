using OfficeOpenXml;
using SeleniumArquetipo1.Src.Main.Utils;

namespace SeleniumArquetipo1.Src.Test.TestData
{
    public static class DataHelper
    {
        public static IEnumerable<TestCaseData> ExcelUserData()

        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            string filePath = Path.Combine(projectDirectory, Constantes.ExcelFilePath);

            // Verificamos si el archivo existe
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(Constantes.MensajeFileError);
            }

            // Abrimos el archivo Excel
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Iteramos sobre las filas para leer los datos
                for (int row = 2; row <= worksheet.Dimension.Rows; row++) // Empezamos desde la segunda fila, suponiendo que la primera fila es para los encabezados
                {
                    // Obtenemos los datos de usuario de la fila actual
                    string? tcname = worksheet.Cells[row, 1].Value?.ToString();
                    string? username = worksheet.Cells[row, 2].Value?.ToString();
                    string? password = worksheet.Cells[row, 3].Value?.ToString();
                    // Agregamos los datos como casos de prueba
                    yield return new TestCaseData(tcname,username, password);
                }
            }
        }
    }
}
