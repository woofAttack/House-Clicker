using System.Collections.Generic;

public class NewDataInitializerParts<T> : InitializerParts<T> where T : Part
{
    private List<T> _parts = new List<T>();

    private protected override void CreateArrayParts()
    {
        
    }

    private protected override List<T> ArrayParts() => _parts;
}
