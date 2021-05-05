using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    class Class
    {
        public int num { get; private set; }
        private int studentnum;
        private string name;
        private Student[] students;

        public Class() { }
        public Class(int num, string name)
        {
            this.num = num;
            this.name = name;
            students = new Student[100];//注意实例化
        }
        /**
         * 往班级中添加学生
         * @param student
         */
        public void AddStudent(Student student)
        {
            if (studentnum > num - 1)
                return;
            students[studentnum] = student;
            studentnum++;
        }

        ///**
        // * 返回班级人数
        // * @return
        // */
        //public int GetStudentNum()
        //{
        //    return num;
        //}

        /**
         * 返回对应下标的学生对象
         * @param index
         * @return
         */
        public Student GetStudent(int index)
        {
            if (index > studentnum) return null;
            return students[index];
        }

        
    public override string ToString()
        {
            String Students = "";
            for (int i = 0; i < num; i++)
                Students += students[i] + "\n";
            return "name:" + name + "\nnumber of student:" + num + "\nstudent:" + Students;
        }
    }
}
