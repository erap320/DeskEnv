using System.Collections.Generic;

namespace DeskEnv
{
    public class Task
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Args { get; set; }
        public bool Minimized { get; set; }
        public bool AsAdmin { get; set; }

        public Task()
        {
            Minimized = false;
            AsAdmin = false;
        }
    }

    public class Environment
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        public Environment()
        {
            Tasks = new List<Task>();
        }
    }
}
