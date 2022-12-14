using CalcInterfaces;
using CalcClient;

ChannelFactory<ICalcService> channel = new ChannelFactory<ICalcService>("CalcServiceEndpoint");

ICalcService proxy = channel.CreateChannel();
float resSum = proxy.Sum(5, 4);
Console.WriteLine($"Sum is {resSum}");
float resDiff = proxy.Diff(5, 4);
Console.WriteLine($"Diff is {resDiff}");
float resMult = proxy.Mult(5, 4);
Console.WriteLine($"Mult is {resMult}");
float resDiv = proxy.Div(5, 4);
Console.WriteLine($"Div is {resDiv}");
float resMod = proxy.Mod(5, 4);
Console.WriteLine($"Mod is {resMod}");

Console.ReadLine();