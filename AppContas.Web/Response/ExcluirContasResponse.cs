using AppContas.Web.Responses;

namespace AppContas.Web.Response
{
    public class ExcluirContasResponse
    {
        public string? Mensagem { get; set; }
        public ContaResponse? Conta { get; set; }

    }
}
