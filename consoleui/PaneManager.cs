namespace Console.UI;

public class Length {
    public int Chars { get; set;}
    //     get { return Value; }
    //     set {
    //         Percent = null;
    //         Value = value;
    //     } 
    // }
    // public int? Percent { 
    //     get { return base.Value; }
    //     set {
    //         Chars = null;
    //         base.Value = value;
    //     } 
    // }

}
public class Pane {
    public String Title { get; set; }
}
public class PaneNode {
    public Pane Pane { get; set; }
}
public class PaneManager
{


    public void Run()
    {
        Utils.ClearScreen();
    }
}