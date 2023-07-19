# Kata Life

## Description
The goal of this Kata is to learn and practice the Test-Driven Development (TDD) technique.
You will program a player's life bar that can be increased or decreased, for example.

Please consider Clean Code(http://cleancoder.com/products), DRY(https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), and KISS(https://en.wikipedia.org/wiki/KISS_principle) principles in each iteration.

#### Constrains
* Write the best code you can, but keep it simple.
* Do not do more than what each iteration asks for.

## First iteration:
* You can add and subtract life from the player's bar. 
* The minimum is 0 and it starts at 100.
* The maximum life is 100.
* If the player loses life (gets attacked) when at 0, the number should not go negative. 

## Second iteration:
If the player gains life (takes a potion) when at 100, the number should not exceed 100.

## Third iteration:
The player can take a magical potion that gives them 50 life, even if they are at the maximum (it would be 150).
If the player heals, it does not keep increasing, no matter if it's between 101 and 150, it only adds life when back to a value less than 100.

## Fourth iteration::
The player can take a magical potion that gives them 50 life, even if they are at the maximum (it would be 150).
If the player heals, it does not keep increasing, no matter if it's between 101 and 150, it only adds life when back to a value less than 100.

## Fifth iteration:
The player can be poisoned, which makes each attack count as x2.


## Additional references
- [Pair Programming](https://martinfowler.com/articles/on-pair-programming.html)
- [TDD](https://www.paradigmadigital.com/techbiz/tdd-una-metodologia-gobernarlos-todos/)
- [TDD](https://www.guru99.com/test-driven-development.html)
- [Clean Code](https://www.amazon.com/-/es/Robert-C-Martin/dp/0132350882)
