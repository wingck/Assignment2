using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class J3Controller : ApiController
    {   /// <summary>
        /// I choose 2021/J3
        /// I created string "myNum" with 3 variables
        /// int a is used to check if the sum of x and y is odd or even.
        /// maximum values of x and y should be 9 and the last 3 digits should be between 100 and 999.
        /// The first condition confirms not all x and y are 0, then if sum of x and y is even, if not, output "left", if yes, then output "right".
        /// If both x and y are 0, then output "same".
        /// PS: I don't know how to exactly output the requirement of the question.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns>Return the input value once and return nothing if the conditions are not matched.</returns>
        [HttpGet]
        [Route("api/J3/myNum/{x}/{y}/{z}")]
        public string myNum(int x, int y, int z)
        {
            int a = (x + y) % 2;
            if (x <= 9 && y <= 9 && z >= 100 && z <= 999)
            {
                if (x >= 1 && y >= 1 || x >= 1 && y == 0 || x == 0 && y >= 1)
                {
                    if (a != 0)
                    {
                        return "left " + z;
                    }
                    else if (a == 0)
                    {
                        return "right " + z;
                    }
                }
                else if (x == 0 && y == 0)
                {
                    return "same " + z;
                }
            }
            return "";
        }

    }
}
