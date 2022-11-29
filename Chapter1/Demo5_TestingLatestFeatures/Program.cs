public interface ISample
{
    //static abstract int SomeFlag1; // ERROR CS0681
    // CA 2211: Non-constant fields should not be visible
    static int SomeFlag2 = 1; // OK, but warning message (CA 2211)
    //int _someFlag3; // ERROR CS0525

    const int SomeFlag3 = 3; // OK
    static abstract void ShowInterfaceName1(); // OK in C# 11
    void ShowInterfaceName2(); // OK
}
