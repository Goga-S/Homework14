
using task4;
using task4.ConcreteStrategies;

FileHandlingStrategy strategy = new ZipFileStrategy();
Context cont = new Context(strategy);
cont.ContextInterface();