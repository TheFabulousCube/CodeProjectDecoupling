From the article:

>    Dependency injection can be done in three ways.
>
>   1.     Constructor injection
>   2.     Method injection
>   3.     Property injection

This example uses Property Injection.  In Property Injection, our AppPoolWatcher class takes on a property for the action.  It doesn't have to decide which concrete action ("is a" relationship),  it is enough for it to declare the interface ("can do" relationship).  The calling class must define the concrete class, but since it's a public property, it is defined for all instances of AppPoolWatcher.  This could be handy when one part of a project decides which concrete class to use and a different part actually calls it.  For instance, a setup method may set the property based on available hardware (touch, pen, or mouse) or capabilities (store data locally or on Network based on connectivity).  Then the main program could use the method without ever know or caring **how** they are handled, only that they **are** being handled.
