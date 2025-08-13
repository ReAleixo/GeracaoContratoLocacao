using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class Gender : Enumeration
    {
        public static readonly Gender Male = new(1, "Masculino");
        public static readonly Gender Female = new(2, "Feminino");

        public Gender(int id, string name) : base(id, name)
        {
        }

        public static List<Gender> GetAllToFillComboBox()
        {
            List<Gender> GenderList =
            [
                new Gender(default, default), .. Gender.GetAll<Gender>().ToList()
            ];
            return GenderList;
        }
    }
}
