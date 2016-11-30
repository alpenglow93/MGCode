using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//상태패턴 : 객체의 상태 자체를 바꾸는 패턴
class Program
{
    static void Main(string[] args)
    {
        //객체에 A 클래스 데이터를 대입
        Context c = new Context(new ConcreteStateA());

        c.Request();
        c.Request();
        c.Request();
        c.Request();
    }
}

//추상클래스
abstract class State
{
    public abstract void Handle(Context _context);
}

//추상클래스를 상속받는 클래스A
class ConcreteStateA : State
{
    public override void Handle(Context _context)
    {
        //B 클래스의 데이터 대입
        _context.State = new ConcreteStateB();
    }
}

//추상클래스를 상속받는 클래스B
class ConcreteStateB : State
{
    public override void Handle(Context _context)
    {
        //A 클래스의 데이터 대입
        _context.State = new ConcreteStateA();
    }
}

class Context
{
    //State 클래스 변수
    private State state;

    public Context(State _state)
    {
        state = _state;
    }

    public State State
    {
        get { return state; }
        set
        {
            state = value;
            //어느 데이터를 담은 객체인지 알려줄 코드
            Console.WriteLine("State: " + state.GetType().Name);
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}