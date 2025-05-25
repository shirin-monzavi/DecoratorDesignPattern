# 🎯 Decorator Pattern with C#

This project demonstrates the Decorator Pattern applied in C#. The pattern allows you to add functionality to an object dynamically, without changing its structure.
In this example, we have a base VisualComponent class, and we use decorators like BorderDecorator and ScrollDecorator to add extra behaviors (drawing borders, adding scrollbars) to a base component (TextView).

## 📌 What is the Composite Pattern?

The Composite Pattern is a structural design pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions uniformly.


## 🧩 Classes

### `MenuComponent` (Abstract)

- Defines a common interface for all menu elements.
- Methods: `Add()`, `Remove()`, `Display()`.

### `MenuItem` (Leaf)

- Represents a single item.
- Overrides `Display()` to print its name.

### `Menu` (Composite)

- Represents a collection of `MenuComponent` items.
- Overrides `Add()`, `Remove()`, and `Display()`.

---

### 🛠️ Technologies Used
 
C#



Decorator Pattern with C#
This project demonstrates the Decorator Pattern applied in C#. The pattern allows you to add functionality to an object dynamically, without changing its structure.

In this example, we have a base VisualComponent class, and we use decorators like BorderDecorator and ScrollDecorator to add extra behaviors (drawing borders, adding scrollbars) to a base component (TextView).

Structure
Classes:
VisualComponent

The base class for all graphical components that can be drawn and resized.

Contains Draw() and Resize() methods that can be overridden in subclasses.

Decorator

A base class for all decorators, which extends VisualComponent.

Holds a reference to another VisualComponent (the component being decorated) and delegates calls to it.

BorderDecorator

A decorator that adds border-drawing functionality to a VisualComponent.

Accepts a border width parameter.

ScrollDecorator

A decorator that adds scroll-bar functionality to a VisualComponent.

TextView

A concrete implementation of VisualComponent.

Represents a simple text view that can be drawn and resized.

Window

Holds a VisualComponent and allows setting the contents, which can be decorated dynamically.

Calls Draw() on the current contents to render them.

Decorator Usage
The decorators (BorderDecorator and ScrollDecorator) are used to enhance a TextView component without altering its core functionality. Decorators are applied in layers:

You can add scroll bars using ScrollDecorator.

You can add borders using BorderDecorator.

The Window class is used to manage and display the VisualComponent.
