using System;
using Caelum.Stella.CSharp.Validation;

namespace ValidarCPF
{
    class Validar
    {
        public static void CPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Console.WriteLine("CPF válido: " + cpf);
            }
            catch (Exception e)
            {
                Console.WriteLine("CPF Inválido: " + cpf);
            }
        }
        public static void CNPJ(string cnpj)
        {
            try
            {
                new CNPJValidator().AssertValid(cnpj);
                Console.WriteLine("CNPJ válido: " + cnpj);
            }
            catch (Exception e)
            {
                Console.WriteLine("CNPJ Inválido: " + cnpj);
            }
        }
        public static void Titulo(string titulo)
        {
            try
            {
                new TituloEleitoralValidator().AssertValid(titulo);
                Console.WriteLine("Titulo Eleitoral válido: " + titulo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Titualo Eleitoral Inválido: " + titulo);
            }
        }
    }
}
