using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumWebDriverBasics.WebObjects.Pages
{
    public abstract class BasePage
    {
        protected By titleLocator;
        protected string title;

        protected BasePage(By titleLocator, string title)
        {
            this.titleLocator = titleLocator;
            this.title = title;
        }
    }
}