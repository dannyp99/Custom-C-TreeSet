using System.Collections.Generic;

public class TreeSet<T>
{
    public ISet<T> set { get; }

    public TreeSet(ISet<T> set)
    {
        this.set = set;
    }
    
    
    
}