namespace ServerManagement.Models
{
    public static class ToDoItemsRepository
    {
        private static List<ToDoItem> items = new List<ToDoItem>()
        {
            new ToDoItem {  Id = 1, Name = "Item1" },
            new ToDoItem {  Id = 2, Name = "Item2" },
            new ToDoItem {  Id = 3, Name = "Item3" },
            new ToDoItem {  Id = 4, Name = "Item4" },

        };

        public static void AddToDoItem(ToDoItem item)
        {
            if(items.Count > 0)
            {
                var maxId = items.Max(i => i.Id);
                item.Id = maxId + 1;
                items.Add(item);
            }
            else
            {
                item.Id = 1;
                items.Add(item);
            }
        }

        public static List<ToDoItem> GetToDoItems()
        {
            var sortedItems = items.OrderBy(item => item.IsComplete)
                .ThenByDescending(item => item.Id)
                .ToList();

            return sortedItems;
        }

        //public static List<ToDoItem> GetServersByCity(string cityName)
        //{
        //    return items.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        //}

        //public static ToDoItem? GetServerById(int id)
        //{
        //    var server = items.FirstOrDefault(s => s.Id == id);
        //    if (server != null)
        //    {
        //        return new ToDoItem
        //        {
        //            Id = server.Id,
        //            Name = server.Name,
        //            City = server.City,
        //            IsOnline = server.IsOnline
        //        };
        //    }

        //    return null;
        //}

        public static void UpdateServer(int itemId, ToDoItem item)
        {
            if (itemId != item.Id) return;

            var itemsToUpdate = items.FirstOrDefault(s => s.Id == itemId);
            if (itemsToUpdate != null)
            {
                itemsToUpdate.Name = item.Name;   
            }
        }

        public static void DeleteServer(int itemId)
        {
            var item = items.FirstOrDefault(s => s.Id == itemId);
            if (item != null)
            {
                items.Remove(item);
            }
        }

        public static List<ToDoItem> SearchServers(string itemFilter)
        {
            return items.Where(s => s.Name.Contains(itemFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
