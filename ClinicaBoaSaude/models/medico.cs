using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude.Models
{
    public class Medico : Contacto
    {
        
        private string _idMedico;
        private string _nrOrdem;
        private string _Especialidade;

        public string Idmedico
        {
            get { return this._idMedico; }
        }

      
        public string NrOrdem
        {
            get { return _nrOrdem; }
            set { _nrOrdem = value; }
        }

        public string Especialidade
        {
            get { return _Especialidade; }
            set { _Especialidade = value; }
        }

        public Medico() : base()
        {
            _idMedico = Guid.NewGuid().ToString();
            NrOrdem = "";
            Especialidade = "";
        }

        public override string get()
        {
            string info = $"{base.get()}{Environment.NewLine}";
            return info += $"Medico: {Idmedico}; Nr:{NrOrdem}; Especialidade: {Especialidade}";
        }
    }
}


