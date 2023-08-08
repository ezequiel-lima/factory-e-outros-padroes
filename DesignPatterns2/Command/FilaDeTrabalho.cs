namespace DesignPatterns2.Cap7
{
    public class FilaDeTrabalho
    {
        private IList<ICommand> Command = new List<ICommand>();

        public void Adiciona(ICommand command)
        {
            Command.Add(command);
        }

        public void Processa()
        {
            foreach (var command in Command)
            {
                command.Executa();
            }
        }
    }
}
