using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    class Ds
    {
        void GetList()
        {
            //리스트 : 박싱/언박싱 발생안함. 
            List<int> _list = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                _list.Add(i);
            }
        }
        void GetArrayList()
        {
            //어레이 리스트 : 아무거나  다 넣음, 박싱/언박싱 발생 느림
            ArrayList _list = new ArrayList();
            _list.Add(123123);
            _list.Add("SDFSDFSDF");
        }
        void GetHashTable()
        {
            //해쉬테이블 : 박싱/언박싱 느림
            Hashtable _hash = new Hashtable();
            _hash.Add(123123, "sss");
            _hash.Add("SDFSDFSDF", 123222);
        }
        void GetDictionary()
        {
            //딕셔너리
            Dictionary<int, int> _hash = new Dictionary<int, int>();
            for (int i = 0; i < 3; i++)
            {
                _hash.Add(i, i);
            }
        }
    }
}