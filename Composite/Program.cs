using Composite;

var root = new Composite.Composite("root");
root.Add(new Leaf("l1"));
root.Add(new Leaf("l2"));

var branch = new Composite.Composite("branch");
branch.Add(new Leaf("l1"));
branch.Add(new Leaf("l2"));

var branch2 = new Composite.Composite("branch2");
branch2.Add(new Leaf("l1"));

branch.Add(branch2);

root.Add(branch);

root.Add(new Leaf("l3"));


root.Display(1);


