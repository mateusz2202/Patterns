using Factory;

ShapeFactory shapeFactory = new();

var shape = shapeFactory.Create(Factory.Enums.ShapeType.Triagle);

shape.Render();