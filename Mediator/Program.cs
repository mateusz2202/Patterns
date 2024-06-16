using Mediator;
using Mediator.Compontens;

Button button = new Button();
Checkbox checkbox = new Checkbox();

new RegisterClientView(checkbox, button);


button.Click();

checkbox.Select();