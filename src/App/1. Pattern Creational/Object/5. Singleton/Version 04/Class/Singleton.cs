namespace Version_04.Class
{
    public sealed class Singleton
    {
        #region Attributes

        private string data = string.Empty;
        private static Singleton instance = new Singleton();

        #endregion

        #region Methods

        /// <summary>
        /// Construtor estático explícito para informar o compilador C# 
        /// para não marcar o tipo como beforefieldinit "antes da entrada"
        /// </summary>
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            return instance;
        }

        public void SetOperation()
        {
            data = $"Só existe uma única instância, na posição {instance.GetHashCode()}.";
        }

        public string GetOperation()
        {
            return data;
        }

        #endregion
    }
}