using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoTriangulo
{
    class Triangulos : absPropriedades
    {
        public Triangulos(double l1, double l2, double l3) : base(l1, l2, l3)
        {
            verificar(l1, l2, l3);
        }
        private void verificar(double l1, double l2, double l3)
        {
            if (l1 == l2 && l2 == l3)
            {
                this.resposta = "O triângulo é = Equilátero";
            }
            else if(l1 == l2 || l2 == l3 || l1 == l3)
            {
                this.resposta = "O triângulo é = Isósceles";
            }
            else
            {
                this.resposta = "O triângulo é = Escaleno";
            }
        }
    }
}
