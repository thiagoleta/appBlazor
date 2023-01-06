using AppContas.Web.Response;

namespace AppContas.Web.Responses
{
    public class AlterarSenhaResponse
    {
        public string? Mensagem { get; set; }
        public UsuarioResponse? Usuario { get; set; }
    }
}

