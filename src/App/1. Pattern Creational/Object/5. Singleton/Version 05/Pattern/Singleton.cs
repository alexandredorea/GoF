namespace Pattern
{
    /// <summary>
    /// Classe 'Singleton'
    /// </summary>
    public sealed class Singleton
    {
        #region Attributes

        /// <summary>
        /// Atributo para exibir mensagem de evidência no sandbox
        /// </summary>
        private string data = string.Empty;

        #endregion

        #region Methods

        /// <summary>
        /// Método Construtor 'privado': não pode ser utilizado fora da classe
        /// </summary>
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return Nested.instance;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetOperation()
        {
            data = $"A instância atual está na posição de memória {GetInstance().GetHashCode()}.";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetOperation()
        {
            return data;
        }

        private class Nested
        {
            /// <summary>
            /// Construtor estático explícito para informar o compilador C# 
            /// para não marcar o tipo como beforefieldinit "antes da entrada"
            /// </summary>
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }

        #endregion
    }
}
