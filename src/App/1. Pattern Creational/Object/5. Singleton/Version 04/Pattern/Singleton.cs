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

        /// <summary>
        /// Atributo estático da "instância única" que vamos precisar
        /// </summary>
        private static readonly Singleton instance = new Singleton();

        #endregion

        #region Methods

        /// <summary>
        /// Construtor 'estático' explícito para informar o compilador C# 
        /// para não marcar o tipo como beforefieldinit "antes da entrada"
        /// </summary>
        static Singleton()
        {
        }

        /// <summary>
        /// Método Construtor 'privado': não pode ser utilizado fora da classe
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// Método estático GetInstance() é o principal ponto de acesso da classe e global.
        /// Ele não é tão lazy, mas é segura para thread sem usar bloqueios/travas
        /// </summary>
        /// <returns>Retorna sempre a mesma instância do objeto</returns>
        public static Singleton GetInstance()
        {
            return instance;
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

        #endregion
    }
}