using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string EbayHomeUrl = "https://www.ebay.com/";

        private IWebDriver _driver;
        private WebDriverWait _wait;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                EnsureBrowserIsReady();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось запустить браузер. " + ex.Message,
                    "Browser start error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show(
                    "Введите текст в поле search.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }

            try
            {
                EnsureBrowserIsReady();

                IWebElement searchField = WaitForElement(By.Id("gh-ac"));
                searchField.Clear();
                searchField.SendKeys(searchText);

                IWebElement searchButton = WaitForElement(By.Id("gh-btn"));
                searchButton.Click();

                _wait.Until(driver =>
                    !string.IsNullOrWhiteSpace(driver.Url) &&
                    !string.Equals(driver.Url.TrimEnd('/'), EbayHomeUrl.TrimEnd('/'), StringComparison.OrdinalIgnoreCase));

                txtLinkToSearchResult.Text = _driver.Url;
                lstSearchHistory.Items.Add(_driver.Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось выполнить поиск. " + ex.Message,
                    "Search error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_driver == null)
                return;

            try
            {
                _driver.Navigate().Back();
                WaitForElement(By.Id("gh-ac"));

                txtSearch.Clear();
                txtLinkToSearchResult.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось вернуться назад. " + ex.Message,
                    "Back error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCloseBrowser_Click(object sender, EventArgs e)
        {
            CloseBrowser();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseBrowser();
        }

        private void EnsureBrowserIsReady()
        {
            if (_driver != null)
            {
                try
                {
                    string title = _driver.Title;
                    return;
                }
                catch
                {
                    CloseBrowser();
                }
            }

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            _driver = new ChromeDriver(options);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

            _driver.Navigate().GoToUrl(EbayHomeUrl);
            WaitForElement(By.Id("gh-ac"));
        }

        private IWebElement WaitForElement(By by)
        {
            return _wait.Until(driver =>
            {
                try
                {
                    IWebElement element = driver.FindElement(by);
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            });
        }

        private void CloseBrowser()
        {
            try
            {
                if (_driver != null)
                {
                    _driver.Quit();
                    _driver.Dispose();
                }
            }
            catch
            {
            }
            finally
            {
                _driver = null;
                _wait = null;
            }
        }
    }
}
