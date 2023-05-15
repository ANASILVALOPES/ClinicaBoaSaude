using ClinicaBoaSaude.models;
using ClinicaBoaSaude.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto = new Contacto();
            Console.WriteLine(contacto.get());


            Utente utente = new Utente();
            Console.WriteLine(utente.get());

            Medico medico = new Medico();
            Console.Write(medico.get());

            Enfermeiro enfermeiro = new Enfermeiro();
            Console.WriteLine(enfermeiro.get());

            Tratamento tratamento = new Tratamento();   
            Console.WriteLine(tratamento.get());


            Console.ReadLine();
        }
    }
}
