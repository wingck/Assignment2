using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class J2Controller : ApiController
    {   /// <summary>
        /// I created a string "DiceGame" with 2 variables int m and int n.
        /// The maximum of ways is 9, when m and n are both greater than 9, the number of ways is still the same.
        /// When one of the variables is greater 9 while the other one is smaller than 9, the number of ways is the same with the smaller number.
        /// When the sum of m and n is smaller than 10, there is no way to sum up 10.
        /// When the sum of m and n is 10, there is only one way to sum up 10.
        /// The maximum sum of m and n is 18, since 18 and 17 are included in the above conditions, the last step is to include 11<a<16.
        /// When 11<a<16, there is (a-9) ways to sum up 10.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>If the condition is outside the above, 0 way is output.</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n) {
            int a = m + n;
            int b = a - 9;
            if (m >= 9 && n >= 9){
                return "There are 9 ways to get sum 10";
            }         
            else if (m >= 9 && n < 9){
                return "There are " + n + " ways to get sum 10";
            }
            else if (m < 9 && n >= 9) {
                return "There are " + m + " ways to get sum 10";
            }
            else if (a < 10) {
                return "There is 0 way to get sum 10";
            }
            else if (a == 10){
                return "There is 1 way to get sum 10";
            }
            for (a = 11; a <= 16; a++){
                return "There are " + b + " ways to get sum 10";
            }
            return "There is 0 way to get sum 10";
        }
    }
}
