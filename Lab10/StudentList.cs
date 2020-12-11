using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    class StudentList : IEnumerable<Student>
    {
        LinkedList<Student> studList = new LinkedList<Student>();

        public StudentList() { }
        public StudentList(params Student[] values)
        {
            foreach (Student person in values)
                Add(person);
        }

        public Student this[int i]
        {
            get
            {
                if (i < 0 || i > studList.Count)
                    throw new ArgumentException("");
                else
                {
                    LinkedListNode<Student> node = studList.First;
                    for (int j = 0; j < i; j++)
                    {
                        node = node.Next;
                    }
                    return node.Value;
                }
            }

            set
            {
                if (i < 0 || i > studList.Count)
                    throw new ArgumentException("");
                else
                {
                    LinkedListNode<Student> node = studList.First;
                    for (int j = 0; j < i; j++)
                    {
                        node = node.Next;
                    }
                    node.Value = value;
                }
            }
        }
        public bool Add(Student person)
        {
            studList.AddLast(person);
            if (studList.Last.Value != null)
                return true;
            else
                return false;
        }
        public void AddFirst(Student person)
        {
            studList.AddFirst(person);
        }
        public void AddLast(Student person)
        {
            studList.AddLast(person);
        }
        public void Clear()
        {
            studList.Clear();
        }
        public bool Contains(Student person)
        {
            return studList.Contains(person);
        }

        public Student Find(Student person)
        {
            return (studList.Find(person)).Value;
        }

        public bool Remove(Student person)
        {
            return studList.Remove(person);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return studList.GetEnumerator();
        }

        public StudentList GetEnumerator()
        {
            return new StudentList();
        }

        IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


}

