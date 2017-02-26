From the article:

>    Dependency injection can be done in three ways.
>
>   1.     Constructor injection
>   2.     Method injection
>   3.     Property injection

This example uses Method Injection. The calling method (Main()) decides which concrete class is needed and calls Notify() using the concrete action along with the needed parameter.  Any method or class may create whichever concrete class it needs and pass it, along with the parameters, to *AppPoolWatcher.Notify* and get the expected results.  The AppPoolWatcher no longer cares which concrete class it's using.

