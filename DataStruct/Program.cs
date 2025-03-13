using DataStruct.DataStructClasses;

namespace DataStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack
            StaticStack s = new StaticStack(4);
            s.push(67);
            s.push(55);
            s.push(77);
            s.push(09);
            s.pop();
            s.pop();
            s.showStack();
        }
    }
}