# Direct Access of Private Field in C#
This example showcases a common C# coding error: directly accessing a private field instead of using its corresponding public property. This violates encapsulation principles and can introduce subtle bugs.

## The Problem
The `MyClass` class defines a private field `_myField` and a public property `MyProperty` to access it.  However, the `MyMethod` function directly modifies `_myField`, bypassing the property.  This can cause unexpected behavior if the property contains validation logic, logging, or any other side effects.

## The Solution
The improved code utilizes the `MyProperty` to modify the field, ensuring that any logic within the property's setter is executed.