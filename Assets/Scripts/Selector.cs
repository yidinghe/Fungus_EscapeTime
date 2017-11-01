using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class Selector : MonoBehaviour
    {
    public string 註解 = "註解";
    
    public List<GameObject> 清單;

    public static void 選擇場景內物件 ( List<GameObject> 清單 )
        {
        if ( 清單 !=null)
            {
            Selection.objects = 清單.ToArray();
            }
        }

    public void 啟動物件 ( List<GameObject> 清單 )
        {
        foreach ( var 項目 in 清單 )
            {
            if ( 項目 != null )
                {
                項目.SetActive ( true );
                }
            }
 
        }
    public void 關閉物件 ( List<GameObject> 清單 )
        {
        foreach ( var 項目 in 清單 )
            {
            if ( 項目 != null )
                {
                項目.SetActive ( false );
                }
            }
        }

    public void 改透明 ( GameObject 項目 )
        {
        SpriteRenderer 貼圖運算器 = 項目.GetComponent<SpriteRenderer> ( );
        Color 顏色 = 貼圖運算器.color;
        顏色.a = 0;
        貼圖運算器.color = 顏色;
        }
    public void 改透明 ( List<GameObject> 清單 )
        {
        foreach ( var 項目 in 清單 )
            {
            if ( 項目 != null )
                {
                改透明 ( 項目 );
                }
            }
        }

    public void 改實色 ( GameObject 項目 )
        {
        SpriteRenderer 貼圖運算器 = 項目.GetComponent<SpriteRenderer> ( );
        Color 顏色 = 貼圖運算器.color;
        顏色.a = 1;
        貼圖運算器.color = 顏色;
        }
    public void 改實色 ( List<GameObject> 清單 )
        {
        foreach ( var 項目 in 清單 )
            {
            if ( 項目 != null )
                {
                改實色 ( 項目 );
                }
            }
        }
    
    
    }

