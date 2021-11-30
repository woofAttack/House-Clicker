using System.Collections;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    [SerializeField] private GameObject _UITileListChooseBlock;
    [SerializeField] private GameObject _prefabTilePart;
    [SerializeField] private ListPrefabsBlock _listPrefabsBlock;


    public void Awake()
    {
        InitializerParts<Block> initializerBlock = new NewDataInitializerBlock(_listPrefabsBlock);
        ListParts<Block> listBlock = initializerBlock.Result();

        _UITileListChooseBlock.AddComponent<UITileListPartsChoose<Block>>().Init(listBlock, _prefabTilePart);     

    }


}
