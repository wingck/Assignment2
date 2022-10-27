using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// I created a string called "Menu" with four variables.
        /// When the variables equal to 1/2/3/4, they output different calories.
        /// </summary>
        /// <returns>The sum of calories are output</returns>
        [HttpGet]
        [Route("api/J1/Menu/{BurgerChoice}/{DrinkChoice}/{SideChoice}/{DessertChoice}")]
        public string Menu(int BurgerChoice, int DrinkChoice, int SideChoice, int DessertChoice)
        {
            int BurgerCalories = 0;
            if (BurgerChoice == 1) {
                BurgerCalories = 461;
            }
            if (BurgerChoice == 2) {
                BurgerCalories = 431;
            }
            if (BurgerChoice == 3){
                BurgerCalories = 420;
            }
            if (BurgerChoice == 4){
                BurgerCalories = 0;
            }
            int DrinkCalories = 0;
            if (DrinkChoice == 1){
                DrinkCalories = 130;
            }
            if (DrinkChoice == 2){
                DrinkCalories = 160;
            }
            if (DrinkChoice == 3){
                DrinkCalories = 118;
            }
            if (DrinkChoice == 4){
                DrinkCalories = 0;
            }

            int SideCalories = 0;
            if (SideChoice == 1){
                SideCalories = 100;
            }
            if (SideChoice == 2){
                SideCalories = 57;
            }
            if (SideChoice == 3){
                SideCalories = 70;
            }
            if (SideChoice == 4){
                SideCalories = 0;
            }

            int DessertCalories = 0;
            if (DessertChoice == 1){
                DessertCalories = 167;
            }
            if (DessertChoice == 2){
                DessertCalories = 266;
            }
            if (DessertChoice == 3){
                DessertCalories = 75;
            }
            if (DessertChoice == 4){
                DessertCalories = 0;
            }


            int totalCalories = BurgerCalories + DrinkCalories + SideCalories + DessertCalories;
            return "Your Total Calorie count is "+ totalCalories;
        }

    }  
}
