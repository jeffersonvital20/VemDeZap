using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Campanha : EntityBase
    {
        public string Nome { get; set; }
        public Usuario Ususario { get; set; }
    }
}
