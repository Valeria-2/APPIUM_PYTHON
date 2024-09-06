from testing.main.config.ServerConfig import ServerConfig
from testing.main.config.AppConfig import AppiumConfig
import unittest

class BaseTest(unittest.TestCase):
    def setUp(self):

        server_config = ServerConfig()
        server_config.start_appium()

        # Obtener capacidades de Appium desde AppConfig
        appium_config = AppiumConfig()
        desired_capabilities = appium_config.capabilities_appium()

        # Obtener el controlador de Appium desde ServerConfig
        self.driver = server_config.get_driver(desired_capabilities)


    def tearDown(self):
        # Cerrar el controlador de Appium
        self.driver.quit()

        # Detener Appium
        server_config = ServerConfig()
        server_config.stop_appium()