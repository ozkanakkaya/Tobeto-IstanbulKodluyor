﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class TradeCreditApplicationManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi hesaplandı.");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
}
