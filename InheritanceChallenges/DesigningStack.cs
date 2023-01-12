
namespace CSharpIntermediateChallenges.InheritanceChallenges
{
    public class DesigningStack
    {
        public static void RunApplication()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    class Stack
    {
        List<object> objects = new List<object>();

        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException("Cannot push null value.");

            objects.Add(obj);
        }

        public object Pop()
        {
            if (objects.Count == 0) throw new InvalidOperationException("The Stack is empty. You cannot pop an object from the stack.");

            object obj = objects.Last();
            objects.Remove(objects.Last());

            return obj;
        }

        public void Clear()
        {
            objects.Clear();
        }
    }
}