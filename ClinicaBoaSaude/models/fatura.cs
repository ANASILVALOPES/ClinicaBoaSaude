using ClinicaBoaSaude.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude.models
{
    public class Fatura
    {
        private string _idFatura;
        private string _nrFatura;
        private DateTime _dtEmissao;
        private decimal _valor;

        public string IdFatura
        {
            get { return _idFatura; }
        }
        public string NrFatura
        {
            get { return _nrFatura; }
            set { _nrFatura = value; }
        }

        public DateTime DtEmissao
        {
            get { return DateTime.Now; }
            set { _dtEmissao = value; }

        }
        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Fatura () : base () 
        {
            _idFatura  = Guid.NewGuid().ToString();
            NrFatura = "";
            DtEmissao = DtEmissao ;
            Valor = 0;
               
        }

        public  string get()
        {
            string info = $"{(_idFatura)}{Environment.NewLine}";
            return info += $"; Nr:{NrFatura}; DtEmissao: {DtEmissao}; Valor {Valor} ";
        }
    }
}
