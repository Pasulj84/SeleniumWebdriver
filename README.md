## Selenium Webdriver

#### Zadanie 1
1. Wyszukaj Selenium WebDriver w wersji 4.1.0 i zaci�gnij je do projektu
2. Skorzystaj z gotowego kodu do uruchomienia. Sprawd� czy u Ciebie dzia�a:
```csharp
driver = new ChromeDriver();
driver.Url = "https://www.bing.com";
driver.FindElement(By.Name("q")).Click();
driver.FindElement(By.Name("q")).SendKeys("MojaFirma");
driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
driver.Quit();
```

3. Czy pojawi� si� jaki� b��d? Co on oznacza? Jak go naprawi�?
4. Napraw b��d i sprawd� jeszcze raz czy dzia�a







#### Snippets
W cmd.exe odpal ubicie proces�w chromedriver.exe
```shell
taskkill /f /im chromedriver.exe
```