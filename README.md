# AlertToast

A simple framework for creating and managing toast notifications in C#/Winforms.

In it's current state, it has a very basic theming system,
here are the example themes included in the AlertExample project:
![Screenshot](https://i.imgur.com/R7ZzCor.png)

## Features
* Tiling
  * Between the AlertManager class and the Alert class, alerts will tile vertically until there is no more screen space, and then wrap back around and start a new column and repeat. New alerts are always opened at the top of the "stack". 
* Animation
  * One animation is hardcoded at this time using the User32 Win APIs. More are planned.
* Timer
  * Toasts/Alerts can be displayed for a specific amount of time, or left on screen until the user closes them.
* Rich Text
  * The body of the message is displayed using a rich text control.
  * Future plans are to add an HTML version as well.

