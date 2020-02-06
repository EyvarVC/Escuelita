namespace Escuelita.Entidades
{
    public class Curso
    {
        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private TipoJornada _jornada;
        public TipoJornada Jornada
        {
            get { return _jornada; }
            set { _jornada = value; }
        }

        public Curso() => this._id = System.Guid.NewGuid().ToString();

    }
}