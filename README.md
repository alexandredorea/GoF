# Design Pattern: Gang of Four (GoF)
## Padrão de Projeto da Gangue dos Quatro


### Introdução

Lehman uma vez disse que "*grandes sistemas de software nunca são concluídos, eles simplismente continuam evoluindo*". E, é pensando neste contexto que, percebemos que os problemas no desenvolvimento de softwares surgem cada vez mais. 

Contudo, alguns programadores mais experientes começaram a perceber que os mesmos problemas começaram a aparecer varias e varias vezes; que a solução para aqueles problemas eram sempre os mesmos e, então, começaram a catalogar esses "padrões". Então, em 1977 o conceito de Design Pattern foi apresentado por Christopher Alexander e, em seus livros A Pattern Language, Notes on the Synthesis of Form e The Timeless Way of Building, ele estabelece o que um Pattern deve ter.

Design Pattern ou Padrão de Projeto é uma solução consolidada para um problema recorrente no desenvolvimento e manutenção de software orientado a objetos - ou seja - é uma forma de organizar as classes e objetos, onde são compartilhados conhecimentos sobre orientação à objeto aplicados a problemas que acontecem em diversos cenários de desenvolvimento de software. Além disso ao se aplicar um Design Pattern temos vários benefícios como: código mais enxuto, limpo, organizado, aumentar a qualidade, evita o retrabalho, etc.


### A Gangue dos Quatro

Em 1994, antes mesmo de James Gosling apresentar a linguagem de programação Java para o mundo, um grupo de pessoas, mas especificamente quatro pessoas - Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides - lançaram o livro Design Patterns: Elements of Reusable Object-Oriented Software, iniciando os Design Patterns mais conhecido de mercado. Eles ficaram conhecidos como Gang of four ou A Gangue dos Quatro (em tradução livre).

Existem diversos patterns como, por exemplo, Connected Buildings, Car Connection, Positive Outdoor Space e muitos outros. Esses patters somam certa de 125 padrões. Porém, neste contexto de agora, quando você ler Design Patter vou estar me referindo apenas ao GoF ou Gang of Four ou Gangue dos Quatro. 

Um Design Pattern possui um formato ou elementos essesnciais, são eles:

- **Nome**: 
    - Uma identificação para o patterns
    - Descreve o problema de projeto, suas soluções e consequências em poucas palavras
    - Permite projetar num nível mais alto de abstração
    - Permite falar com outros sobre soluções e documentar código, já que os nomes de padrões estão ficando padronizados

- **Objetivo / Intenção**: 
  - Também conhecido como (Also Known As ou aKa);
  
- **Motivação**: 
  - Um cenário mostrando o problema e a necessidade;
  
- **Aplicabilidade**: 
  - Como identificar as situações nas quais os padrões é aplicável;

- **Estrutura**: 
    - Uma representação gráfica da estrutura das classes usando um diagrama de classes (UML);

- **Consequências**: 
  - Vantagens e desvantagem; 
  - Os resultados e trade-offs da aplicação do padrão;
  - Diz respeito a trade-offs de espaço, tempo, flexibilidade, extensibilidade, portabilidade e eficiência do sistema;

- **Implementações**: 
    - Quais detalhes devemos nos preocupar quando implementamos o padrão. Detalhes de cada linguagem;

- **Usos conhecidos**;

- **Padrões Relacionados**

Estes Design Patterns também são classificados em três categorias: Padrões de Criação, Padrões Estruturais e Padrões Comportamentais. Na figura abaixo podemos ver os patterns com sua classificação.


### [Padrões de Criação](https://github.com/alexandredorea/GoF/tree/master/src/App/1.%20Pattern%20Creational/)

São Design Patterns que visam separar um sistema de como seus objetos são criados, compostos e representados. Eles aumentam a flexibilidade do sistema em termos do que, quem, como e quando criar o objeto, tentando criar objetos de maneira adequada à situação.

- [ ] [**Abstract factory (Fábrica abstrata)**]()
- [ ] [**Builder (Construtor)**]()
- [ ] [**Factory method (Método fábrica)**]()
- [x] [**Singleton**](https://github.com/alexandredorea/GoF/tree/master/src/App/1.%20Pattern%20Creational/Object/5.%20Singleton)
- [ ] [**Prototype (Protótipo)**]()


### [Padrões Estruturais]()

Em construção

### [Padrões de Comportamento]()

Em construção
