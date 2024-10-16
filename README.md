# Singleton Design Pattern in C#
This program demonstrates two common approaches to implementing the Singleton Design Pattern in C#.

There are two implementations of the Singleton class in this program:

1) DoubleCheckSingleton
2) LazySingleton

## DoubleCheckSingleton
This implementation uses a lock object to prevent multiple threads from initializing the Singleton class instance. It is called the "double-check locking" technique because it only locks the critical section of code if the instance is null, avoiding unnecessary locking.

## LazySingleton
This implementation uses the Lazy<T> object of type Singleton Class. It provides thread safety, and in this approach, the instance is initialized only when it is accessed through the Value property.
