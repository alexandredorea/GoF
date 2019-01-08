Singleton
==========
Primeira versão - Não é thread-safe
----------

- **Lazy Initialization**: Sim
- **Seguro em ambientes multithread**: Não
- **Nível de dificuldade**: Fácil
- **Descrição**: Este método é a forma mais básica de implementação de Singleton, o maior problema dele é não suportar multithreading. 
                 Se dois threads diferentes realizarem o teste `if (instance == null)`, o resultado encontrado será `true`, então ambos criam instâncias diferentes, o que viola o padrão singleton. 
				 O Lazy Initialization implementado desta forma, obviamente, não requer segurança de thread, mas como percebemos a execução em um ambiente multithreaded não funciona de 
				 forma correta como propõe o pattern. [Versão 02 - Simples thread-safety](https://github.com/alexandredorea/GoF/tree/master/src/App/1.%20Pattern%20Creational/Object/5.%20Singleton/Version%2002)
- **Observação**: Este código é muito ruim. Então, não use.