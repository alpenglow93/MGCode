using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//전략패턴 : 동일 계열의 알고리즘군을 정의하고, 각 알고리즘을 캡슐화하는 패턴
class Program
{
    static void Main(string[] args)
    {
        Context context;

        context = new Context(new ConcreteStrategyA());
        context.ContextInterface();

        context = new Context(new ConcreteStrategyB());
        context.ContextInterface();

        context = new Context(new ConcreteStrategyC());
        context.ContextInterface();

        //Console.ReadKey();
    }
}

//추상클래스
abstract class Strategy
{
    public abstract void AlgorithmInterface();
}

//추상클래스를 상속받는 클래스 A
class ConcreteStrategyA : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("Call ConcreteStrategyA.AlgorithmInterface()");
    }
}

//추상클래스를 상속받는 클래스 B
class ConcreteStrategyB : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("Call ConcreteStrategyB.AlgorithmInterface()");
    }
}

//추상클래스를 상속받는 클래스 C
class ConcreteStrategyC : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("Call ConcreteStrategyC.AlgorithmInterface()");
    }
}
//각각 해당 클래스의 메서드를 호출했다는 메시지를 출력하는 코드가 들어있음

//Context 클래스
class Context
{
    private Strategy strategy;

    public Context(Strategy _strategy)
    {
        strategy = _strategy;
    }

    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}