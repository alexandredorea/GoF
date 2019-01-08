namespace Pattern
{
    /// <summary>
    /// Classe 'Singleton'
    /// </summary>
    public sealed class Singleton
    {
        #region Attributes

        /// <summary>
        /// Atributo para exibir mensagem de evidência
        /// </summary>
        private string data = string.Empty;

        /// <summary>
        /// Atributo estático da "instância única"
        /// </summary>
        private static Singleton instance = null;

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
             * A instanciação não é executada até que um objeto peça uma instância; 
             * essa abordagem é chamada de instanciação lenta ou preguiçosa (Inicialização Lazy). 
             * Instanciação preguiçosa evita instanciar singletons desnecessários quando o aplicativo é iniciado.
             * Nota: Isto não é thread-safe.
             */
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
