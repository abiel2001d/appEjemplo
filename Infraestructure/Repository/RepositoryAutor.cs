using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryAutor : IRepositoryAutor
    {
        public Autor GetAutorByID(int id)
        {
            try
            {
                Autor oAutor = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //Select * from Autor where id=
                    //*** Sintaxis LINQ Query
                    //var infoAutor=from a in ctx.Autor
                    //              where a.IdAutor == id
                    //              select a;
                    //oAutor=infoAutor.FirstOrDefault();
                    //*** Sintaxis LINQ Method
                    //Find sin ningún otro método, formato automático
                    oAutor = ctx.Autor.Find(id);
                    //Combinar con otros métodos y se debe dar formato
                    //oAutor= ctx.Autor.Where(x => x.IdAutor == id).First<Autor>();
                    
                }
                return oAutor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Autor> GetAutors()
        {
            try
            {
                IEnumerable<Autor> lista=null;
                using (MyContext ctx= new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled= false;
                    //Select * from Autor 
                    lista= ctx.Autor.ToList<Autor>();
                    //lista = ctx.Autor.ToList();
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
