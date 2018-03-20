using System;

namespace WebAPI.Models
{
    public class UsuarioModel
    {

        private int id;
        private string nome;
        private string sobrenome;
        private string email;
        private int phone;
        private DateTime birthday;

        public UsuarioModel()
        {
        }

        public UsuarioModel(int id, string nome, string sobrenome, string email, int phone, DateTime birthday)
        {
            this.id = id;
            this.Nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
            this.phone = phone;
            this.birthday = birthday;
        }

        public int Codigo
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public int Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }


    }
}
