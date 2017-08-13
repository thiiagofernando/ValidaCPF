using System;
using Caelum.Stella.CSharp.Format;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            CPFFormatter formataCPF = new CPFFormatter();
            CNPJFormatter formataCNPJ = new CNPJFormatter();
            TituloEleitoralFormatter formataTitulo = new TituloEleitoralFormatter();

            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            Validar.CPF(formataCPF.Format(cpf1));
            Validar.CPF(formataCPF.Format(cpf2));
            Validar.CPF(formataCPF.Format(cpf3));
            
            string cnpj1 = "3996227300015200";
            string cnpj2 = "24865730000113";
            string cnpj3 = "65439258000134";
            string cnpj4 = "24.865.730/0001-13";

            Validar.CNPJ(formataCNPJ.Format(cnpj1));
            Validar.CNPJ(formataCNPJ.Format(cnpj2));
            Validar.CNPJ(formataCNPJ.Format(cnpj3));
            //Removendo Formatacao
            Validar.CNPJ(formataCNPJ.Unformat(cnpj4));

            

            string titulo1 = "885553350175";
            string titulo2 = "8855533501750";

            Validar.Titulo(formataTitulo.Format(titulo1));
            Validar.Titulo(formataTitulo.Format(titulo2));

            Console.ReadKey();


        }

    }
}
