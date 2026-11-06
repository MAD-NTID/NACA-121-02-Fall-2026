using System.Text;

public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    public int Count { get; private set; }

    public int Capacity { get; private set; }

    private const int DEFAULT_CAPACITY = 5;

    private const double LOAD_FACTOR = .7; // 70%

    private IKVP<TKey, TValue>?[] items;

    public Dictionary(int capacity = DEFAULT_CAPACITY)
    {
        Capacity = capacity;

        items = new IKVP<TKey, TValue>[capacity];
    }


    public void Add(TKey key, TValue value)
    {
        EnsureCapacity();

        int index = GetIndex(key);

        if(ContainsKey(key))
            throw new ArgumentException($"'{key}' is duplicate");

        // Create the KVP object
        IKVP<TKey, TValue> kvp = new KVP<TKey, TValue>(key, value);

        // Insert into calculated hashed index
        items[index] = kvp;
        
        Count++;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(TKey key)
    {
        int index = LinearProbing(key);

        return items[index] is not null;
    }

    public bool ContainsValue(TValue value)
    {
        foreach(IKVP<TKey, TValue> kvp in items)
        {
            if(kvp is not null && EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
                return true; 
        }

        return false;
    }

    public IKVP<TKey, TValue> Get(TKey key)
    {
        if(!ContainsKey(key))
            throw new ArgumentException($"Key - '{key}' does not exist");

        int index = LinearProbing(key);

        return items[index];
    }

    public int GetIndex(TKey? key)
    {
        if(key is null)
            throw new ArgumentException($"Key is null");

        // Uncomment to see what the hashcode looks like
        //Console.WriteLine($"The hascode for {key} is {key.GetHashCode()}");
    
        return Math.Abs(key.GetHashCode() % Capacity);
    }

    private void EnsureCapacity()
    {
        double loadFactor = Count / Capacity;

        if(loadFactor >= LOAD_FACTOR)
        {
            // Multiply the current capacity by 2
            Capacity *= 2;

            // Temporary reconstruction of the new items hashtable
            IKVP<TKey, TValue>?[] hashtable = new IKVP<TKey, TValue>[Capacity];

            // Make a copy of the old items
            IKVP<TKey, TValue>?[] oldItems = items;

            // Make hashtable the new array
            items = hashtable;

            // Rehash New Elements (Remember that Capacity grew, so GetIndex now returns a different hash for each of the key)
            foreach(IKVP<TKey, TValue>? kvp in oldItems)
            {
                if(kvp is not null)
                {
                    int index = LinearProbing(kvp.Key);

                    items[index] = kvp;
                }
            }
        }
    }

    public bool Remove(TKey key)
    {
        if(!ContainsKey(key))
            return false;

        int index = LinearProbing(key);

        items[index] = null;

        Count--;

        return true;
    }

    private int LinearProbing(TKey key, bool searchExistingKey = false)
    {
        // Get the index locatin of the collided key
        int collidedIndex = GetIndex(key);

        // We need a separate index for probing
        // Use the collided index
        int probingIndex = collidedIndex;

        // Begin Probing
        do
        {
            // Get the KVP at the current index
            IKVP<TKey, TValue>? kvp = items[probingIndex];

            // If search matches existing key, simply return that index
            // This supports if 'updating' the kvp
            if( searchExistingKey && 
                kvp is not null && 
                EqualityComparer<TKey>.Default.Equals(kvp.Key, key))
                return probingIndex;

            // if kvp is null, then this is an open spot
            else if(!searchExistingKey && kvp is null)
            {
                return probingIndex;
            }

            // this is where probing actually happens
            probingIndex = (probingIndex + 1) % Capacity;
        } while(probingIndex != collidedIndex);

        return -1;
    }

    public override string ToString()
    {
        StringBuilder sb = new("Items\n");

        foreach(IKVP<TKey, TValue>? kvp in items)
        {
            if(kvp is not null)
                sb.AppendLine(kvp.ToString());
        }

        return sb.ToString();
    }
}