namespace learn.cs;
using System;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class Parent
{
    public  const string Name = "parent";
    public string NonVirtual() { return Name; }
    public virtual string Virtual() { return Name; }
}

public class Child : Parent
{
    public  const string Name = "child";
    public override string NonVirtual() { return Name; }
    public override string Virtual() { return Name; }
}

[TestClass]
public class Program
{
    [TestMethod]
    public void Main()
    {
        Child child = new Child();
        Parent parent = new Child();
        

        Assert.AreEqual(Child.Name, child.NonVirtual(), false);
        Assert.AreEqual(Parent.Name, parent.NonVirtual(), false);
        Assert.AreEqual(Parent.Name, ((Parent)child).NonVirtual(), false);

        Assert.AreEqual(Child.Name, child.Virtual(), false);
        Assert.AreEqual(Parent.Name, parent.Virtual(), false);
        Assert.AreEqual(Parent.Name, ((Parent)child).Virtual(), false);
    }
}