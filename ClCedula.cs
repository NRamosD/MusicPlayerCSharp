using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TrabajoGrupal
{
    class ClCedula
    {
        char[] vec1;

        int lim1;

        public ClCedula(char[] vec, int lim)
        {

            vec1 = vec;
            lim1 = lim;

        }

        public int Verificar()
        {

            int res = -1;
            int suma = 0;
            int Superior;
            int digito;
            int numero;
            int num = 0;


            for (int j = 0; j < 9; j++)
            {

                num = Convert.ToInt32(vec1[j].ToString());

                if ((j % 2) == 0)
                {
                    num = Convert.ToInt32(vec1[j].ToString()) * 2;
                    if (num > 9)
                    {
                        num = num - 9;
                    }
                }
                suma = suma + num;
            }
            Superior = suma % 10;

            if (Superior != 0)
            {

                digito = 10 - Superior;

            }

            else
                digito = 0;

            numero = Convert.ToInt32(vec1[9].ToString());

            if (digito == numero)
            {
                res = 2;
                return (res);

            }

            else
            {
                return (res);

            }
        }
    }


}
