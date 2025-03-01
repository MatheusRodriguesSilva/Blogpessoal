﻿using Blogpessoal.src.modelos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.src.repositorios
{
    public interface ITema
    {
        /// <summary>
        /// <para>Resumo: Classe espelho para criar um novo tema</para>
        /// <para>Criado por: Matheus Rodrigues/para>
        /// <para>Versão: 1.0</para>
        /// <para>Data: 29/04/2022</para>
        /// </summary>
        public class NovoTemaDTO
        {
            [Required, StringLength(20)]
            public string Descricao { get; set; }
            public NovoTemaDTO(string descricao)
            {
                Descricao = descricao;
            }
        }

        /// <summary>
        /// <para>Resumo: Classe espelho para alterar um tema</para>
        /// <para>Criado por: Matheus Rodrigues</para>
        /// <para>Versão: 1.0</para>
        /// <para>Data: 29/04/2022</para>
        /// </summary>
        public class AtualizarTemaDTO
        {
            [Required, StringLength(20)]
            public string Descricao { get; set; }
            public AtualizarTemaDTO(string descricao)
            {
                Descricao = descricao;
            }
        }
    }
}

