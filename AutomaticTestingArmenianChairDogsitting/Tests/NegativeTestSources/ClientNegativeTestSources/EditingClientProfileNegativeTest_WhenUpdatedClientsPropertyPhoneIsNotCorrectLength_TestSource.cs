﻿using AutomaticTestingArmenianChairDogsitting.Models.Request;
using System.Collections;

namespace AutomaticTestingArmenianChairDogsitting.Tests.NegativeTestSources.ClientNegativeTestSources
{
    public class EditingClientProfileNegativeTest_WhenUpdatedClientsPropertyPhoneIsNotCorrectLength_TestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new ClientRegistrationRequestModel()
            {
                Name = "Вася",
                LastName = "Петров",
                Phone = "+7951412554",
                Address = "ул. Итальянская, дом. 10",
                Email = "petrov@gmail.com",
            };
            yield return new ClientRegistrationRequestModel()
            {
                Name = "Вася",
                LastName = "Петров",
                Phone = "+795141255471",
                Address = "ул. Итальянская, дом. 10",
                Email = "petrov@gmail.com",
            };
        }
    }
}