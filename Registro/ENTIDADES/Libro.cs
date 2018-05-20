using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registro.ENTIDADES
{
    public class Libro
    {
        [Key]

        public int TipoId { get; set; }
        public int Id { get; set; }
        public string siglas { get; set; }
        public string descripcion { get; set; }
        
        //Constructor lleno del objeto 
        public Libro(int Tipoid,int id, string siglas, string descripcion)
        {
            TipoId = Tipoid;
            Id = id;
            this.siglas = siglas;
            this.descripcion = descripcion;
        }
        //
        //Constructor vacio del objeto
        public Libro()
        {
            TipoId = 0;
            Id = 0;
            siglas = string.Empty;
            descripcion = string.Empty;
        }
    }
}
