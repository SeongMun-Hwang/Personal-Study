using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveObjectsWindow : EditorWindow
{
    Vector3 moveAmount;

    [MenuItem("Custom Tools/Move Objects by Value")]
    public static void ShowWindow()
    {
        GetWindow<MoveObjectsWindow>("Move Objects");
    }

    void OnGUI()
    {
        //�� �Է����� ������Ʈ �̵�
        GUILayout.Label("Move Selected Objects", EditorStyles.boldLabel);
        moveAmount = EditorGUILayout.Vector3Field("Move Amount", moveAmount);
        if (GUILayout.Button("Move Objects"))
        {
            MoveSelectedObjects(moveAmount);
        }
        GUILayout.Space(10);

        // �θ� �����ϴ� ��ư �߰�
        GUILayout.Label("Remove Object's Parent", EditorStyles.boldLabel);
        if (GUILayout.Button("Remove Parent of Selected Objects"))
        {
            RemoveSelectedAndReparentChildren();
        }
        GUILayout.Space(10);

        //�θ� ��ǥ �ʱ�ȭ �� �ڽĿ��� ���
        GUILayout.Label("Reset Parent's position, keep child", EditorStyles.boldLabel);
        if (GUILayout.Button("Relocate Children"))
        {
            RelocateChildren();
        }
        GUILayout.Space(10);

        //���� ����
        GUILayout.Label("X & Y axis allign", EditorStyles.boldLabel);
        if (GUILayout.Button("Align Selected Objects"))
        {
            AlignSelectedObjects();
        }
        GUILayout.Space(10);
    }

    void MoveSelectedObjects(Vector3 delta)
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Undo.RecordObject(obj.transform, "Move Objects");
            obj.transform.position += delta;
        }
    }

    // ���õ� �θ� ��ü�� �����ϰ� �ڽĵ��� ���� ��ġ�� ������Ű�� �Լ�
    void RemoveSelectedAndReparentChildren()
    {
        foreach (GameObject selectedObj in Selection.gameObjects)
        {
            // ���õ� GameObject�� �θ� Ȯ��
            Transform parentTransform = selectedObj.transform.parent;

            // ���õ� GameObject�� �θ� ������ �ִ� ��쿡�� �۾� ����
            if (parentTransform != null)
            {
                // ���õ� GameObject�� ��� �ڽ��� ��ȸ
                int children = selectedObj.transform.childCount;
                for (int i = children - 1; i >= 0; i--)
                {
                    Transform child = selectedObj.transform.GetChild(i);

                    // Undo ����� ���� �ڽ� ��ü�� �θ� ���� ������ ���
                    Undo.SetTransformParent(child, parentTransform, "Reparent Child");

                    // �ڽ��� ���� �θ𿡰� ���� ����
                    child.SetParent(parentTransform, true);
                }

                // ���õ� GameObject ����
                Undo.DestroyObjectImmediate(selectedObj);
            }
        }
    }
    void RelocateChildren()
    {
        foreach (GameObject selectedObj in Selection.gameObjects)
        {
            Transform parentTransform = selectedObj.transform;

            // �θ� ������Ʈ�� ���� ��ġ ����
            Vector3 originalParentPosition = parentTransform.position;

            // �ڽ� ������Ʈ�� �۷ι� ��ġ�� ������ ����Ʈ
            List<Vector3> childGlobalPositions = new List<Vector3>();

            // �ڽ� ������Ʈ�� �۷ι� ��ġ ����
            for (int i = 0; i < parentTransform.childCount; i++)
            {
                childGlobalPositions.Add(parentTransform.GetChild(i).position);
            }

            // �θ� ������Ʈ�� ��ġ�� (0, 0, 0)���� ����
            Undo.RecordObject(parentTransform, "Reset Parent Position");
            parentTransform.position = Vector3.zero;

            // �ڽ� ������Ʈ�� �۷ι� ��ġ�� ����
            for (int i = 0; i < parentTransform.childCount; i++)
            {
                Transform child = parentTransform.GetChild(i);
                Undo.RecordObject(child, "Relocate Child");
                child.position = childGlobalPositions[i];
            }
        }
    }
    void AlignSelectedObjects()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            // ������Ʈ�� ���� ��ġ�� ������
            Vector3 currentPosition = obj.transform.position;

            // x�� z ��ǥ�� �ݿø��Ͽ� ����
            float alignedX = Mathf.Round(currentPosition.x);
            float alignedZ = Mathf.Round(currentPosition.z);

            // y ��ǥ�� �������� ����
            float alignedY = currentPosition.y;

            // ������Ʈ�� ��ġ�� ������Ʈ�ϱ� ���� Undo ����� ���� ������ ���
            Undo.RecordObject(obj.transform, "Align Objects");

            // ������Ʈ�� ��ġ�� ������Ʈ
            obj.transform.position = new Vector3(alignedX, alignedY, alignedZ);
        }
    }

}