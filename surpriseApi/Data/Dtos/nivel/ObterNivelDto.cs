﻿using System.ComponentModel.DataAnnotations;

namespace surpriseApi.Data.Dtos.nivel;

public class ObterNivelDto
{
    [Required(ErrorMessage = "Identificador do usuário nescessário")]
    public int Usuarioid { get; set; }
}
