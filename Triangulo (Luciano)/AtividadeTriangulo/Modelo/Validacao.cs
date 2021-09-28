using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoTriangulo
{
    class Validacao : absPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            if (!verificar(lado1, lado2, lado3))
            {
                this.mensagem = "Os dados inseridos são inválidos!";
            }
            else
            {
                this.mensagem = "";
            }
        }
        private bool verificar(string lado1, string lado2, string lado3)
        {
            try
            {
                this.l1 = double.Parse(lado1);
                this.l2 = double.Parse(lado2);
                this.l3 = double.Parse(lado3);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
