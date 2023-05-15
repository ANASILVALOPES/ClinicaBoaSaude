using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude.Models
{
    public class Enfermeiro : Contacto
    {

        private string _idEnfermeiro;
        private string _nrOrdem;
        private string _Unidade;

        public string IdEnfermeiro
        {
            get { return this._idEnfermeiro; }
        }


        public string NrOrdem
        {
            get { return _nrOrdem; }
            set { _nrOrdem = value; }
        }

        public string Unidade
        {
            get { return _Unidade; }
            set { _Unidade = value; }
        }

        public Enfermeiro() : base()
        {
            _idEnfermeiro = Guid.NewGuid().ToString();
            NrOrdem = "";
            Unidade = "";
        }

        public override string get()
        {
            string info = $"{base.get()}{Environment.NewLine}";
            return info += $"Enfermeiro: {IdEnfermeiro}; Nr:{NrOrdem}; Unidade: {Unidade}";
        }
    }
}

