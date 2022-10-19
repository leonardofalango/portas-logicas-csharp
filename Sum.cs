public class Sum : Gate
{
    
    private bool input3;
    public bool Input3
    {
        get { return input3; }
        set { input3 = value; }
    }

    private bool input4;
    public bool Input4
    {
        get { return input4; }
        set { input4 = value; }
    }

    public override bool Output
    {
        get
        {
            AndGate portaE = new AndGate();
            portaE.Input = this.Input2;
            portaE.Input2 = this.Input4;
            return portaE.Output;
        } 
        set
        {

        }
    }

    public bool Output2
    {
        get
        {
            AndGate portaE = new AndGate();
            portaE.Input = this.Input;
            portaE.Input2 = this.input3;
            return portaE.Output;
        }
        set
        {

        }
    }


    public bool Output3
    {
        get
        {
            XorGate xor = new XorGate();
            xor.Input = this.Input;
            xor.Input2 = this.Input3;
            return xor.Output;
        }
        set
        {

        }
    }

    public void printOutput()
    {
        Console.WriteLine($"{this.Output} {this.Output2} {this.Output3}");
    }
    
}