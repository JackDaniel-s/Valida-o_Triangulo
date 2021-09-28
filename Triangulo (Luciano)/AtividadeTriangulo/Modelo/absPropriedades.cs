using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoTriangulo
{
    public class absPropriedades
    {
        protected double l1;
        protected double l2;
        protected double l3;
        protected string lado1;
        protected string lado2;
        protected string lado3;
        protected string mensagem = "";
        protected string resposta ="";

        public double L1
        {
            get { return l1; }
            set { l1 = value; }
        }

        public double L2
        {
            get { return l2; }
            set { l2 = value; }
        }

        public double L3
        {
            get { return l3; }
            set { l3 = value; }
        }

        public string Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        public string Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public string Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }

        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        public absPropriedades(double l1, double l2, double l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }
        public absPropriedades(string lado1, string lado2, string lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
    }
}
