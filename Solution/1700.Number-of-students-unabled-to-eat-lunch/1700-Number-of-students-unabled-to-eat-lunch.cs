using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1700.Number_of_students_unabled_to_eat_lunch
{
    public class _1700_Number_of_students_unabled_to_eat_lunch
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new Queue<int>();

            foreach (var stu in students)
                queue.Enqueue(stu);

            bool flag;
            int i;
            int index = 0;
            int student;

            while (queue.Count > 0)
            {
                flag = false;

                for (i = 0; i < queue.Count; i++)
                {
                    student = queue.Dequeue();

                    if (student == sandwiches[index])
                    {
                        index++;
                        flag = true;
                    }
                    else
                        queue.Enqueue(student);
                }

                if (!flag)
                    break;
            }

            return queue.Count;
        }
    }
}
