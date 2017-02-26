From the article:

> Dependency injection can be done in three ways.
>
>   1. Constructor injection
>   2. Method injection
>   3. Property injection

This example uses Constructor Injection.  The calling method (Main()) decides which concrete class is needed and instanitates the AppPoolWriter using that concrete class.  The AppPoolWriter is now stuck using that concrete class until a *new* AppPoolWriter is instantiated.  This example was simple, so I just re-instantiated the AppPoolWriter several times.  This would be more useful for in a situation where the concrete class didn't change so often, like using Wi-Fi or Data, using touch vs. mouse, etc.
