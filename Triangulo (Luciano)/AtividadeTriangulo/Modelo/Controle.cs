using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoTriangulo
{
    public class Controle : absPropriedades
    {

        public Controle(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            if (verificar())
            {
                Triangulos triangulos = new Triangulos(this.l1, this.l2, this.l3);
                resposta = triangulos.Resposta;
            }
        }
        private bool verificar()
        {
            Validacao validacao = new Validacao(this.lado1, this.lado2, this.lado3);
            if(validacao.Mensagem != "")
            {
                mensagem = validacao.Mensagem;
                return false;
            }
            else
            {
                l1 = validacao.L1;
                l2 = validacao.L2;
                l3 = validacao.L3;
                return true;
            }
        }
    }
}
