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
        /// Atributo estático da "instância única"
        /// </summary>
        private static Singleton instance = null;

        /// <summary>
        /// Atributo que faz o controle se sincronização para evitar deadlock.
        /// </summary>
        private static readonly object syncLock = new object();

        #endregion

        #region Methods

        /// <summary>
        /// Método Construtor 'privado': não pode ser utilizado fora da classe
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// Método estático GetInstance() é o principal ponto de acesso da classe e global.
        /// Ele verifica se a variável instancia já foi iniciada, caso não tenha sido, ele 
        /// faz sua criação pela primeira e única vez. 
        /// </summary>
        /// <returns>Retorna sempre a mesma instância do objeto</returns>
        public static Singleton GetInstance()
        {
            /**
             * Isto é thread-safe - ou seja - suporta aplicações multithread através do padrão 'Double-Checked Locking' 
             * que, uma vez que a instância existe, evita o travamento (Deadlock) toda vez que o método é invocado.
             */
            lock (syncLock)
                if (instance == null)
                    instance = new Singleton();
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
