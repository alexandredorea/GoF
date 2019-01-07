namespace Version_01.Class
{
    public sealed class Singleton
    {
        #region Attributes

        private string data = string.Empty;
        private static Singleton instance = null;

        #endregion

        #region Methods

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
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
