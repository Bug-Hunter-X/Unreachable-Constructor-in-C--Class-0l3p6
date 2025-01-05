public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // This constructor is never used, leading to potential confusion and dead code.
    }
}