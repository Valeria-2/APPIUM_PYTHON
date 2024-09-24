using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAndSikuli.src.main.utils
{
    public class Constantes
    {
        
        public const string ExcelFilePath = "src/test/test_data/excel/DataNumCel.xlsx";
        public const string imagePatterPathPages = @"\src\main\pages\";
        public const string imagePatterPathEstandar = imagePatterPathPages + @"estandar\image_patterns\";
        public const string imagePatterPathGeneral = imagePatterPathPages + @"general\image_patterns\";
        public const string imagePatterPathCientifica = imagePatterPathPages + @"cientifica\image_patterns\";

        //PAGE - ESTANDAR


        //PAGE - GENERAL
        public const string btn0 = imagePatterPathGeneral + "bntcero.png";
        public const string btn1 = imagePatterPathGeneral + "boton1.png";
        public const string btn2 = imagePatterPathGeneral + "boton2.png";
        public const string btn3 = imagePatterPathGeneral + "boton_3.png";
        public const string btn4 = imagePatterPathGeneral + "boton4.png";
        public const string btn5 = imagePatterPathGeneral + "boton5.png";
        public const string btn6 = imagePatterPathGeneral + "boton_6.png";
        public const string btn7 = imagePatterPathGeneral + "boton7.png";
        public const string btn8 = imagePatterPathGeneral + "boton8.png";
        public const string btn9 = imagePatterPathGeneral + "boton_9.png";

        public const string btnSuma = imagePatterPathGeneral + "mas.png";
        public const string btnResta = imagePatterPathGeneral + "menos.png";
        public const string btnMulti = imagePatterPathGeneral + "multi.png";
        public const string btnDiv = imagePatterPathGeneral + "div.png";
        public const string btnCE = imagePatterPathGeneral + "CE.png";
        public const string btnC = imagePatterPathGeneral + "C.png";
        public const string btnIgual = imagePatterPathGeneral + "igual.png";

        public const string menubtn = imagePatterPathGeneral + "menu.png";
        public const string cientificabtn = imagePatterPathGeneral + "cientifica.png";

        public const string restSuma = imagePatterPathGeneral + "resulsum.png";
        public const string restResta = imagePatterPathGeneral + "resulsum.png";
        public const string restMulti = imagePatterPathGeneral + "resulsum.png";
        public const string restDiv = imagePatterPathGeneral + "resulsum.png";



        //PAGE - CIENTIFICA
        public const string fntrigobtn = imagePatterPathCientifica + "trigo.png";
        public const string senobtn = imagePatterPathCientifica + "sin.png";


    }
}
