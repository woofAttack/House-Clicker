using System.Collections.Generic;

public abstract class InitializerParts<T> where T : Part
{
    private ListParts<T> _listParts;

    public void Action() 
    {
        CreateArrayParts();
        _listParts = new ListParts<T>(ArrayParts());
    }
    public ListParts<T> Result() => _listParts;

    private protected abstract void CreateArrayParts();
    private protected abstract List<T> ArrayParts();
}
