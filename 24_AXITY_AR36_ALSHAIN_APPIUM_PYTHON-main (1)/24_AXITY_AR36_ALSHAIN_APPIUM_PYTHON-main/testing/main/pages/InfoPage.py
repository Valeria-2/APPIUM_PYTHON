from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from testing.main.utils.Actions import Actions


class InfoPage:
    # Localizadores de elementos
    name = "com.androidsample.generalstore:id/nameField"
    femenino = "com.androidsample.generalstore:id/radioFemale"
    botonShop = "com.androidsample.generalstore:id/btnLetsShop"
    listapais = "android:id/text1"
    algeria = '//android.widget.TextView[@text="' + 'Algeria' + '"]'

    def __init__(self, driver):
        self.driver = driver
        self.wait = WebDriverWait(driver, 10)

    def enter_username(self, username):
        elemento = WebDriverWait(self.driver, 10).until(EC.visibility_of_element_located((By.ID, InfoPage.name)))
        elemento.send_keys(username)
        return elemento

    def enter_gender_femenino(self):
        self.wait.until(EC.visibility_of_element_located((By.ID, InfoPage.femenino))).click()

    def click_boton_shop(self):
        self.wait.until(EC.visibility_of_element_located((By.ID, InfoPage.botonShop))).click()

    def click_lista_pais(self):
        self.wait.until(EC.visibility_of_element_located((By.ID, InfoPage.listapais))).click()

    def buscar_pais(self, pais):
        self.click_lista_pais()
        actions = Actions(self.driver)  # Agregar una instancia de la clase Actions
        actions.ScrollIntoView(pais)

    def click_pais(self,pais):
        actions = Actions(self.driver)
        actions.ClickElementoXpath('//android.widget.TextView[@text="' + pais + '"]')

    def texto_pais(self, pais):
        pais_element = self.driver.find_element(*self.algeria)
        return pais_element.text

    def full_page(self, pais, name):
        self.buscar_pais(pais)
        self.click_pais(pais)
        self.enter_username(name)
        self.driver.hide_keyboard()
        self.enter_gender_femenino()
        self.click_boton_shop()

    def radiobutton_femenino_selected(self):
        return self.driver.find_element(*self.femenino).is_selected()
