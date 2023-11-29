using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class FunctionCache
    {
    }
}
class FunctionCache
{
    constructor()
    {
        this.cache = new Map();
    }

    execute(func, key)
    {
        if (!this.cache.has(key))
        {
            const result = func(key);
            this.cache.set(key, result);
        }
        return this.cache.get(key);
    }
}
