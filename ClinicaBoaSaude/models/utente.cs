using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude.Models
{
    public class Utente : Contacto
    {
        private string _idUtente;
        private string _nrUtente;
        private Medico _medicoFamilia;
        private Boolean _isentoTaxa;

        public string IdUtente
        {
            get { return this._idUtente; }
        }

        public string NrUtente
        {
            get { return _nrUtente; }
            set { _nrUtente = value; }
        }

        public Boolean IsentoTaxa
        {
            get { return _isentoTaxa; }
            set { _isentoTaxa = value; }
        }

        public Medico Medico
        {
            get { return _medicoFamilia; }
            set { _medicoFamilia = value; }
        }

        public Utente() : base()
        {
            _idUtente = Guid.NewGuid().ToString();
            IsentoTaxa = false;
            Medico = new Medico();
            NrUtente = "";
        }

        public override string get()
        {
            string info = $"Utente: {(IdUtente)};{Environment.NewLine};Nr:{NrUtente}; Taxa: { IsentoTaxa}";
            return info += $"{base.get()}Com Medico De Familia - {Medico.get()}";
        }
    }
}

