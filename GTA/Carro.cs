using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace GTA
{
    internal class Carro // colocar carro como abstract não deixa ninguem criar pela classe carro
    {
        // prop:
        //
        // public int MyProperty { get; set; }

        public string Cor { get; set; }

        // private string cor;
        // public void set...
        // public string get...

        public string Marca { get; set; } // permite colocar valor e pegar
        public int QuantidadePorta { get; set; } //propriedade  
        public bool TemAr { get; set; }
        public int Velocidade { get; private set; }
        public bool Ligado { get; private set; }
        public int Marcha { get; protected set; }

        public Carro() // metodo construtor
        { 
        }

        // 3 chamadas
        public void Acelerar() // caracteristica da classe //define prioridade, passa parametros
        { 
            this.Acelerar(1); // adiciona no objeto
            return; // metodos void tambem tem retorno, so que retornam vazio, sem valor
        }

        public void Acelerar(int turbo) // assinatura: mesmo nome + tipo + quantidade de parametros
        {
            int tempo = 5;
            if(turbo == 0)
            {
                for (int i = 0; i < tempo; i++)
                {
                    turbo = 5;
                    this.Velocidade += turbo;
                }
            }
            else
            {
                for (int i = 0; i < tempo; i++)
                {
                    this.Velocidade += turbo;
                }
            }

            return;

        }

        public void Frear()
        {

            this.Frear(-1);
            
        }

        public void Frear(int frenagem)
        {
            if (Velocidade > 0)
            {
                this.Velocidade -= frenagem;
                  

                    //int tempo = 5;
                    //while (Velocidade > 0)
                    //{
                    //    frenagem = 5;
                    //    this.Velocidade -= frenagem;
                    //}
                    //return;

            }else this.Re();
            
            
        }

        public void Re()
        {
            if (Velocidade <= 0)
            {
                this.Velocidade--;
                return;
            }
        }

        public void Ligar()
        {
            this.Ligado = true;
        }

        public void desligar()
        {
            this.Ligado = false;
        }

        public virtual void subirMarcha() // virtual significa comportamento padrão e que ele pode ser modificado
        {
            this.Marcha++;
            if (this.Marcha > 5) this.Marcha = 5;
        }

        public void descerMarcha()
        {
            this.Marcha--;
            if (this.Marcha < 0) this.Marcha = 0;
        }

        public void MarchaReh()
        {
            if (this.Marcha != 0)
                return;

            this.Marcha = -1;
        }




        // metodo construtor não tem tipo de retorno, porque ele tem o endereço inicial como retorno 
        // snackCase = quant_porta
        // pascalCase = CalculadoraDeImpostos
        // camelCase = quantPorta

        //public int GetVelocidade() // mostrar velocidade // pega valor
        //{
        //    return this.velocidade;
        //}

        //public void SetMarca(string marca) // alterar marca / pega o valor de fora e modifica
        //{
        //    this.marca = marca;
        //}

        //public string GetMarca() // mostrar marca / pega o valor do atributo
        //{
        //    return this.marca;
        //}
    }
}
