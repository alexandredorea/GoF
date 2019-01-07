using System;
using System.Collections.Generic;
using System.Text;

namespace Version_03.Class
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
            if (instance == null)
                lock (syncLock)
                    if (instance == null)
                        instance = new Singleton();
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
