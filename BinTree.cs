namespace TreeSet
{
    public class BinTree<T>
    {
        private T Left { get; set; }

        private T Right { get; set; }
        
        public BinTree()
        {
            Left = default;
            Right = default;
        }
        
        public BinTree(T Left, T Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
    }
}