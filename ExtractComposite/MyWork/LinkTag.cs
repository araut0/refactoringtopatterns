using System.Collections.Generic;

namespace ExtractComposite.MyWork
{
    public class LinkTag: Tag
    {
        private readonly List<Node> _nodeList = new List<Node>();

        public LinkTag(): base("<a href=_>","</a>")
        {
            
        }
        
        public override string ToPlainTextString()
        {
            
            var buffer = string.Empty;
            LinkData().ForEach(node => buffer += node.ToPlainTextString());
            return buffer;
        }

        public void AddChild(Node child)
        {
            _nodeList.Add(child);
        }

        private List<Node> LinkData()
        {
            return _nodeList;
        }
    }
}