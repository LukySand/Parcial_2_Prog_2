using MemoTest.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoTest.Controladores
{
    public class nButtonGame
    {
        public static ButtonGame[,] CreateEasyLevel(int categoriId)
        {
            ButtonGame[,] easyLevel = new ButtonGame[3,2];
            Palabra[] words = new Palabra[easyLevel.GetLength(0) * easyLevel.GetLength(1)];

            Random r = new Random();
            int randomRow;
            int randomCol;
            List<Palabra> palabras = pPalabra.GetAllbyCategoria(categoriId);
            bool loop = true;
            while(loop)
            {
                foreach(Palabra p in words) //esto recorre todo el array de palabras
                {
                    if (string.IsNullOrEmpty(p.Texto))  //esto compara si todas las palabras tienen un valor
                    {
                        loop = true;
                        break;
                    }
                }


            }


            foreach(ButtonGame button in easyLevel)
            {
                if (string.IsNullOrEmpty(button.value))

                    break;
            }

            return easyLevel;
        }
    }
}
