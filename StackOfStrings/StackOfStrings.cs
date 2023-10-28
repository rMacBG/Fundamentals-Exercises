namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool isEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }
        public void AddRange(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
    }
}
