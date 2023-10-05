var instance    = new NoDeLib.NoDeInstance();

var start       = new NoDeLib.NoDeFlowNode();
var node0       = new NoDeLib.NoDeFlowNode();
var node1       = new NoDeLib.NoDeFlowNode();
var node2       = new NoDeLib.NoDeFlowNode();
var end         = new NoDeLib.NoDeFlowNode();

NoDeLib.NoDeFlowNode.Connect(start, node0);
NoDeLib.NoDeFlowNode.Connect(node0, node1);
NoDeLib.NoDeFlowNode.Connect(node1, node2);
NoDeLib.NoDeFlowNode.Connect(node2, end);

instance.Add(start);
instance.Add(node0);
instance.Add(node1);
instance.Add(node2);
instance.Add(end);

var node = start;

do
{
    node.Execute();
    node = node.Next();
} while (node.HasNext() && node != null);