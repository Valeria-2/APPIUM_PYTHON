from appium import webdriver
from appium.options.android import UiAutomator2Options
from appium.webdriver.appium_service import AppiumService

class ServerConfig:
    def __init__(self):
        self.appium_service = AppiumService()

    def start_appium(self):
        self.appium_service.start()

    def stop_appium(self):
        self.appium_service.stop()

    def get_driver(self, capabilities):
        appium_server_url = 'http://localhost:4723'
        capabilities_options = UiAutomator2Options().load_capabilities(capabilities)
        driver = webdriver.Remote(command_executor=appium_server_url, options=capabilities_options)
        return driver
