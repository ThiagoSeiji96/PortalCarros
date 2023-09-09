﻿namespace Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
    }
}