using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repositorio
{
    public class ContaNotasRepositorio
    {
        public Dictionary<string, string> ContaNotas(int valor, int n5, int n4, int n3, int n2, int n1)
        {
            Dictionary<string, string> qtdnotas = new Dictionary<string, string>();


            int[] nota = { n5, n4, n3, n2, n1 };

            int vlr = valor;

            int i = 0;

            while (vlr != 0)
            {
                try
                {
                    int notas = vlr / nota[i];
                    if (notas != 0)
                    {

                        vlr = vlr % nota[i];
                        qtdnotas.Add(Convert.ToString(nota[i]), Convert.ToString(notas));
                    }
                    i = i + 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return qtdnotas;
        }
    }
}
