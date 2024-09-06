import time
import unittest
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.support.wait import WebDriverWait
from testing.main.core.BaseTest import BaseTest
from testing.main.pages.ConfirmacionPage import ConfirmacionPage
from testing.main.pages.InfoPage import InfoPage
from testing.main.pages.ProductosPage import ProductosPage
from selenium.webdriver.common.by import By
from testing.main.utils.Constantes import Constantes


class ValidData(BaseTest):

    def test_TcAltaNuevoUsuario(self):
        #ARRANGE
        infoP = InfoPage(self.driver)
        prodP = ProductosPage(self.driver)

        #ACT
        infoP.full_page("Angola","ValidUser")
        time.sleep(2)

        #ASSERT
        try:
            WebDriverWait(self.driver, 10).until(EC.visibility_of_element_located((By.ID, prodP.botoncarrito)))
            self.assertTrue(True)
        except:
            self.assertTrue(False, Constantes.mensajeProductos)


    def test_TcAgrega1ProdCarrito(self):
        #ARRANGE
        infoP = InfoPage(self.driver)
        ProP = ProductosPage(self.driver)
        confP = ConfirmacionPage(self.driver)
        testData = "Converse All Star"


        #ACT
        infoP.full_page("Angola", "ValidUser")
        ProP.full_page(testData)
        print(confP.producto_text())

        #ASSERT
        self.assertEqual(confP.producto_text(),testData,"No son iguales!")


    def test_TcAgrega2ProdCarrito(self):
        #ARRANGE
        infoP = InfoPage(self.driver)
        proP = ProductosPage(self.driver)
        data = ["Converse All Star","Jordan 6 Rings"]
        self.wait = WebDriverWait(self.driver, 10)

        #ACT
        infoP.full_page("Angola", "ValidUser")
        proP.seleccionarTenis(data[0])
        proP.seleccionarTenis(data[1])
        proP.click_boton_carrito()
        self.wait.until(EC.visibility_of_element_located((By.ID, ConfirmacionPage.cartpagetitle)))
        products = self.driver.find_elements(By.ID,ConfirmacionPage.productName)

        #ARRANGE
        i = 0
        for product in products:
            if product.text == data[i]:
                print("{} y {}".format(product.text, data[i]))
                self.assertTrue(True, "Si es")
            else:
                self.assertFalse(False, "No es")
            i += 1


    def test_TcComprarProducto(self):
        #ARRANGE
        infoP = InfoPage(self.driver)
        proP = ProductosPage(self.driver)
        conP = ConfirmacionPage(self.driver)

        #ACT
        infoP.full_page("Angola", "ValidUser")
        proP.full_page("Converse All Star")
        conP.full_confirmacion()

        #ASSERT
        try:
            WebDriverWait(self.driver, 10).until(EC.visibility_of_element_located((By.ID, ConfirmacionPage.chromepage)))
            self.assertTrue(True)
        except:
            self.assertTrue(False, ConfirmacionPage.chromepage)



if __name__ == "__main__":
    unittest.main()