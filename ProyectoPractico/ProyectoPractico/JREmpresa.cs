namespace ProyectoPractico
{
    internal class JREmpresa
    {
        private string _JRRTN;
        private string _JRNombre;
        private string _JRDirección;
        private string _JRTeléfono;
        private string _JREmail;

        public string JRRTN { get => _JRRTN; }
        public string JRNombre { get => _JRNombre; }
        public string JRDirección { get => _JRDirección; set => _JRDirección = value; }
        public string JRTeléfono { get => _JRTeléfono; set => _JRTeléfono = value; }
        public string JREmail { get => _JREmail; set => _JREmail = value; }

    }
}
