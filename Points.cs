public abstract class Point
{
    private bool input;
    public bool Input
    {
        get { return input; }
        set { input = value; }
    }

    public abstract bool Output { get; set; }
    
}


public class NotGate : Point
{
    public override bool Output
    { 
        get
        {
            return !this.Input;
        }
        set 
        {
            
        }
    }

}


public class NormalGate : Point
{
    public override bool Output
    {
        get
        {
            return this.Input;
        }

        set
        {
            
        }
    }
}