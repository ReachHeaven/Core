/// @brief Юнит тесты
///
/// @copyright Copyright 2022 Amirov Karim.

using GameLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreTest
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsInstanceOfType(new Core(), typeof(Core));
        }
    }
}
