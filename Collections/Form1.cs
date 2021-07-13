using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            GenericClass<int> t = new GenericClass<int>(12, 12);
            Console.WriteLine(t.Sum());

            GenericClass<float> q = new GenericClass<float>((float)1.25, (float)2.40);
            Console.WriteLine(q.Sum());

            ArrayList v = new ArrayList();

            for (int i = 0; i <= 100; i++)
            {
                v.Add(i);
            }

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(v[i]);
            }

            SortedList<int, Student> students = new SortedList<int, Student>();

            students.Add(7, new Student("Ana", 7));
            students.Add(10, new Student("Darius", 10));
            students.Add(3, new Student("Maia", 3));

            foreach (var student in students)
            {
                Console.WriteLine(student.Value.getName() + " " + student.Value.getGrade());
            }
        }
    }
}
