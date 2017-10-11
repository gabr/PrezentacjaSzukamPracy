using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FPaint.Interfaces;

namespace FPaint
{
    class Memory : IEnumerable<IMemorable>
    {

        private List<IMemorable> list;
        private List<IMemorable> repeatList;

        public Memory()
        {
            list = new List<IMemorable>();
            repeatList = new List<IMemorable>();
        }

        public void Add(IMemorable memoryItem)
        {
            list.Add(memoryItem);
            repeatList.Clear();
        }

        public void Clear()
        {
            list.Clear();
            repeatList.Clear();
        }

        public void Undo()
        {
            if (list.Count != 0)
            {
                repeatList.Add(list[list.Count() - 1]);
                list.RemoveAt(list.Count() - 1);
            }
        }

        public void Repeat()
        {
            if (repeatList.Count != 0)
            {
                list.Add(repeatList[repeatList.Count() - 1]);
                repeatList.RemoveAt(repeatList.Count() - 1);
            }
        }

        public IEnumerator<IMemorable> GetEnumerator()
        {
            foreach (IMemorable memoryItem in list)
            {
                yield return memoryItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
