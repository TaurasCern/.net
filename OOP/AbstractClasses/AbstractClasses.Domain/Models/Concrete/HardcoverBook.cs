﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Domain.Models.Abstract;

namespace AbstractClasses.Domain.Models.Concrete
{
    public class HardcoverBook : Book
    {
        public HardcoverBook(string genre, string title, string author, int booksSold, int? quantity, double? price) : base(genre, title, author, booksSold, quantity, price)
        {
        }
    }
}
