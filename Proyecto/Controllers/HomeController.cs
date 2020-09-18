using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        private Othello_201800524Entities db = new Othello_201800524Entities();
        public String[,] matrizTablero;
        
        public ActionResult Index()
        {
            CrearTablero();
            return View();
        }

        public void CrearTablero()
        {
            matrizTablero = new string[10, 10];
            matrizTablero[0, 0] = " ";
            matrizTablero[0, 1] = "A";
            matrizTablero[0, 2] = "B";
            matrizTablero[0, 3] = "C";
            matrizTablero[0, 4] = "D";
            matrizTablero[0, 5] = "E";
            matrizTablero[0, 6] = "F";
            matrizTablero[0, 7] = "G";
            matrizTablero[0, 8] = "H";
            matrizTablero[0, 9] = " ";
            matrizTablero[9, 0] = " ";
            matrizTablero[9, 1] = "A";
            matrizTablero[9, 2] = "B";
            matrizTablero[9, 3] = "C";
            matrizTablero[9, 4] = "D";
            matrizTablero[9, 5] = "E";
            matrizTablero[9, 6] = "F";
            matrizTablero[9, 7] = "G";
            matrizTablero[9, 8] = "H";
            matrizTablero[9, 9] = " ";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrizTablero[i,j] == null)
                    {
                        matrizTablero[i, j] = " ";
                    }
                    if ((j == 0 || j == 9) && i < 9 && i > 0)
                    {
                        matrizTablero[i, j] = i.ToString();
                    }
                }
            }
            ViewBag.matriz = matrizTablero;
            foreach (var item in matrizTablero)
            {
                Console.WriteLine(item);
            }
        }
    }
}