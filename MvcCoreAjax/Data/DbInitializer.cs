using MvcCoreAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAjax.Data
{
    public class DbInitializer
    {
        public static void Initializer(ProjectDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categories.Any()) 
            {
                return;
            }

            var categorias = new Category[]
            {
               new Category {Name="Programacion", Description="Curso de programacion", Estado=true },
               new Category {Name="Expresiones Lambda", Description="Curso de Expresines Lambda", Estado=true },
               new Category {Name="Diseño Grafico", Description="Curso de Diseño", Estado=false }
            };

            foreach (var item in categorias) {
                context.Categories.Add(item);
            }
            context.SaveChanges();
        }
    }
}
