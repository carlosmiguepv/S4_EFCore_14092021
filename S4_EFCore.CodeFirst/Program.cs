using System;
using System.Collections.Generic;
using S4_EFCore.CodeFirst.Models;

namespace S4_EFCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Se usa para conectar con la tabla
            using var context = new MundialDBContext();
            //Se usa para insertar algo en la tabla
            //var position = new SoccerPosition()
            //{
            //    Description = "Portero",
            //    Code = "PT"
            //};

            //context.SoccerPosition.Add(position);
            
            //Confirmacion del guardado
            //context.SaveChanges();

            var position1 = new SoccerPosition()
            {
                Description = "Lateral  Izquierdo",
                Code = "LI"
            };
            var position2 = new SoccerPosition()
            {
                Description = "Lateral Derecho",
                Code = "LD"
            };
            var position3 = new SoccerPosition()
            {
                Description = "Mediocampista Ofensivo",
                Code = "MO"
            };
            var position4 = new SoccerPosition()
            {
                Description = "Delantero",
                Code = "CD"
            };

            //Se usa para ingresar en bloque 
            var positionList = new List<SoccerPosition>();
            positionList.Add(position1);
            positionList.Add(position2);
            positionList.Add(position3);
            positionList.Add(position4);

            context.SoccerPosition.AddRange(positionList);
            context.SaveChanges();
        }
    }
}
