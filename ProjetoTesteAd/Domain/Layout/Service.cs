using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.Layout
{
    public class Service
    {
        public static Model CreateDefault()
        {
            var Users = new[]
               {
                   new Users.List.Model
                   {
                       id = 1,
                       name = "Empresa 1"
                   },
                   new Users.List.Model
                   {
                       id = 2,
                       name = "Empresa 2"
                   }
             };



            return new Model
            {
               Users = new[]
               {
                   new Users.List.Model
                   {
                       id = 1,
                       name = "Empresa 1"
                   },
                   new Users.List.Model
                   {
                       id = 2,
                       name = "Empresa 2"
                   }
               },
               Holdings = new[]
               {
                   new Holding.List.Model
                   {
                       id = 1,
                       name = "Luan"
                   },
                   new Holding.List.Model
                   {
                       id = 2,
                       name = "Theodor"
                   }
               },
               Departments = new[]
               {
                   new Department.List.Model
                   {
                       id = 1,
                       name = "Financeiro"
                   },
                   new Department.List.Model
                   {
                       id = 2,
                       name = "Logistico"
                   }
               },
               UsersGroups = new[]
               {
                   new UsersGroup.List.Model
                   {
                       id = 1,
                       name = "Administrador"
                   },
                   new UsersGroup.List.Model
                   {
                       id = 2,
                       name = "Moderador"
                   }
               },
               Teams = new[]
               {
                   new Team.List.Model
                   {
                       id = 1,
                       name = "Time 1"
                   },
                   new Team.List.Model
                   {
                       id = 2,
                       name = "Time 2"
                   }
               }
            };
        }

    }
}