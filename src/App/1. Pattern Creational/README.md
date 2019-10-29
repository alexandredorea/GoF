## Padrões de Criação

Os padrões de criação tem como intenção principal abstrair o processo de criação de objetos, ou seja, a sua instanciação. Desta maneira o sistema não precisa se preocupar com questões sobre, como o objeto é criado, como é composto, qual a sua representação real. Quando se diz que o sistema não precisa se preocupar com a instanciação do objeto quer dizer que, se ocorrer alguma mudança neste ponto, o sistema em geral não será afetado. Isso é a famosa flexibilidade que os padrões de projeto buscam.

Padrões de criação com escopo de classe vão utilizar herança para garantir que a flexibilidade. Por exemplo, o padrão Factory Method pode criar várias subclasses para criar o produto. Já os padrões com escopo de Objeto, como o Prototype, delegam para um objeto (no caso o protótipo) a responsabilidade de instanciar novos objetos.

### Os Padrões de Objeto de Criação

- [x] [**Factory Method**][factory_method]
- [ ] [**Abstract Factory**]()
- [ ] [**Builder**]()
- [ ] [**Prototype**]()
- [x] [**Singleton**][singleton]


[factory_method]: <https://github.com/alexandredorea/GoF/tree/master/src/App/1.%20Pattern%20Creational/Class/1.%20Factory%20Method>
[singleton]: <https://github.com/alexandredorea/GoF/tree/master/src/App/1.%20Pattern%20Creational/Object/5.%20Singleton>
