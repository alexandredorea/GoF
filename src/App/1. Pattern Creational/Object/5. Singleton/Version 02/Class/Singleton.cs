namespace Version_02.Class
{
    public sealed class Singleton
    {
        #region Attributes

        private string data = string.Empty;
        private static Singleton instance = null;
        private static readonly object syncLock = new object();

        #endregion

        #region Methods

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Suporta aplicações multithread através do padrão 'Double checked locking' que 
            // (uma vez que a instância existe) evita o travamento toda vez que o método é invocado
            lock (syncLock)
                if (instance == null)
                    instance = new Singleton();
            return instance;
        }

        public void SetOperation()
        {
            data = $"Só existe uma única instância, na posição {instance.GetHashCode()}";
        }

        public string GetOperation()
        {
            return data;
        }

        #endregion
    }
}
