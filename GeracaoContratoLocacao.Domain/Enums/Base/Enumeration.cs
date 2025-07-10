namespace GeracaoContratoLocacao.Domain.Enums.Base
{
    public class Enumeration
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static string ValueMemberAttribute = "Id";
        public static string DisplayMemberAttribute = "Name";

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
    }
}
