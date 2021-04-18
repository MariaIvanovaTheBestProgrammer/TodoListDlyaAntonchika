using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    enum FilmGanre
    {
        Comedy,
        Horror,
        Melodramas,
        Action,
        Crime,
        Western
    }
    class RestListElement : BasicListElement
    {
        private FilmGanre filmType;
        public FilmGanre FilmType
        {
            get { return filmType; }
            set
            {
                    filmType = value;
            }
        }
        private string filmToWatch;
        public override string GetMainActivity
        {
            get { return filmToWatch; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Please enter the film name");
                }
                else
                {
                    filmToWatch = value;
                }
            }

        }
        public RestListElement(int id, string name, string description, DateTime creationDate, DateTime deadline, string filmToWatch, FilmGanre filmType)
    : base(id, name, description, creationDate, deadline)
        {
            this.GetMainActivity = filmToWatch;
            this.FilmType = filmType;
        }
        public override string ToString()
        {
            return base.ToString() + " Film name: " + filmToWatch + " Film ganre: " + filmType;
        }
    }
}
