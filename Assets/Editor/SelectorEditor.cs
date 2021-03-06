using UnityEngine;
using UnityEditor;

[CustomEditor ( typeof ( Selector ) )]
public class SelectorEditor : Editor
    {

    public override void OnInspectorGUI ( )
        {

        Selector selector = ( Selector )target;
        
        DrawDefaultInspector ( );

        EditorGUILayout.BeginHorizontal ( );
        if ( GUILayout.Button("啟動與實色") )
            {
            selector.啟動物件 (selector.清單 );
            selector.改實色 ( selector.清單 );
            }
        
        if ( GUILayout.Button ( "關閉與透明" ) )
            {
            selector.關閉物件 ( selector.清單 );
            selector.改透明 ( selector.清單 );
            }

        EditorGUILayout.EndHorizontal ( );
        if ( GUILayout.Button ( "選擇以上物件" ) )
            {
            Selector.選擇場景內物件 ( selector.清單 );
            
            }

        }
    }