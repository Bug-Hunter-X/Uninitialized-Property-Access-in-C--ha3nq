# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  Uninitialized properties may have default values (0 for ints, null for references etc.), but relying on this can lead to subtle bugs and unpredictable behavior.

The `bug.cs` file shows the problematic code.  `bugSolution.cs` provides a corrected version that prevents the error. 

This example is a simple illustration of the problem; similar issues can occur in much more complex scenarios making them harder to detect and debug.   Always ensure your properties are initialized before access.