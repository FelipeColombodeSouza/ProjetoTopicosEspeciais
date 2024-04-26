namespace Entidades
{
    public class Atendimento
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataConsulta { get; set; }

        public EnumConsultaStatus Status { get; set; }

        public int CodigoPaciente { get; set; }

        public int CodigoProfissional { get; set; }

        public Paciente Paciente { get; set; }

        public Profissional Profissional { get; set; }
    }

    public enum EnumConsultaStatus
    {
        Agendado = 1,
        EmAndamento = 2,
        Finalizada = 3,
        Cancelada = 9
    }
}
