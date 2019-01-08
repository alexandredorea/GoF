Singleton
==========
Segunda versão - Simples thread-safe
----------

- **Lazy Initialization**: Sim
- **Seguro em ambientes multithread**: Sim
- **Nível de dificuldade**: Fácil
- **Descrição**: Neste exemplo você vai encontrar uma implementação thread-safe. A thread realize um bloqueio em um objeto compartilhado e, em seguida, verifica se a instância foi ou não criada antes de criar o objeto em memória. 
				 Isso cuida do problema de memória (o bloqueio garante que todas as leituras ocorram após o bloqueio, e o desbloqueio garante que todas as gravações ocorram antes da liberação do bloqueio), e, por fim, garante também 
				 que apenas uma thread criará uma instância (só uma única thread pode estar nessa parte do código de cada vez - no momento em que a segunda thread acessar, a primeira thread terá criado a instância, então a expressão 
				 será avaliada como false). Infelizmente, o desempenho é prejudicado à medida que um bloqueio é obtido toda vez que a instância é solicitada.
- **Observação**: Note que, em vez de travar com `typeof(Singleton)` como acontece com algumas versões dessa implementação, eu bloqueio o valor de uma variável estática que é privada para a classe. 
                  Bloquear objetos que outras classes podem acessar e bloquear (tal como o tipo) pode causar problemas de desempenho e até mesmo conflitos. 
                  Esta é uma preferência de estilo minha - sempre que possível, bloqueie apenas objetos criados especificamente com o propósito de bloquear, ou em qual documento eles devem ser bloqueados 
				  para propósitos específicos (por exemplo, para esperar / pulsar uma fila). Normalmente, esses objetos devem ser privados para a classe em que são usados. 
				  Isso ajuda a tornar a gravação de aplicativos thread-safe significativamente mais fácil.