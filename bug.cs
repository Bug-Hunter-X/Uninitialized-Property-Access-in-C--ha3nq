public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's assigned can lead to unpredictable behavior.
        int value = MyProperty; // Bug: Potential uninitialized property access
        Console.WriteLine(value); 
    }
}