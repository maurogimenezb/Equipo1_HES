using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipo1_HES
{
    class PacLogged
    {
        static string Name;
        static string Pass;
        static string Sexo;
        static string Phone;
        static string Nac;
        static string Id;


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

        public static string sexo
        {
            get
            {
                return Sexo;
            }

            set
            {
                Sexo = value;
            }
        }

        public static string phone
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }
        public static string nac
        {
            get
            {
                return Nac;
            }

            set
            {
                Nac = value;
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
    }
}
