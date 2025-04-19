namespace ServerManagement.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        private bool _isComplete;
        public bool IsComplete 
        { 
            get => _isComplete;
            set
            {
                _isComplete = value;
                if (value)
                {
                    DateCompleted = DateTime.Now;
                }
            }
        }
        public DateTime DateCompleted { get; set; }
    }
}
