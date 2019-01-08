# Singleton

## Introdução

Este padrão restringe a instanciação de uma classe a um objeto - ou seja - garante a existência de apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto. _**Nota linguística**: O termo vem do significado em inglês para um conjunto (entidade matemática) que contenha apenas um elemento_.

_**Observação**: Existem várias maneiras diferentes de implementar o Padrão Singleton em C#, desde uma versão sem thread-safe até versões lazily-loaded, thread-safe, simples e de alto desempenho._


## Design Pattern

- **Nome**: 
    - Singleton (Que-Possui-Apenas-Um);

- **Objetivo / Intenção**: 
    - Assegurar que uma classe tenha uma única instância e prover um ponto de acesso global a esta instância;

- **Motivação**: 
    - Algumas classes devem ser instanciadas uma única vez:
        - Um spooler de impressão
        - Um sistema de arquivos
        - Um Window manager
        - Um objeto que contém a configuração de um programa
        - Um log de dados
        - Uma banco de dados
        - etc.
    - Como assegurar que uma classe possua apenas uma instância e que esta instância seja facilmente acessível?
        - Uma variável global deixa a instância acessível, mas não inibe a instanciação múltipla
    - Uma melhor solução: faça com que a classe em si seja responsável pela manutenção da instância única
        - Este é o padrão Singleton ("que-possui-apenas-um")

- **Aplicabilidade**: 
    - Use o Padrão Singleton quando:
        - Deve haver uma única instância de uma classe e esta instância deve ser acessada a partir de um ponto de acesso bem-conhecido
        - Quando a instância única deve ser extensível através de subclasses e clientes podem usar instâncias diferentes polimorficamente, sem modificação de código

- **Estrutura**: 
    - Diagrama de classes (UML);

- **Consequências**: 
    - Desvantagens:
        - Qualidade da implementação depende da linguagem
        - Difícil de testar (simulações dependem de instância extra)
        - Uso (abuso) como substituto para variáveis globais
        - Inicialização lazy "preguiçosa" é complicada em ambiente multithreaded (pode se tornar um anti-pattern)
            - Ela não é segura para ambientes multithread, pois cada Threads pode obter uma instâncias distinta, ou seja, elas podem não acessam a mesma instância simultaneamente, e sim, cada uma Thread pode acessa nova instância;
        - Difícil ou impossível de implementar em ambiente distribuído (é preciso garantir que cópias serializadas refiram-se ao mesmo objeto)
    - Vantagens:
        - Acesso controlado à instância única
            - O singleton tem controle sobre como e quando clientes acessam a instância
        - Espaço de nomes reduzido
            - O Singleton é melhor que variáveis globais, já que as "globais" podem ser encapsuladas na instância única, deixando um único nome externo visível
        - Permite refinamento de operações e de representação
            - Várias classes Singleton (relacionadas ou não via herança) podem obedecer a mesma interface, permitindo que um singleton particular seja escolhido para trabalhar com uma determinada aplicação em tempo de execução
        - Permite a existência de um número variável de instâncias
            - É fácil fazer com que o Singleton crie um número fixo, ou um número máximo de instâncias em vez de apenas uma única instância
            - Apenas a implementação interna do Singleton precisa mudar
        - Mais flexível que métodos estáticos
            - Embora possa parecer que podemos fazer o equivalente a um Singleton com métodos estáticos, lembre-se que não admite-se o polimorfismo, devido ao uso de métodos estáticos

- **Padrões Relacionados**
    - Para mais informações, consulte os seguintes padrões relacionados:
        - [Fábrica abstrata](): Em muitos casos, as Abstract Factories são implementadas como Singletons. Normalmente, as fábricas devem ser globalmente acessíveis. Restringir a fábrica a uma única instância garante que a fábrica controle globalmente a criação de objetos. Isso é útil se a fábrica alocar instâncias de objetos de um pool de objetos.