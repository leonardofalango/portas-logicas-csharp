Point entrada1 = new NormalGate();
Point entrada2 = new NormalGate();
Point entrada3 = new NormalGate();


entrada1.Input = true;
entrada2.Input = true;
entrada3.Input = false;


AndGate portaE = new AndGate();
OrGate portaOu = new OrGate();
NotGate portaNao = new NotGate();


portaE.Input = entrada1.Output;
portaE.Input2 = entrada2.Output;

portaOu.Input = entrada3.Output;
portaOu.Input2 = portaE.Output;

portaNao.Input = portaOu.Output;

portaNao.Input = portaNao.Output;

Console.Write($"{entrada1.Output} -->\n            {portaE.Output} --->\n{entrada2.Output} -->               {portaOu.Output} ----> {portaNao.Output}\n{entrada3.Output}  -------------->\n\n" );

Sum soma = new Sum();

soma.Input = true; // Bit menos significativo --> 0
soma.Input2 = true; // Bit mais significativo --> 2

soma.Input3 = true; // Bit menos significativo --> 0
soma.Input4 = false; // Bit mais significativo --> 2

soma.printOutput();


Sum calc = new Sum();
bool[] inputs = new bool[2] {false, true};

for (int bitMenos1 = 0; bitMenos1 < 2; bitMenos1++)
{
    for (int bitMais1 = 0; bitMais1 < 2; bitMais1++)
    {
        for (int bitMenos2 = 0; bitMenos2 < 2; bitMenos2++)
        {
            for (int bitMais2 = 0; bitMais2 < 2; bitMais2++)
            {
                calc.Input = inputs[bitMenos1];
                calc.Input2 = inputs[bitMais1];
                calc.Input3 = inputs[bitMenos2];
                calc.Input4 = inputs[bitMais2];

                Console.WriteLine($"{inputs[bitMais1]}{inputs[bitMenos1]} + {inputs[bitMais2]}{inputs[bitMenos2]}");

                calc.printOutput();
                Console.WriteLine("");
            }
        }
    }
}