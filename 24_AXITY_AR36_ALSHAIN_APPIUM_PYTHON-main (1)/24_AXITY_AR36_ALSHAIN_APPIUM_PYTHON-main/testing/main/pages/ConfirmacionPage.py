from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
import time

from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.support.wait import WebDriverWait
from selenium.webdriver.common.by import By
from testing.main.utils.Constantes import Constantes
from appium import webdriver

class ConfirmacionPage:

    checkbox = "android.widget.CheckBox"
    completeboton = "com.androidsample.generalstore:id/btnProceed"
    cartpagetitle = "com.androidsample.generalstore:id/toolbar_title"
    chromepage = "android:id/content"
    productName = "com.androidsample.generalstore:id/productName"

    def __init__(self, driver):
        self.driver = driver
        self.wait = WebDriverWait(driver, 10)

    def click_checkbox(self):
        self.wait.until(EC.visibility_of_element_located((By.CLASS_NAME, ConfirmacionPage.checkbox))).click()

    def click_completeboton(self):
        self.wait.until(EC.visibility_of_element_located((By.ID, ConfirmacionPage.completeboton))).click()

    def producto_text(self):
        self.wait.until(EC.visibility_of_element_located((By.ID, ConfirmacionPage.cartpagetitle)))

        producto1 = self.driver.find_element(By.ID, "com.androidsample.generalstore:id/productName")
        return producto1.text


    def full_confirmacion(self):
        ConfirmacionPage.click_checkbox(self)
        ConfirmacionPage.click_completeboton(self)

