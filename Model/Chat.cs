namespace ChatWeb.Model
{

    public class Chat
    {
        public string Nome { get; set; }
        public string Mensagem { get; set; }

        public Chat(string nome, string mensagem)
        {
            Nome = nome;
            Mensagem = mensagem;    
        }
    }
}
