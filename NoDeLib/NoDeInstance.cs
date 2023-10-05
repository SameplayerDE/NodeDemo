using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeLib
{
    public class NoDeInstance
    {

        public List<NoDeNode> Nodes = new();

        public void Add(NoDeNode node)
        {
            Nodes.Add(node);
        }

        public void Remove(NoDeNode node)
        {
            Nodes.Remove(node);
        }

    }
}
