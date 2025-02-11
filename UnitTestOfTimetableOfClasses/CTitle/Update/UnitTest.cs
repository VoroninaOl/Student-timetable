﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CTitle.UT_Update
{
    [TestClass]
    public class UT_UCTitle
    {
        RefData refData = new RefData();
        [TestMethod]
        public void UCTitle_1()//изменение когда атрибуты не повторяются и код учебного звания изменить нельзя
        {
            MTitle T_Title = new MTitle("Проф.", "Профессор");

            refData.CTitle.Insert(T_Title);

            T_Title = new MTitle("Доц.", "Доцент");

            bool result = refData.CTitle.Update(T_Title);
            //assert
            Assert.IsFalse(result, "Ожидаем, что Модель изменится");

        }

        [TestMethod]
        public void UCTitle_2()
        {
            MTitle T_Title = new MTitle("Проф.", "Профессор");

            refData.CInstitute.Insert(T_Title);

            T_Title = new MTitle("Проф.", "Доцент");

            bool result = refData.CTitle.Update(T_Title);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
        }
    }
}