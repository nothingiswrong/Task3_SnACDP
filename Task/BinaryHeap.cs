
namespace Task;

public class BinaryHeap<K, V> where K: IComparable
{
   private class HeapElement<K,V> where K: IComparable
   {
      public K Key { get; }
      public V Value { get; }

      public HeapElement(K key, V value)
      {
         Key = key;
         Value = value;
      }

   }
   
   public int Size { get => Elements.Count; }
   
   private List<HeapElement<K,V>> Elements;

   public BinaryHeap(int size)
   {
      Elements = new(size);
   }
        
   public BinaryHeap(){}

   public void Insert(K key, V value)
   {
      Elements.Add(new (key, value));
      var i = Elements.Count - 1;
      while (i > 0)
      {
         var node = Elements[i];
         var parent = Elements[(i - 1) / 2];
         
         if (node.Key.CompareTo(parent.Key) < 0)
         {
             (node, parent) = (parent, node);
         }

         i /= 2;
      }
   }

   public void Remove()
   {
      throw new NotImplementedException();
   }
  
}