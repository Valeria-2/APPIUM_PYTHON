from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from testing.main.utils.Actions import Actions
from selenium.webdriver.common.by import By
import time
from selenium.common.exceptions import TimeoutException
from appium.webdriver.common.appiumby import AppiumBy

class ProductosPage:

    # Localizadores de elementos
    elements = "com.androidsample.generalstore:id/productName"
    addcarrito = "com.androidsample.generalstore:id/productAddCart"
    botoncarrito = "com.androidsample.generalstore:id/appbar_btn_cart"

    def __init__(self, driver):
        self.driver = driver
        self.wait = WebDriverWait(driver, 10)


    def buscar_tenis(self, tenis):
        actions = Actions(self.driver)
        actions.ScrollIntoView(tenis)

    def seleccionarTenis(self, tenis,):
        actions = Actions(self.driver)
        actions.ScrollIntoView(tenis)

        elementos = WebDriverWait(self.driver, 10).until(EC.visibility_of_all_elements_located(((By.ID ,"com.androidsample.generalstore:id/productName"))))
        i = 0

        for element in elementos:
            # Realizar acciones con cada elemento, por ejemplo, imprimir el texto
            print(element.text)
            if element.text == tenis:
                adding = self.driver.find_elements(By.ID,"com.androidsample.generalstore:id/productAddCart")
                adding[i].click()
            i += 1

    def click_boton_carrito(self):
        self.wait.until(EC.visibility_of_element_located((By.ID, ProductosPage.botoncarrito))).click()


    def full_page(self, tenis):
        self.seleccionarTenis(tenis)
        self.click_boton_carrito()

    def get_tenis_seleccionado(self, selectortenis):
        elemento_tenis_seleccionado = self.wait.until(EC.visibility_of_element_located(selectortenis))
        return elemento_tenis_seleccionado.text