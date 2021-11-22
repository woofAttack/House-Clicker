using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class ListParts<T> : IEnumerable<T> where T : Part
{
    private List<T> _parts;

    public UnityEvent OnAdd;

    public ListParts(List<T> parts)
    {
        _parts = parts;
    }

    public void Add(T part)
    {
        _parts.Add(part);
        OnAdd?.Invoke();
    }
    public List<T> GetListParts() => _parts;
    public int Count() => _parts.Count;

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_parts).GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_parts).GetEnumerator();
    }
}


