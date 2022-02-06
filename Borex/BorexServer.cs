using System;
using System.Collections.Generic;

namespace Borex
{
    public class BorexServer
    {
        List<Rate> rates = new List<Rate>
        {
            new Rate(Currencies.USD, 82, 2),
            new Rate(Currencies.EUR, 90, -3),
            new Rate(Currencies.CZK, 3.6, -0.2),
            new Rate(Currencies.PLN, 17, 1)
        };
        public IEnumerable<Rate> Rates { 
            get 
            {
                foreach (var e in rates) yield return e;
            } 
        }
    }
}
