# ecore-csharp

CrossEcore is a framework for model-based software engineering targeting multiple platforms.
From a platform-independent class model (i.e. an Ecore model), source code for multiple platforms like C#, TypeScript, JavaScript and Swift is generated.
Derived attributes, constraints for model validation and operation bodies can be expressed in the [Object Constraint Language (OCL)](http://www.omg.org/spec/OCL/About-OCL/).
CrossEcore comes with a runtime library for every target platform that implements the Ecore and OCL API.
The Ecore API provides many of the features that are known from the [Eclipse Modeling Framework](https://www.eclipse.org/modeling/emf/), e.g., persistence, reflection, notifications, switches, factories, referential integrity and validation.
With the aid of an OCL Compiler, OCL expressions are translated to equivalent expressions of the target programming language.
CrossEcore’s APIs can be used across platforms almost consistently.

This package implements the Ecore and OCL API in C#.
You need this package (1) when you have generated C# code from your own custom Ecore model as it depends on this package or (2) when you want to create Ecore models programmatically.

Java developers that are familiar with the Eclipse Modeling Framework will note that this package corresponds to the original Java package org.eclipse.emf.ecore.

## Features
### Persistence
```csharp
//Load a model from XMI file:
var epackage = new XmiResource().Load("./Ecore.ecore") as EPackage;
```
### Factory
```csharp
//Create EClass instance by using the factory:
var eclass = EcoreFactoryImpl.eINSTANCE.createEClass();
```

### Reflection
```csharp
//Get the supertypes of an EClass
var supertypes = eclass.eSuperTypes;
```

### Notifications
```csharp
public class MyAdapter : AdapterImpl
{
  public override void notifyChanged(Notification msg)
  {
    //do something
  }
}
eclass.eAdapters().Add(new MyAdapter());
```
## Publications
S. Schwichtenberg, I. Jovanovikj, C. Gerth, and G. Engels, "Poster: CrossEcore: An Extendible Framework to Use Ecore and OCL across Platforms," in Proceedings of the 40th International Conference on Software Engineering, ICSE 2018 - Companion Volume, Gothenburg, Sweden.
