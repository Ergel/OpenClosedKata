using System;
using System.Collections.Generic;

namespace PersonLibrary
{
    public interface IPersonenFilter
    {
        List<Predicate<Person>> GetList();
    }
}