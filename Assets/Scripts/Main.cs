using System.Collections;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private UITileListPartsChooseBlock _UITileListPartsChooseBlock;
    [SerializeField] private ListPrefabsBlock _listPrefabsBlock;


    public void Awake()
    {
        InitializerParts<Block> initializerBlock = new NewDataInitializerBlock(_listPrefabsBlock);
        initializerBlock.Action();

        ListParts<Block> listBlock = initializerBlock.Result();

        _UITileListPartsChooseBlock.Init(listBlock);

    }


}
