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

Console.Write($"{entrada1.Output} -->\n            {portaE.Output} --->\n{entrada2.Output} -->               {portaOu.Output} --> {portaNao.Output}\n{entrada3.Output} -------------->\n\n" );

Sum soma = new Sum();

soma.Input = false; // Bit menos significativo --> 0
soma.Input2 = true; // Bit mais significativo --> 2

soma.Input3 = false; // Bit menos significativo --> 0
soma.Input4 = true; // Bit mais significativo --> 2

soma.printOutput();