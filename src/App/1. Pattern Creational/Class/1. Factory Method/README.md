# Factory Method

**Contexto**

Suponha que você deve trabalhar em um projeto computacional com um conjunto de carros, cada um de uma determinada fábrica. Para exemplificar suponha os quatro seguintes modelos/fabricantes:

| Modelo | Fabricante |
|--------|------------|
| Palio  | Fiat       |
| Gol    | Volkswagen |
| Celta  | Chevrolet  |
| Fiesta | Ford       |

Será necessário manipular este conjunto de carros em diversas operações. 

**Como poderíamos modelar este problema?**

Uma primeira solução, mais simples, seria criar uma classe para representar cada carro, no entanto ficaria muito difícil prever as classes ou escrever vários métodos iguais para tratar cada um dos tipos de objetos.

Poderíamos então criar uma classe base para todos os carros e especializá-la em subclasses que representem cada tipo de carro, assim, uma vez definida uma interface comum poderíamos tratar todos os carros da mesma maneira. 

O problema surge quando vamos criar o objeto, pois, de alguma forma, precisamos identificar qual objetos queremos criar. Ou seja, precisaríamos criar uma enumeração para identificar cada um dos carros e, ao criar um carro, identificaríamos seguindo essa enumeração. Veja o código abaixo:

```csharp
public enum ModeloCarro
{
    Palio,
    Gol,
    Celta,
    Fiesta
}
```

A classe de criação de carros:

```csharp
public abstract class FabricaCarro
{
    public Carro CriarCarro(ModeloCarro modelo)
    {
        switch (modelo)
        {
          case Celta:
              return new Celta();
              break;
          case Fiesta:
              return new Fiesta();
              break;
          case Gol:
              return new Gol();
              break;
          case Palio:
              return new Palio();
              break;
          default:
              break;
        }
    }
}
```

Esta implementação já corresponde a uma implementação do Factory Method, pois um **Método Fábrica** cria Objetos concretos que só serão definidos em tempo de execução. 

No entanto, esta implementação traz um problema quanto a manutenibilidade do código, pois, como utilizamos um `switch` para definir qual objeto criar, a cada criação de um novo modelo de carro precisaríamos incrementar este `switch` e criar novas enumerações. 

**Como resolver este problema?**

O padrão Factory Method possui a seguinte intenção:

*`"Definir uma interface para criar um objeto, mas deixar as subclasses decidirem que classe instanciar. O Factory Method permite adiar a instanciação para subclasses." (GAMMA)`*

Ou seja, ao invés de criar objetos diretamente em uma classe concreta, nós definimos uma interface de criação de objetos e cada subclasse fica responsável por criar seus objetos. Seria como se, ao invés de ter uma fábrica de carros, nós tivéssemos uma fábrica da Fiat, que cria o carro da Fiat, uma fábrica da Ford, que cria o carro da Ford e etc.

A nossa interface de fábrica seria bem simples:

```csharp
public interface IFabricaDeCarro 
{
    Carro CriarCarro();
}
```

E, tão simples quanto, seriam as classes concretas para criar carros:

```csharp
public class FabricaFiat : IFabricaDeCarro 
{
    public override Carro CriarCarro() {
        return new Palio();
    }
}
```

As outras fábricas seguem a mesma ideia, cada uma define o método de criação de carros e cria o seu próprio carro. Agora que vimos as classes fábricas, vamos analisar os produtos.

Como já discutimos antes, vamos criar uma interface comum para todos os carros, assim poderemos manipulá-los facilmente:

```csharp
public interface ICarro 
{
    void ExibirInfo();
}
```

Para o nosso exemplo vamos considerar apenas que precisamos exibir informações sobre os carros. Quaisquer outras operações seriam definidas nessa interface também. Caso uma mesma operação precisasse ser definida para todos os carros poderíamos implementar esta classe como uma classe abstrata e implementar os métodos necessários.

Os produtos concretos seriam definidos da seguinte maneira:

```csharp
public class Palio : ICarro 
{
    public override void ExibirInfo() 
    {
        Console.Wrileline("Modelo: Palio")
          .Wrileline("Fabricante: Fiat");
    }
}
```

Ou seja, no final das contas teríamos a seguinte estrutura:

<Imagem>

**Considerações finais**

Como vimos, a principal vantagem em utilizar o padrão Factory Method é a extrema facilidade que temos para incluir novos produtos. Não é necessário alterar NENHUM código, apenas precisamos criar o produto e a sua fábrica. Todo o código já escrito não será alterado.

No entanto isto tem um custo. Perceba que criamos uma estrutura relativamente grande para resolver o pequeno problema, temos um conjunto grande de pequenas classes, cada uma realizando uma operação simples. Apesar de seguir o [princípio da responsabilidade única](https://github.com/alexandredorea/SOLID/tree/master/src/1.%20SRP), para cada novo produto precisamos sempre criar duas classes, uma produto e uma fábrica.

Na primeira sugestão de implementação nós definimos o Factory Method em uma classe concreta, isso evita a criação de várias classes pequenas de fábrica, no entanto acaba criando um código gigante para criação de objetos. Durante a implementação é necessário escolher qual tipo de implementação resolve melhor o seu problema.



Se gostou do post compartilhe com seus amigos e colegas, senão, comente o que pode ser melhorado. Encontrou algum erro no código? Comente também. Possui alguma outra opinião ou alguma informação adicional? Comenta ai! 😀


**Referências:**

GAMMA, Erich et al. Padrões de Projeto: Soluções reutilizáveis de software orientado a objetos.

WIKIPEDIA. SOLID. Disponível em: http://en.wikipedia.org/wiki/SOLID_(object-oriented_design). Acesso em: 15 set. 2019.
