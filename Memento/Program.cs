using Memento;
using Memento.Models;

var product = new Product("T1", 5);
var product2 = new Product("T2", 15);
var product3 = new Product("T3", 25);

var originator = new Originator();
var caretaker = new Caretaker(originator);


originator.SetState(product);
caretaker.Save();

originator.SetState(product2);
caretaker.Save();

originator.SetState(product3);
caretaker.Save();



originator.ShowCurrentState();
caretaker.ShowChangeStack();

caretaker.Undo();

originator.ShowCurrentState();
caretaker.ShowChangeStack();

caretaker.Undo();

originator.ShowCurrentState();
caretaker.ShowChangeStack();

caretaker.Undo();
caretaker.Undo();
originator.ShowCurrentState();
caretaker.ShowChangeStack();



