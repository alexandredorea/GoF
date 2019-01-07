using System;
using System.Collections.Generic;
namespace Version_05.Class
{
    public sealed class Singleton
    {
        private string data = string.Empty;

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            return Nested.instance;
        }

        public void SetOperation()
        {
            data = $"Só existe uma única instância, na posição {Instance().GetHashCode()}.";
        }

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
    }
}
