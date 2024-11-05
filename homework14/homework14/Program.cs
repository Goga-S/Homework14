
using task1;
using task1.Abstractions;
using task1.Creator;

IFactory artdeco = new ArtDecoFactory();
Application app = new Application(artdeco);

app.print();