using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repo
{
    public class TEST : ITEST
    {
        HttpRequestBase request;
        public TEST(HttpRequestBase inRequest)
        {

            request = inRequest;

        }
        public string Demo() => "超級大雞雞";
    }
}