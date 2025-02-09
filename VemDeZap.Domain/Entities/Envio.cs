﻿using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Envio : EntityBase
    {
        
        public Campanha Campanha { get; set; }
        public Contato Contato { get; set; }
        public Grupo Grupo { get; set; }
        public bool Enviado { get; set; }
    }
}
