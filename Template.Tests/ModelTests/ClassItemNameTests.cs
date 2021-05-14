using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TemplateNameSpace.Models;

namespace ClassItemNameTests.Test
{
  [TestClass]
  public class ClassItemNameTests
  {
    [TestMethod]
    public void ClassItemNameConstructor_CreatesInstanceOfClassItem_ClassItemName()
    {
      ClassItemName newClassItemName = new ClassItemName();
      Assert.AreEqual(typeof(ClassItemName), newClassItemName.GetType());
    }
    // Class Item Tests
  }
}