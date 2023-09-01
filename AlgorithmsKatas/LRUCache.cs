namespace AlgorithmsKatas
//https://leetcode.com/problems/lru-cache
{
    public class LRUCache
    {
        private readonly int capacity;
        private readonly Dictionary<int, int> cache;
        private readonly Stack<int> recentKeys;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.cache = new Dictionary<int, int>(capacity);
            this.recentKeys = new Stack<int>(capacity);
        }

        public int Get(int key)
        {
            if (cache.TryGetValue(key, out int value))
            {
                // Move the key to the top of the stack as it's the most recently used.
                UpdateKeyUsage(key);
                return value;
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (cache.Count >= capacity)
            {
                // Evict the least recently used key.
                int lruKey = recentKeys.Pop();
                cache.Remove(lruKey);
            }

            // Add the new key-value pair to the cache and stack.
            cache[key] = value;
            recentKeys.Push(key);
        }

        private void UpdateKeyUsage(int key)
        {
            List<int> tempKeys = new List<int>();

            while (recentKeys.Count > 0)
            {
                int currentKey = recentKeys.Pop();
                if (currentKey == key)
                {
                    continue; // Skip the current key, we'll push it back later.
                }
                tempKeys.Add(currentKey);
            }

            // Push the key back to the stack.
            recentKeys.Push(key);

            // Restore the original order.
            for (int i = tempKeys.Count - 1; i >= 0; i--)
            {
                recentKeys.Push(tempKeys[i]);
            }
        }
    }
}