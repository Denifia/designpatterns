# Strategy Pattern

Aka "Use composition instead of inheritence"

**Type:** Behavioral

**What it is:** Define a family of algorithms, encapsulate each one, and make them interchangeable. Lets the algorithm vary independently form clients that use it.

## Notes

* An algorithm or strategy is any code you want to execute; Quack()
* Put the different strategies behind a common interface; IQuackStrategy
* Make a field or property on the calling class reference the interface; private IQuackStrategy _quackStrategy
* Instanciate the required strategy on the client (probably using DI); _quackStrategy = new NormalQuackStrategy;
* Call the algorithm via the strategy; _quackStrategy.Quack()
* The caller doesn't care if you switch out the strategy as long as it conforms to the strategy interface

