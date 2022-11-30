using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TortugaSTest
{

    //Большая цена

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Reducation_BigPrice_ReturnFalse()
        {
            //Arrage - входной параметр
            string reduction = "36473487939";
                bool ex = false;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR .НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }

    
    //Пятая суббота

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Reducation_FifthSaturday_ReturnTrue()
        {
            //Arrage - входной параметр
            string reduction = "36473487939";
            bool ex = true;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR.НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }

    //Отрицательная стоимость

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Reducation_NegativePrice_ReturnFalse()
        {
            //Arrage - входной параметр
            string reduction = "-1238";
            bool ex = false;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR.НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }

    //Дробное число

    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Reducation_FractionalNumber_ReturnFalse()
        {
            //Arrage - входной параметр
            string reduction = "1500,50";
            bool ex = false;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR.НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }

    //Цена = 0

    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void Reducation_NullPrice_ReturnFalse()
        {
            //Arrage - входной параметр
            string reduction = "0";
            bool ex = false;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR.НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }

    
    //Каждая суббота

    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void Reducation_EverySaturday_ReturnFalse()
        {
            //Arrage - входной параметр
            string reduction = "36473487939";
            bool ex = false;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR.НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }


    //цена в буквах

    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void Reducation_BigPrice_ReturnFalse()
        {
            //Arrage - входной параметр
            string reduction = "сто рублей";
            bool ex = false;

            //Act - вызов тестируемого метода
            bool act = TortugaS_KR.НАЗВАНИЕ_МЕТОДА(reduction);

            //Assert - сравнение
            Assert.AreEqual(ex, act);
        }
    }
}
