// Console.WriteLine("---Chapter2.Various types of comments in C#.---");

Console.WriteLine("***Different type of comments in C#***");

// Testing whether 2 is greater than 1
Console.WriteLine(2 > 1);

/*
Now I use multi-line comments.
It spans multiple lines.
Here I multiply 2 with 3.
*/
Console.WriteLine(2 * 3);

Sample myClass = new();

AnotherSample myAnotherClass = new();

/// <summary>
/// <para>This is a custom class.</para>
/// <br>There is no method inside it.</br>
/// </summary>
class Sample
{

}

/** 
 * <summary>
 * <para>This is another custom class.</para>
 * <br>It is also empty now.</br>
 * </summary>
 */
class AnotherSample
{

}


