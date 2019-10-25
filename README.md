# Design Pattern: Gang of Four (GoF)
## Padrão de Projeto da Gangue dos Quatro

### Introdução

Meir Lehman uma vez disse que "*grandes sistemas de software nunca são concluídos, eles simplesmente continuam evoluindo*". E, é pensando neste contexto que, percebemos que os problemas no desenvolvimento de softwares surgem cada vez mais.

Foi assim que alguns programadores mais experientes começaram a perceber que os mesmos problemas começaram a aparecer varias e varias vezes; que a solução para aqueles problemas eram sempre os mesmos e, então, começaram a catalogar esses "padrões". Foi quando que, em 1977 o conceito de Design Pattern foi apresentado por Christopher Alexander e, em seus livros A Pattern Language, Notes on the Synthesis of Form e The Timeless Way of Building, ele estabelece o que um Pattern deve ter.

Design Pattern ou Padrão de Projeto é uma solução consolidada para um problema recorrente no desenvolvimento e manutenção de software orientado a objetos - ou seja - é uma forma de organizar as classes e objetos, onde são compartilhados conhecimentos sobre orientação à objeto aplicados a problemas que acontecem em diversos cenários de desenvolvimento de software. Além disso ao se aplicar um Design Pattern temos vários benefícios como: código mais enxuto, limpo, organizado, aumentar a qualidade, evita o retrabalho, etc.


### Gangue dos Quatro

Em 1994, antes mesmo de James Gosling apresentar a linguagem de programação Java para o mundo, um grupo de pessoas, mas especificamente quatro pessoas - Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides - lançaram o livro Design Patterns: Elements of Reusable Object-Oriented Software, iniciando os Design Patterns mais conhecido de mercado. Eles ficaram conhecidos como Gang of four ou A Gangue dos Quatro (em tradução livre).

Existem diversos patterns como, por exemplo, Connected Buildings, Car Connection, Positive Outdoor Space e muitos outros. Esses patterns somam certa de 125 padrões. Porém, neste contexto de agora, quando você ler Design Pattern vou estar me referindo apenas ao GoF ou Gang of Four ou Gangue dos Quatro.


### Classificações dos Padrões de Projetos

Os padrões são divididos em três categorias: de Criação, Estrutural e Comportamental. Todos os padrões destas categorias tem um conjunto de características específicas, que motivam a categorização deles. Mas, antes de falar das categorias, é importante comentar que os padrões de objeto, ou seja, além das categorias, podem ser classificados também em relação ao seu escopo: de Classe ou de Objetos. 

- Padrões com escopo de Classe vão utilizar a herança para compor ou variar os objetos, mantendo a flexibilidade do sistema. 
- Padrões com escopo de Objeto vão delegar as suas responsabilidades para um objeto.

A tabela a seguir permite visualizar a classificação dos padrões de projeto, de acordo com os critérios falados:


<table style="width:100%">
	<thead>
		<tr> 
			<th colspan="2">&nbsp;</th>
			<th colspan="3" align="center">Proposito</th>
		</tr>
		<tr> 
			<th colspan="2">&nbsp;</th>
			<th align="center"><a href="https://github.com/alexandredorea/GoF/tree/master/src/App/1.%20Pattern%20Creational/">Criação</a></th>
			<th align="center"><a href="#">Estrutura</a></th>
			<th align="center"><a href="#">Comportamento</a></th>
		</tr>
	</thead>
	<tbody>
		<tr> 
			<th rowspan="11" align="center">Escopo</th>
			<th align="center">Classe</th>
			<td>Factory Method</td>
			<td>Class Adapter</td>
			<td>Interpreter <br>
				Template Method
			</td>
		</tr>
		<tr>
			<th rowspan="9" align="center">Objetos</th>
			<td>Abstract Factory</td>
			<td>Object Adapter</td>
			<td>Chain of Reposponsability</td>
		</tr>
		<tr>
			<td>Builder</td>
			<td>Bridge</td>
			<td>Command</td>
		</tr>
		<tr>
			<td>Prototype</td>
			<td>Composite</td>
			<td>Iterator</td>
		</tr>
		<tr>
			<td>Singleton</td>
			<td>Decorator</td>
			<td>Mediator</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>Facede</td>
			<td>Memento</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>Flyweight</td>
			<td>Observer</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>Proxy</td>
			<td>State</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>Strategy</td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td>Visitor</td>
		</tr>
	</tbody>
</table>
