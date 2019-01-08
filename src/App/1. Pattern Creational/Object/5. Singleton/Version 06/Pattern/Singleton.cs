using System;

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

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

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
        /// </summary>
        /// <returns>Retorna sempre a mesma instância do objeto</returns>
        public static Singleton GetInstance()
        {
            return lazy.Value;
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