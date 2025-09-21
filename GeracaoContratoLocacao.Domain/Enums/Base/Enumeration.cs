namespace GeracaoContratoLocacao.Domain.Enums.Base
{
    public class Enumeration
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly string ValueMemberAttribute = "Id";
        public static readonly string DisplayMemberAttribute = "Name";

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            return typeof(T).GetFields()
                .Where(f => f.FieldType == typeof(T))
                .Select(f => (T)f.GetValue(null));
        }

        public static T GetById<T>(int id) where T : Enumeration
        {
            return GetAll<T>().FirstOrDefault(e => e.Id == id);
        }

        public static T GetByName<T>(string name) where T : Enumeration
        {
            return GetAll<T>().FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static List<T> PreencherComboBox<T>() where T : Enumeration
        {
            return new List<T> { (T)Activator.CreateInstance(typeof(T), new object[] {default, default}) }.Concat(GetAll<T>()).ToList();
        }
    }
}
