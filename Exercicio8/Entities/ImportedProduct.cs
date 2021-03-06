﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public string PriceTag()
        {
            return Name
                + Price
                + "Customs Fee: "
                + " $ "
                + CustomsFee;
        }
    }
}
