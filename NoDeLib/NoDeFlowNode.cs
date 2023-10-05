namespace NoDeLib
{
    public class NoDeFlowNode : NoDeNode
    {
        public bool CanHaveParent = false;
        public bool CanHaveChild = false;

        public NoDeFlowNode Parent;
        public NoDeFlowNode Child;

        public NoDeFlowNode()
        {
        }

        public virtual void Execute()
        {

        }

        public bool HasNext()
        {
            if (!CanHaveChild)
            {
                return false;
            }
            return Child != null;
        }

        public bool HasPreviouse()
        {
            if (!CanHaveParent)
            {
                return false;
            }
            return Parent != null;
        }

        public NoDeFlowNode Next()
        {
            return Child;
        }

        public NoDeFlowNode Previouse()
        {
            return Parent;
        }

        public void SetChild(NoDeFlowNode child)
        {
            Child = child;
        }

        public void SetParent(NoDeFlowNode parent)
        {
            Parent = parent;
        }

        public static void Connect(NoDeFlowNode parent, NoDeFlowNode child)
        {
            if (parent == null)
            {
                throw new ArgumentNullException("parent was null");
            }
            if (child == null)
            {
                throw new ArgumentNullException("child was null");
            }
            if (!parent.CanHaveChild)
            {
                throw new InvalidOperationException("parent can not have a child");
            }
            if (!child.CanHaveParent)
            {
                throw new InvalidOperationException("child can not have a parnet");
            }
            child.SetParent(parent);
            parent.SetChild(child);
        }
    }
}
