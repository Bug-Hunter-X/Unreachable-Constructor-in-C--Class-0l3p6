# Unreachable Constructor in C# Class

This repository demonstrates a common but easily overlooked error in C#: an unreachable constructor.  The `MyClass` constructor is defined but is never actually called because there are no other methods that explicitly utilize the constructor. This can lead to unnecessary code clutter and potential maintainability issues.

The solution illustrates how to properly initialize the class and address this issue.