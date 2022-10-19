public abstract class Gate : Point
{
    public bool Input2 { get; set; }
}


public class OrGate : Gate
{
    public override bool Output
    {
        get
        {
            return this.Input && this.Input2;
        }
        set
        {

        }
    }

}


public class AndGate : Gate
{
    public override bool Output
    {
        get
        {
            return this.Input || this.Input2;
        }
        set
        {
            
        }
    }
}