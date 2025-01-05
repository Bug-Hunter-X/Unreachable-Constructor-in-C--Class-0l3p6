public class MyClass {
    public int MyProperty { get; set; }

    public MyClass(int value) {  // Parameterized constructor
        MyProperty = value; 
    }
    public MyClass() : this(0) { // Calls the Parameterized constructor
        //This method initializes the value with 0. 
    }
} 