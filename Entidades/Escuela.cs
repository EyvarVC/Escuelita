namespace Escuelita.Entidades
{
    public class Escuela
    {
        private string _id;
        private string _nombre;

        private string _pais;
        private string _ciudad;

        private int _añoCreacion;

        private TipoEscuela _tipo;

        public string ID
        {
            get { return _id; }
            private set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }

        }

        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        public int AñoCreación
        {
            get { return _añoCreacion; }
            set { _añoCreacion = value; }
        }

        public TipoEscuela Tipo 
        {
            get{return _tipo;}
            set{_tipo=value;}
        }

        public Curso[] Cursos {get;set;}

        public Escuela(string Nombre, string Pais, string Ciudad, int Año, TipoEscuela Tipo=TipoEscuela.Primaria)
        {
            (_nombre, _pais, _ciudad, _añoCreacion, _tipo)=(Nombre, Pais, Ciudad, Año, Tipo);
            ID = System.Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"Escuela:{Nombre} Año de Creación:{AñoCreación} País:{Pais} Ciudad:{Ciudad} Tipo:{Tipo}";
        }

    }
}