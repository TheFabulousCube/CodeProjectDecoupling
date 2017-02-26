From the article:

>**Dependency Inversion Principle** 
>
>Dependency inversion principle is a software design principle which provides us the guidelines to write loosely coupled classes. According to the definition of Dependency inversion principle:
>
>    1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
>    2. Abstractions should not depend upon details. Details should depend upon abstractions.

So now we have decoupled our high-level module (AppPoolWatcher) from the low-level modules.  But the AppPoolWatcher class still handles creating the concrete classes.

  This is the level of decoupling I stopped at with the [PHP shopping cart](https://github.com/TheFabulousCube/Abstract-Cart-PHP-). I only had 2 concrete classes but both had several methods, so this was enough abstraction for me.  My view [cart_view.php](https://github.com/TheFabulousCube/Abstract-Cart-PHP-/blob/master/cart_view.php) is completely decoupled from my model [cart_model.php](https://github.com/TheFabulousCube/Abstract-Cart-PHP-/blob/master/cart_model.php).  (The view doesn't know or care **where** the data comes from, only that it is presented the same at all times.)
    In this case, my [controller](https://github.com/TheFabulousCube/Abstract-Cart-PHP-/blob/master/cart.php) is acting as a data presenter, more MVP than MVC.  **That** is exaclty what I wanted.  The view should be concerned with **how** the data is presented, not **where** it comes from.  I considered using an interface, but the function *adjustQtyToInventory($itemID, $qty)* is exactly the same no matter where the cart is stored. An Abstract class allowed me to specify that method for all concrete classes and keep the code DRY.
Constructor Injection 

In this approach we pass the object of the concrete class into the constructor of the dependent class. So what we need to do to implement this is to have a constructor in the dependent class that will take the concrete class object and assign it to the interface handle this class is using. So if we need to implement this for our AppPoolWatcher class:
