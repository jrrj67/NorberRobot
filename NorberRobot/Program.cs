using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.Build();

using (var driver = new ChromeDriver())
{
	// Accessing norber

	driver.Url = config["Url"];

	driver.Manage().Window.Maximize();

	// Logging in

	driver.FindElement(By.Id("CodEmpresa")).SendKeys(config["Company"]);

	driver.FindElement(By.Id("requiredusuario")).SendKeys(config["UserCode"]);

	driver.FindElement(By.Id("requiredsenha")).SendKeys(config["Password"] + Keys.Enter);

	// Accessing punching clock

	driver.Url = config["PunchClockUrl"];

	driver.FindElement(By.Id("Button1")).Click();

	Thread.Sleep(5000);
}
