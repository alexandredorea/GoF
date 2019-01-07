using System;

namespace Version_06.Class
{
    public sealed class Singleton
    {
        private string data = string.Empty;
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            return lazy.Value;
        }

        public void SetOperation()
        {
            data = $"Só existe uma única instância, na posição {lazy.GetHashCode()}.";
        }

        public string GetOperation()
        {
            return data;
        }
    }
}
