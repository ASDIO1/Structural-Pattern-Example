# Structural-Pattern-Example
Simple example of structural patterns for studying purposes.
For this example I chose to use the **Bridge** structural pattern

## Table of contents

- [Problem](#problem)
- [Program usage guide](#program-usage-guide)
- [Documentation](#documentation)
- [Aclarations](#aclarations)

## Thematic

The thematic that I proposed for this project is about a shipping company based in Bolivian shipping companies.

This shipping company needs to be able to send packages from a client sending the package (sender) to another client who receives the package (receiver).

Thi shipping can be done by plane, bus or train and the packages are clasified in common packages and fragile packages.

So resuming this thematic, each type of package needs the sender and receiver client information and the package can be shipped by plane, bus or train.

## Solution

I decided to implement this a program for the thematic mentiones using the **Bridge** structural pattern.

The packages can be common or fragile and any package has different ways of being sent (plane, bus or train). This fits perfectly into the Bridge pattern.

The example where I use the Bridge pattern is coded in the main program (program.cs)

I wont be explaining the details of the program here, because in this repository are included a class diagram for the project and a sequence diagram of the main program (program.cs) which are very self explanatory.


## Program usage guide

Run this program with a C# compiler.
The way I run this program is by excecuting the solution (.sln) file with visual studio 2019.

The main program (program.cs) consist of:

-  Creating instances of each shipping medium (plane, bus, train)
-  Creating the 2 diferent types of clients (sender and receiver)
-  Creting instances of each type of package
-  For each kind of package I run the "Send()" method which will be excecuted differently for each package and each shipping medium following the **Bridge** structural pattern

This process is in the main program (program.cs).


## Documentation

This repository includes images of a Classes diagram and a Sequence diagram of the main program.

## Aclarations

-  As the main program is very simple and consists of creating instances and running the "Send()" method, the sequence diagram is very simple and a bit weird but I think it represents the main program pretty well.
