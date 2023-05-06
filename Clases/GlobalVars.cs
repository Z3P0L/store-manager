using System.Windows.Forms;

namespace Proyecto_POO.Clases
{
    internal class GlobalVars
    {
        private static int _GlobalId;
        private static int _GlobalDocumento;
        private static string _GlobalUserLogged;
        private static string _UserType;
        private static Form _LastForm;

        public static int GlobalId
        {
            get { return _GlobalId; }
            set { _GlobalId = value; }
        }

        public static int GlobalDocumento
        {
            get { return _GlobalDocumento; }
            set { _GlobalDocumento = value; }
        }

        public static string GlobalUserLogged
        {
            get { return _GlobalUserLogged; }
            set { _GlobalUserLogged = value; }
        }

        public static string UserType
        {
            get { return _UserType; }
            set { _UserType = value; }
        }

        public static Form LastForm
        {
            get { return _LastForm; }
            set { _LastForm = value; }
        }
    }
}
