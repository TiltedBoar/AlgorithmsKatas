using AlgorithmsKatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class LRUCacheTests
    {
        private readonly LRUCache _sut;

        public LRUCacheTests()
        {
           
            _sut = new LRUCache(2);
        }

        [Fact]
        public void LRUCache_ShouldGetAndPutValuesCorrectly()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);

            // Assert
            Assert.Equal(1, _sut.Get(1)); // Get should return 1
            _sut.Put(3, 3); // Adding a new item, which should evict key 2
            Assert.Equal(-1, _sut.Get(2)); // Get should return -1 for key 2
            Assert.Equal(3, _sut.Get(3)); // Get should return 3
        }

        [Fact]
        public void LRUCache_ShouldEvictLRUKey()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);

            // Assert
            _sut.Get(1); // Access key 1, making key 2 the least recently used
            _sut.Put(3, 3); // Adding a new item, which should evict key 2
            Assert.Equal(-1, _sut.Get(2)); // Get should return -1 for key 2
        }

        [Fact]
        public void LRUCache_ShouldUpdateKeyUsageOnGet()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);
            _sut.Put(3, 3);

            // Assert
            _sut.Get(1); // Access key 1, making keys 3 and 2 the least recently used
            _sut.Put(4, 4); // Adding a new item, which should evict key 2
            Assert.Equal(-1, _sut.Get(2)); // Get should return -1 for key 2
        }

        [Fact]
        public void LRUCache_ShouldHandleCapacity1Correctly()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);

            // Assert
            _sut.Put(3, 3); // Adding a new item, which should evict key 1
            Assert.Equal(-1, _sut.Get(1)); // Get should return -1 for key 1
            Assert.Equal(2, _sut.Get(2)); // Get should return 2
            Assert.Equal(3, _sut.Get(3)); // Get should return 3
        }
        [Fact]
        public void LRUCache_ShouldUpdateExistingKey()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);
            _sut.Put(1, 10); // Update the value of key 1

            // Assert
            Assert.Equal(10, _sut.Get(1)); // Get should return the updated value
        }

        [Fact]
        public void LRUCache_ShouldHandleEmptyCache()
        {
            // Assert
            Assert.Equal(-1, _sut.Get(1)); // Get from an empty cache should return -1
        }
        [Fact]
        public void LRUCache_ShouldHandleMultiplePutsAndGets()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);

            // Assert
            Assert.Equal(1, _sut.Get(1)); // Get should return 1
            _sut.Put(3, 3); // Adding a new item, which should evict key 2
            Assert.Equal(2, _sut.Get(2)); // Get should return 2 (to test if it handles updating the LRU order)
            Assert.Equal(3, _sut.Get(3)); // Get should return 3
            _sut.Put(4, 4); // Adding another new item, which should evict key 1
            Assert.Equal(-1, _sut.Get(1)); // Get should return -1 for key 1
            Assert.Equal(2, _sut.Get(2)); // Get should return 2
            Assert.Equal(3, _sut.Get(3)); // Get should return 3
            Assert.Equal(4, _sut.Get(4)); // Get should return 4
        }

        [Fact]
        public void LRUCache_ShouldHandleLargeCapacity()
        {
            // Act
            var largeCapacityCache = new LRUCache(1000);

            // Assert
            for (int i = 0; i < 1000; i++)
            {
                largeCapacityCache.Put(i, i * 2);
            }

            Assert.Equal(1998, largeCapacityCache.Get(999)); // Get should return 1998
            Assert.Equal(0, largeCapacityCache.Get(1000));   // Get should return 0 (key not found)
        }

        [Fact]
        public void LRUCache_ShouldEvictCorrectlyWithMixedActions()
        {
            // Act
            _sut.Put(1, 1);
            _sut.Put(2, 2);
            _sut.Get(1); // Access key 1, making key 2 the least recently used
            _sut.Put(3, 3); // Adding a new item, which should evict key 2
            _sut.Put(4, 4); // Adding another new item, which should evict key 1

            // Assert
            Assert.Equal(-1, _sut.Get(1)); // Get should return -1 for key 1
            Assert.Equal(2, _sut.Get(2)); // Get should return 2
            Assert.Equal(3, _sut.Get(3)); // Get should return 3
            Assert.Equal(4, _sut.Get(4)); // Get should return 4
        }
    }
}
