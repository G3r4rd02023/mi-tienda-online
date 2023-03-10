namespace ProyectoPractico
{
    internal class JRFactura
    {
        private int _JRNoFactura;
        private string _JRMoneda;
        private double _JRTasaCambio;
        private string _JRTipoFactura;
        private DateTime _JRFechaFactura;
        private DateTime _JRFechaVencimiento;
        private double _JRSubtotal;
        private double _JRDescuento;
        private double _JRTotalDescuento;
        private double _JRTotalIsv;
        private double _JRTotal;

        public int JRNoFactura { get { return _JRNoFactura; } set { _JRNoFactura = value; } }
        public string JRMoneda { get => _JRMoneda; set => _JRMoneda = value; }
        public double JRTasaCambio { get => _JRTasaCambio; set => _JRTasaCambio = value; }
        public string JRTipoFactura { get => _JRTipoFactura; set => _JRTipoFactura = value; }
        public DateTime JRFechaFactura { get => _JRFechaFactura; set => _JRFechaFactura = value; }
        public DateTime JRFechaVencimiento { get => _JRFechaVencimiento; set => _JRFechaVencimiento = value; }
        public double JRSubtotal { get => _JRSubtotal; set => _JRSubtotal = value; }
        public double JRDescuento { get => _JRDescuento; set => _JRDescuento = value; }
        public double JRTotalDescuento { get => _JRTotalDescuento; set => _JRTotalDescuento = value; }
        public double JRTotalIsv { get => _JRTotalIsv; set => _JRTotalIsv = value; }
        public double JRTotal { get => _JRTotal; set => _JRTotal = value; }

    }
}
