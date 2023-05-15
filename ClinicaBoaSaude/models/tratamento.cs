using ClinicaBoaSaude.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude.models
{
    public class Tratamento
    {
        private string _idTratamento;
        private string _designacao;
        private decimal _qtd;
        private decimal _valorUnitario;
        private Enfermeiro _Enfermeiro;


        public string IdTratamento
        {
            get { return this._idTratamento; }
        }

        public string Designacao
        { get { return this._designacao; } }

        public decimal qtd
        { get { return this._qtd; } }

        public Enfermeiro Enfermeiro
        {
            get { return this._Enfermeiro; }
            set { this._Enfermeiro = value; }

        }

        public Tratamento() : base()
        {
            _idTratamento = Guid.NewGuid().ToString();
            _designacao = "";
            _qtd = 0;
            _valorUnitario = 0;
            Enfermeiro = new Enfermeiro();
        }

        public string get ()
        {
            string info = $"designacao:{_designacao} {Environment.NewLine}; qtd:{_qtd}; valorUnitario {_valorUnitario}";
            return info += $"{Enfermeiro.get()} Enfermeiro - {Enfermeiro.get()}";
        }


    }
}
