using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0841.Keys_and_rooms
{
    public class _0841_Keys_and_rooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            if (rooms.Count <= 1) return true;

            // record whether the room is open.
            Dictionary<int, bool> dic = new Dictionary<int, bool>();

            for (int i = 0; i < rooms.Count; i++)
                dic.Add(i, false);

            Queue<int> keys = new Queue<int>();
            keys.Enqueue(0);

            while (keys.Count > 0)
            {
                // open the room with key.
                int key = keys.Dequeue();

                if (dic[key]) continue;

                // pick up the key.
                for (int i = 0; i < rooms[key].Count; i++)
                    keys.Enqueue(rooms[key][i]);

                // record the room is opened.
                dic[key] = true;

                // check whether all room is open.
                if (dic.ContainsValue(false)) continue;
                else return true;
            }

            return false;
        }
    }
}
