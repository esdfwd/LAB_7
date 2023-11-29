using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2
{
    internal class Repository
    {
    }
}
class Repository
{
    constructor()
    {
        this.elements = [];
    }

    add(element)
    {
        this.elements.push(element);
    }

    find(criteria)
    {
        return this.elements.filter(criteria);
    }
}