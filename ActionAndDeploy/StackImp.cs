using System.Collections.Generic;

namespace ActionAndDeploy
{
    public class StackImp<T> : IStack<T>
    {
        public List<T> StackStorage = new List<T>();

        public void Pop()
        {
            StackStorage.RemoveAt(StackStorage.Count - 1);
        }

        public void Push(T Pusheditem)
        {
            StackStorage.Add(Pusheditem);
        }
    }


}
