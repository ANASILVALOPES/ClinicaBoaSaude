using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaBoaSaude.Models
{
    public class Contacto
    {
        private string _idContacto;
        private string _nome;
        private DateTime _dtNascimento;

        public string IdContacto
        {
            get { return _idContacto; }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                if (_nome == "") _nome = "Não Indicado";
            }
        }

        public DateTime DtNascimento
        {
            get { return _dtNascimento; }
            set
            {
                _dtNascimento = value;
            }
        }

        public Contacto()
        {
            _idContacto = Guid.NewGuid().ToString();
            Nome = "";
            DtNascimento = Convert.ToDateTime("01-01-1900");
        }

        public virtual string get()
        {
            return $"Contacto: {IdContacto}; Nome: {Nome}; Data Nasc:{DtNascimento} ";
        }
    }
}
