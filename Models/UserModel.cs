﻿using DawnPoets.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DawnPoets.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do usuário.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite o email do usuário.")]
        [EmailAddress(ErrorMessage = "Email informado inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Selecione o tipo de perfil.")]
        public PerfilEnum? Perfil { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }
        
        //feito para gerar Id de 6 digitos aleatorio.
        public UserModel()
        {
            this.Id = new Random().Next(100000, 999999);
        }
    }
}
