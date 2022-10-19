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
            return this.Input || this.Input2;
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
            return this.Input && this.Input2;
        }
        set
        {
            
        }
    }
}


public class XorGate : Gate
{
    public override bool Output
    {
        get
        {
            AndGate e = new AndGate();
            e.Input = this.Input;
            e.Input2 = this.Input2;
            
            OrGate ou = new OrGate();
            ou.Input = this.Input;
            ou.Input2 = this.Input2;

            if (e.Output)
            {
                return false;
            }
            else if (ou.Output)
            {
                return true;
            }
            return false;
        }
        set
        {
            
        }
    }
}