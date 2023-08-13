namespace ActionAndDeploy
{
    public interface IStack<T>
    {
        void Push(T Pusheditem);
        void Pop();
    }

}
