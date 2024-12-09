public class MyClass {
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { 
            //Example of Validation
            if (value < 0) {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }
            _myField = value; 
        }
    }

    public void MyMethod() {
        // Accessing _myField through the property
        MyProperty = 10; 
    }
}