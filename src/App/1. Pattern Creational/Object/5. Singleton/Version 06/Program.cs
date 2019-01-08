using Pattern;
using System;

namespace Version_06
{
    /// <summary>
    /// Classe que inicia o método Main() para o conceito básico de Singleton
    /// Singleton Design Pattern
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Ponto de entrada para o Console Application
        /// </summary>
        private static void Main()
        {
            // Construtor é 'privado': é inacessível neste nível (não pode criar nova instância)
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();

            // Verifica se é a mesma instância, para provar o conceito deste Pattern
            if (ReferenceEquals(instance1, instance2))
            {
                instance1.SetOperation();
                Console.WriteLine("Os objetos têm realmente a mesma instância.");
                Console.WriteLine($"Ambos são do tipo: {instance1.GetType().Name}.");
                Console.WriteLine(instance1.GetOperation());
            }

            // Aguarda pelo usuário
            Console.ReadKey();
        }
    }
}
