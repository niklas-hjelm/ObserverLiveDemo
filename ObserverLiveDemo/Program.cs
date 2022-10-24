
using ObserverLiveDemo.ObserverPattern;
using ObserverLiveDemo.ObserverPattern.Interfaces;

ISubject blog = new Blog();
ISubject channel = new Channel();

IObserver niklas = new Subscriber("Niklas");
IObserver kalle = new Subscriber("Kalle");
IObserver pelle = new Subscriber("Palle");

blog.Subscribe(niklas);
channel.Subscribe(pelle);

blog.Subscribe(kalle);
blog.Subscribe(pelle);

blog.Upload("Great Breakfast!");
channel.Upload("Cooking bacon!");

blog.Unsubscribe(kalle);
blog.Unsubscribe(pelle);

blog.Upload("Amazing Dinner!");
