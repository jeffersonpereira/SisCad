using System.Configuration;

namespace Model.Data
{
    public static class GlobalVar
    {
        public static empresa EmpresaAtual { get; set; }
        public static string Connection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SisCadEntities"].ConnectionString;
            }
        }
    }
}