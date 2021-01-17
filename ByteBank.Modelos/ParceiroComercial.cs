namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        // código omitido
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenha(Senha, senha);
        }

    }
}