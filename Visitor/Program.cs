using Visitor;

var document = new Document();

document.AddNode("N1");
document.AddNode("Na2");
document.AddNode("Nab3");
document.AddNode("N4");
document.AddNode("Nb5");

document.Validation(new ValidatorA());



