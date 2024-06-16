using Observer;

var publisher = new Publisher();

var s1 = new Subscriber("s1");
var s2 = new Subscriber("s2");
var s3 = new Subscriber("s3");

publisher.Subscribe(s1);
publisher.Subscribe(s2);
publisher.Subscribe(s3);


publisher.Notify("hello");

publisher.Unsubscribe(s2);

publisher.Notify("second message");

