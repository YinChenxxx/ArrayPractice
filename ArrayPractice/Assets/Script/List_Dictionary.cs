using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_Dictionary : MonoBehaviour
{
    public List<int> littleList = new List<int>();
    public Dictionary<int, string> students = new Dictionary<int, string>();
    public Dictionary<int, List<string>> homeMember = new Dictionary<int, List<string>>();

    void Start()
    {
        students[1] = "123";

        homeMember.Add(1, new List<string>());
        homeMember[1].Add("Michael");
        homeMember[1].Add("Ina");

    }

    public void TestList()
    {
        List<int> listB = new List<int>();
        listB.Add(52);
        Debug.Log(listB[0]);
        listB.Clear();
        listB.Add(55);
        listB.Add(56);
        listB.Add(57);
        listB.Add(58);
        listB.RemoveAt(2);
        listB.Remove(57);



    }

    [ContextMenu("TestDic")]
    public void TestDic()
    {
        students.Add(1, "Ina");
        students.Add(2, "Sabrina");
        students.Add(3, "Samantha");
        students.Add(4, "MIchael");
        students[23] = "Bad";

        students.Remove(3);

        Debug.Log(students.ContainsKey(1));
        Debug.Log(students[1] + students[23]);

        if (students.ContainsKey(1))
        {
            students[1] = "";
        }
        else
            students[1] = "XDDD";


    }
}
