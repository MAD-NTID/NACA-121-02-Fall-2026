public interface IDictionary <TKey, TValue>
{
    // Returns the number of KVP of non-null elements in the dictionary
    public int Count { get; }

    // Stores the capacity of the dictionary
    public int Capacity { get; }

    public void Clear();

    public bool ContainsKey(TKey key);

    public bool ContainsValue(TValue value);

    public void Add(TKey key, TValue value);

    public bool Remove(TKey key);

    // Returns the index of the Dictionary array of a matching key
    public int GetIndex(TKey key);

    // Returns the KVP object of itself by its key
    public IKVP<TKey, TValue> Get(TKey key);
}