namespace Model.Data
{
    public class usuario : classe_base
    {
        public int usuario_id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        string _senha = "***************";
        public string SenhaProtegida
        {
            get { return _senha; }
            set { senha = Security.GetHashMD5(value); }
        }
    }
}