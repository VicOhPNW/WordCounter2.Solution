using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;
using WordCounter.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter
{
  [TestClass]
  public class HomeControllerTest : Controller
  {
    [TestMethod]
    public void Index_ReturnHomeIndex_true()
    {
      HomeController controller = new HomeController();

      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
