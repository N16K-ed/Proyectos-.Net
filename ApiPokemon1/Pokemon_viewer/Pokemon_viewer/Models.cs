using System.Collections.Generic;

namespace Pokemon_viewer
{
    public class NamedApiResource
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability
    {
        public NamedApiResource ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Move
    {
        public NamedApiResource move { get; set; }
    }

    public class Sprite
    {
        public string front_default { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public NamedApiResource stat { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public NamedApiResource type { get; set; }
    }

    public class Pokemon
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public Sprite sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }
    }
}
