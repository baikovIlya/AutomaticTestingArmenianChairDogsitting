﻿using AutomaticTestingArmenianChairDogsitting.Models.Request;
using AutomaticTestingArmenianChairDogsitting.Models.Response;
using System.Collections;
using System.Collections.Generic;

namespace AutomaticTestingArmenianChairDogsitting.Tests.NegativeTestSources.SitterNegativeTestSources
{
    public class SitterCreationNegativeTest_WhenSittersPropertyPasswordAndPhoneIsNotCorrectLength_TestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new SitterRegistrationRequestModel()
            {
                Name = "Миша",
                LastName = "Пет",
                Phone = "+79514125547",
                Email = "pet0@gmail.com",
                Password = "1234567",
                Age = 20,
                Experience = 10,
                Sex = 1,
                Description = "Description",
                PriceCatalog = new List<PriceCatalogResponseModel>()
                {
                    new PriceCatalogResponseModel() { Service = 1, Price = 500 },
                }
            };
            yield return new SitterRegistrationRequestModel()
            {
                Name = "Миша",
                LastName = "Пет",
                Phone = "+79514125547",
                Email = "pet0@gmail.com",
                Password = "1",
                Age = 20,
                Experience = 10,
                Sex = 1,
                Description = "Description",
                PriceCatalog = new List<PriceCatalogResponseModel>()
                {
                    new PriceCatalogResponseModel() { Service = 1, Price = 500 },
                }
            };
            yield return new SitterRegistrationRequestModel()
            {
                Name = "Миша",
                LastName = "Пет",
                Phone = "+795141255471",
                Email = "pet0@gmail.com",
                Password = "12345678",
                Age = 20,
                Experience = 10,
                Sex = 1,
                Description = "Description",
                PriceCatalog = new List<PriceCatalogResponseModel>()
                {
                    new PriceCatalogResponseModel() { Service = 1, Price = 500 },
                }
            };
            yield return new SitterRegistrationRequestModel()
            {
                Name = "Миша",
                LastName = "Пет",
                Phone = "+7951412554",
                Email = "pet0@gmail.com",
                Password = "12345678",
                Age = 20,
                Experience = 10,
                Sex = 1,
                Description = "Description",
                PriceCatalog = new List<PriceCatalogResponseModel>()
                {
                    new PriceCatalogResponseModel() { Service = 1, Price = 500 },
                }
            };
        }
    }
}
