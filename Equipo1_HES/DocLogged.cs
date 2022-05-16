using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipo1_HES
{
    class DocLogged
    {
        static string Name;
        static string LastName;
        static string User;
        static string Pass;
        static string Id;
        static string Spec;
        static string Cons;
        static string Disp;


        public static string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public static string lastname
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public static string user
        {
            get
            {
                return User;
            }

            set
            {
                User = value;
            }
        }

        public static string pass
        {
            get
            {
                return Pass;
            }

            set
            {
                Pass = value;
            }
        }

        public static string id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }
        public static string spec
        {
            get
            {
                return Spec;
            }

            set
            {
                Spec = value;
            }
        }
        public static string cons
        {
            get
            {
                return Cons;
            }

            set
            {
                Cons = value;
            }
        }
        public static string disp
        {
            get
            {
                return Disp;
            }

            set
            {
                Disp = value;
            }
        }
    }
}
