namespace Collections
{
    public class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public string getName()
        {
            return name;
        }

        public int getGrade()
        {
            return grade;
        }
    }
}