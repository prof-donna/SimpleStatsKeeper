using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Models
{
    public class Common
    {
        public enum Result
        {
            OK,
            Fail,
            Error
        }

        public static string BlogConnectionStringValue_Simple()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SimpleStats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }


        public static string BlogConnectionStringValue(IConfiguration configuration, string name)
        {
            return configuration.GetSection("ConnectionStrings")[name];

        }

    }
}
