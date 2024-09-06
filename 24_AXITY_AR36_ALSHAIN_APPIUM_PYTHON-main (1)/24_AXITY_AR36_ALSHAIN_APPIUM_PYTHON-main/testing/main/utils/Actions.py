from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
import time
from selenium.common.exceptions import TimeoutException
from appium.webdriver.common.appiumby import AppiumBy
from testing.main.config.ServerConfig import ServerConfig
from testing.main.config.AppConfig import AppiumConfig


class Actions:

    def __init__(self, driver):
        self.driver = driver

    def ClickElementoXpath(self, localizador):
        element = self.driver.find_element(By.XPATH, localizador)
        element.click()


    def ScrollIntoView(self, elemento):
        try:
            elemento_scroll = self.driver.find_element(AppiumBy.ANDROID_UIAUTOMATOR,'new UiScrollable(new UiSelector()).scrollTextIntoView("' + elemento + '")')

        except TimeoutException as ex:
            print("No se ha encontrado el elemento: " + elemento)


