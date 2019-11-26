﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.Domain
{
    public class AccountMovement
    {
        //Propiedades
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public double Amount { get; set; }
    }
}
