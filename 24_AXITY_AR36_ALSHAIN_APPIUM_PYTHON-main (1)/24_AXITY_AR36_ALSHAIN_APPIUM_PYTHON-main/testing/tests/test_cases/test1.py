import time
import unittest
from src.main.core.BaseTest import BaseTest
from src.main.pages.ConfirmacionPage import ConfirmacionPage
from src.main.pages.InfoPage import InfoPage
from src.main.pages.ProductosPage import ProductosPage


class Navegacion(BaseTest):

    def test_abrir_aplicacion(self):
        time.sleep(2)

    def test_username_app(self):
        infoPage = InfoPage(self.driver)
        infoPage.enter_username("Mauricio")

    def test_radiobutton(self):
        infoPage = InfoPage(self.driver)
        infoPage.enter_gender_femenino()

    def test_buscarPais(self):
        infoPage = InfoPage(self.driver)
        infoPage.buscar_pais("Argentina")

    def test_selecionarPais(self):
        infoPage = InfoPage(self.driver)
        infoPage.buscar_pais("Argentina")
        infoPage.click_pais("Argentina")

    def test_fullPage1(self):
        infoPage = InfoPage(self.driver)
        infoPage.full_page("Canada","User1")


    def test_BuscarTenis(self):
        infoPage = InfoPage(self.driver)
        infoPage.full_page("Angola", "User1")

        productosPage = ProductosPage(self.driver)
        productosPage.buscar_tenis("Converse All Star")
        productosPage.buscar_tenis("Jordan 6 Rings")
        productosPage.buscar_tenis("Air Jordan 4 Retro")

    def test_SeleccionarTenis(self):
        infoPage = InfoPage(self.driver)
        infoPage.full_page("Angola", "User1")

        productosPage = ProductosPage(self.driver)
        productosPage.SeleccionarTenis("Converse All Star")

    def test_complete(self):
        infoPage = InfoPage(self.driver)
        productosPage = ProductosPage(self.driver)
        confirmarPage = ConfirmacionPage(self.driver)

        infoPage.full_page("Angola", "User1")
        productosPage.seleccionarTenis("Converse All Star")
        productosPage.click_boton_carrito()
        confirmarPage.full_confirmacion()





if __name__ == "__main__":
    unittest.main()