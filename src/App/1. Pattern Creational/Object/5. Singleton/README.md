# Singleton

## Introdu��o

Este padr�o restringe a instancia��o de uma classe a um objeto - ou seja - garante a exist�ncia de apenas uma inst�ncia de uma classe, mantendo um ponto global de acesso ao seu objeto. _**Nota lingu�stica**: O termo vem do significado em ingl�s para um conjunto (entidade matem�tica) que contenha apenas um elemento_.

_**Observa��o**: Existem v�rias maneiras diferentes de implementar o Padr�o Singleton em C#, desde uma vers�o sem thread-safe at� vers�es lazily-loaded, thread-safe, simples e de alto desempenho._


## Design Pattern

- **Nome**: 
    - Singleton (Que-Possui-Apenas-Um);

- **Objetivo / Inten��o**: 
    - Assegurar que uma classe tenha uma �nica inst�ncia e prover um ponto de acesso global a esta inst�ncia;

- **Motiva��o**: 
    - Algumas classes devem ser instanciadas uma �nica vez:
        - Um spooler de impress�o
        - Um sistema de arquivos
        - Um Window manager
        - Um objeto que cont�m a configura��o de um programa
        - Um log de dados
        - Uma banco de dados
        - etc.
    - Como assegurar que uma classe possua apenas uma inst�ncia e que esta inst�ncia seja facilmente acess�vel?
        - Uma vari�vel global deixa a inst�ncia acess�vel, mas n�o inibe a instancia��o m�ltipla
    - Uma melhor solu��o: fa�a com que a classe em si seja respons�vel pela manuten��o da inst�ncia �nica
        - Este � o padr�o Singleton ("que-possui-apenas-um")

- **Aplicabilidade**: 
    - Use o Padr�o Singleton quando:
        - Deve haver uma �nica inst�ncia de uma classe e esta inst�ncia deve ser acessada a partir de um ponto de acesso bem-conhecido
        - Quando a inst�ncia �nica deve ser extens�vel atrav�s de subclasses e clientes podem usar inst�ncias diferentes polimorficamente, sem modifica��o de c�digo

- **Estrutura**: 
    - Diagrama de classes (UML);

- **Consequ�ncias**: 
    - Desvantagens:
        - Qualidade da implementa��o depende da linguagem
        - Dif�cil de testar (simula��es dependem de inst�ncia extra)
        - Uso (abuso) como substituto para vari�veis globais
        - Inicializa��o lazy "pregui�osa" � complicada em ambiente multithreaded (pode se tornar um anti-pattern)
            - Ela n�o � segura para ambientes multithread, pois cada Threads pode obter uma inst�ncias distinta, ou seja, elas podem n�o acessam a mesma inst�ncia simultaneamente, e sim, cada uma Thread pode acessa nova inst�ncia;
        - Dif�cil ou imposs�vel de implementar em ambiente distribu�do (� preciso garantir que c�pias serializadas refiram-se ao mesmo objeto)
    - Vantagens:
        - Acesso controlado � inst�ncia �nica
            - O singleton tem controle sobre como e quando clientes acessam a inst�ncia
        - Espa�o de nomes reduzido
            - O Singleton � melhor que vari�veis globais, j� que as "globais" podem ser encapsuladas na inst�ncia �nica, deixando um �nico nome externo vis�vel
        - Permite refinamento de opera��es e de representa��o
            - V�rias classes Singleton (relacionadas ou n�o via heran�a) podem obedecer a mesma interface, permitindo que um singleton particular seja escolhido para trabalhar com uma determinada aplica��o em tempo de execu��o
        - Permite a exist�ncia de um n�mero vari�vel de inst�ncias
            - � f�cil fazer com que o Singleton crie um n�mero fixo, ou um n�mero m�ximo de inst�ncias em vez de apenas uma �nica inst�ncia
            - Apenas a implementa��o interna do Singleton precisa mudar
        - Mais flex�vel que m�todos est�ticos
            - Embora possa parecer que podemos fazer o equivalente a um Singleton com m�todos est�ticos, lembre-se que n�o admite-se o polimorfismo, devido ao uso de m�todos est�ticos

- **Padr�es Relacionados**
    - Para mais informa��es, consulte os seguintes padr�es relacionados:
        - [F�brica abstrata](): Em muitos casos, as Abstract Factories s�o implementadas como Singletons. Normalmente, as f�bricas devem ser globalmente acess�veis. Restringir a f�brica a uma �nica inst�ncia garante que a f�brica controle globalmente a cria��o de objetos. Isso � �til se a f�brica alocar inst�ncias de objetos de um pool de objetos.