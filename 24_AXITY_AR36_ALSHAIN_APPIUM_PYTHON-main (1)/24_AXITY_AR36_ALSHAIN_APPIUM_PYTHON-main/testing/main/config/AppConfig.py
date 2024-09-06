class AppiumConfig:
    def __init__(self):
        pass

    def capabilities_appium(self):
        capabilities = {
            'platformName': 'Android',
            'automationName': 'uiautomator2',
            'deviceName': 'a70q',
            'appPackage': 'com.androidsample.generalstore',
            'appActivity': '.SplashActivity',
        }
        return capabilities
