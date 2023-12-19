using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Reflection;

public class NewBehaviourScript
{
    [MenuItem("Assets/Format Animator")]
    static void FormatAnimator()
    {
        // Animatorウィンドウ取得
        var asm = Assembly.Load("UnityEditor.Graphs");
        var editorGraphModule = asm.GetModule("UnityEditor.Graphs.dll");
        var typeAnimatorWindow = editorGraphModule.GetType("UnityEditor.Graphs.AnimatorControllerTool");
        var animatorWindow = EditorWindow.GetWindow(typeAnimatorWindow);

        // 現在選択しているAnimatorControllerの取得
        var animator = Selection.activeObject as UnityEditor.Animations.AnimatorController;

        // ノードを整列
        animator.layers.ToList().ForEach(layer =>
        {
            Vector3 offset = new Vector3(0f, 0f, 0f);
            layer.stateMachine.anyStatePosition = offset;
            layer.stateMachine.entryPosition = offset + new Vector3(0f, 36f, 0f);
            layer.stateMachine.exitPosition = offset + new Vector3(0f, 72f, 0f);
        });

        // Animatorウィンドウのノードグラフ　リセット
        animatorWindow.GetType()
        .GetMethod("RebuildGraph", BindingFlags.Public | BindingFlags.Instance)
        .Invoke(animatorWindow, null);
    }

    [MenuItem("Assets/Format Animator", true)]
    static bool ValidateFormatAnimator()
    {
        return Selection.activeObject.GetType() == typeof(UnityEditor.Animations.AnimatorController);
    }
}
