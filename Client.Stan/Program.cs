﻿using Borex;
using System;
using System.Linq;

namespace Client.Stan
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account[Currencies.USD] = account[Currencies.EUR] =
                account[Currencies.PLN] = account[Currencies.CZK] = 100;
            var server = new BorexServer();
            var currencies = server
                .Rates
                .OrderBy(z => z.RelativeGrowth)
                .Select(z => z.Currency)
                .ToArray();
            server.Exchange(account, currencies.First(), currencies.Last(), 100);
        }
    }
}
