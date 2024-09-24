﻿using System.Collections.Generic;
using System.IO;
using SeleniumAndSikuli.src.tests.test_report.models;

namespace SeleniumAndSikuli.src.tests.test_report
{
    public class CreateCSV
    {
        public void CreatFile(string filePath, List<ReportModel> reportModels)
        {
            //CSV
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                // Lista de listas para almacenar los datos
                List<List<string>> tabla = new List<List<string>>();
                var counter = 0;

                reportModels.ForEach(reportModel =>
                {
                    var row = new List<string>
                    {
                        counter == 0 ? reportModel.NombreProyecto : "-",
                        counter == 0 ? reportModel.TiempoEjecuccion : "-",
                        reportModel.InicioEjecuccion.ToString("dd-MM-yyyy HH:mm:ss"),
                        reportModel.FinEjecuccion.ToString("dd-MM-yyyy HH:mm:ss"),
                        counter == 0 ? reportModel.StatusEjecuccion: "-",
                        counter == 0 ? reportModel.Precondiciones : "-",
                        counter == 0 ? reportModel.NombreCasoPrueba : "-",
                        counter == 0 ? reportModel.DescCasoPrueba: "-",
                        counter == 0 ? reportModel.NombreScript : "-",
                        reportModel.DescPaso,
                        reportModel.DescResult,
                        reportModel.EstatusPaso,
                        reportModel.InputRoute
                    };

                    counter++;
                    tabla.Add(row);

                    writer.WriteLine(string.Join(",", row));
                });

            }
        }
    }
}
