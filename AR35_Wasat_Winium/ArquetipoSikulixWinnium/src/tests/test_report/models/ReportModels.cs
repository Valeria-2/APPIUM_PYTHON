﻿using System;

namespace SeleniumAndSikuli.src.tests.test_report.models
{
    public class ReportModel
    {
        public string NombreProyecto { get; set; }
        public string TiempoEjecuccion { get; set; }
        public DateTime InicioEjecuccion { get; set; }
        public DateTime FinEjecuccion { get; set; }
        public string StatusEjecuccion { get; set; }
        public string Precondiciones { get; set; }
        public string NombreCasoPrueba { get; set; }
        public string DescCasoPrueba { get; set; }
        public string NombreScript { get; set; }
        public string DescPaso { get; set; }
        public string DescResult { get; set; }
        public string EstatusPaso { get; set; }
        public string InputRoute { get; set; }

    }
}
