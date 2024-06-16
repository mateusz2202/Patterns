using Bridge.Interactions;
using Bridge.Models;

var circle = new Circle(new OldStylePaint(), 3);

circle.Render();
circle.Interact();

var triangle = new Triangle(new NewStylePaint());

triangle.Render();
triangle.Interact();

