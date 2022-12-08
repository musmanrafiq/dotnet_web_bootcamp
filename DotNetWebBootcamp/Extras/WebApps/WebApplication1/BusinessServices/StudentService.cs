namespace WebApplication1.BusinessServices
{
    public class StudentService
    {
        private List<int> items;

        public StudentService()
        {
            items = new List<int>();
        }

        public void Add(int input)
        {
            items.Add(input);
        }

        public List<int> Get()
        {
            return items;
        }
    }
}
