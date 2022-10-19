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
Console.WriteLine(portaE.Output);

portaOu.Input = entrada3.Output;
portaOu.Input2 = portaE.Output;
Console.WriteLine(portaOu.Output);


portaNao.Input = portaOu.Output;
Console.WriteLine(portaNao.Output);

portaNao.Input = portaNao.Output;
Console.WriteLine(portaNao.Output);

