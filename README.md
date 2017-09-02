# AlertToast

A simple framework for creating and managing toast notifications in C#/Winforms.

In it's current state, it has a very basic theming system,
here are the example themes included in the AlertExample project:
![Screenshot](https://i.imgur.com/R7ZzCor.png)

## AlertManager/Alerts
Between the AlertManager class and the Alert class, alerts will tile vertically until there is no more screen space, and then wrap back around and start a new column and repeat. New alerts are always opened at the top of the "stack". 
