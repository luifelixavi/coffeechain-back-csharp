using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Core.DomainObjects
{
    public class PagedResultMediaContratoSaida<T> where T : class
    {
        public IEnumerable<T> List { get; set; }

        public int TotalResults { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public double Media { get; set; }

    }


    public class PagedResultMediaContratoSaidaRequest
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
