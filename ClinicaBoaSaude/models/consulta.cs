
using ClinicaBoaSaude.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Consulta
{
    private string _id;
    private DateTime _dtConsulta;
    private decimal _puConsulta;
    private Medico _medicoResponsavel;
    private Utente _utenteConsultado;
    private Fatura _faturaConsulta;
    List<Tratamento> _lstTratamento;

    public string Id
    {
        get { return _id; }
    }

    public DateTime DtConsulta
    {
        get { return _dtConsulta; }
    }

    public decimal PuConsulta
    {
        get { return _puConsulta; }
        set
        {
            _puConsulta = value;
            if (_puConsulta < 0) _puConsulta = 0;
        }
    }

    public Medico MedicoResponsavel
    {
        get { return _medicoResponsavel; }
        set { _medicoResponsavel = value; }
    }

    public Utente UtenteConsultado
    {
        get { return _utenteConsultado; }
        set { _utenteConsultado = value; }
    }

    public Fatura FaturaConsulta
    {
        get { return _faturaConsulta; }
        set
        {
            _faturaConsulta = value;
            if (UtenteConsultado.IsentoTaxa) _faturaConsulta.Total = 0;
            else _faturaConsulta.Total = ValorTotalConsulta;
        }
    }

    public void AddTratamento(Tratamento tratamento)
    {
        _lstTratamento.Add(tratamento);
    }

    public Consulta()
    {
        _id = Guid.NewGuid().ToString();
        _dtConsulta = DateTime.Now;
        _lstTratamento = new List<Tratamento>();
        PuConsulta = 0;
        MedicoResponsavel = new Medico();
        UtenteConsultado = new Utente();
        FaturaConsulta = new Fatura();
    }

    public string get()
    {
        string outInfo = $"Consulta: {Id} de: {DtConsulta}; PU: {PuConsulta}; Feita por: {MedicoResponsavel.get()}; A: {UtenteConsultado.get()}{Environment.NewLine}";
        if (_lstTratamento.Count > 0)
        {
            outInfo += $"Tratamentos Efetuados:-----------------------------------------{Environment.NewLine}";
            foreach (Tratamento tratamento in _lstTratamento)
            {
                outInfo += $"{tratamento.get()}{Environment.NewLine}";
            }
        }
        else
        {
            outInfo += "Sem tratamentos adicionais";
        }
        return outInfo;
    }

    public decimal ValorTratamentos
    {
        get
        {
            decimal valorTratamentos = 0;
            if (_lstTratamento.Count > 0)
            {
                foreach (Tratamento tratamento in _lstTratamento)
                {
                    valorTratamentos += tratamento.Total;
                }
            }
            return valorTratamentos;
        }
    }

    public decimal ValorTotalConsulta
    {
        get
        {
            decimal somatorio = ValorTratamentos;
            somatorio += PuConsulta;
            return somatorio;
        }
    }
}       
        
            
}        

      
    

