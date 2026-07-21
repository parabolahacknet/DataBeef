using System;
using System.Collections.Generic;
using System.Data;

namespace Reportes_y_estadisticas_DATABEEF.Data
{
    public sealed class ResumenReporte
    {
        public decimal Compras { get; set; }
        public decimal Ventas { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Inventario { get; set; }
        public DataTable Detalle { get; set; }
        public Dictionary<string, decimal> VentasMensuales { get; set; }
        public Dictionary<string, decimal> DistribucionInventario { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public sealed class ReporteDatosSimulados
    {
        public ResumenReporte Obtener(string tipo, DateTime desde, DateTime hasta)
        {
            var resumen = new ResumenReporte
            {
                Compras = 18420.50m,
                Ventas = 26780.75m,
                Ganancia = 8360.25m,
                Inventario = 3240m,
                VentasMensuales = new Dictionary<string, decimal>
                {
                    { "Ene", 4100 }, { "Feb", 5300 }, { "Mar", 4750 },
                    { "Abr", 6200 }, { "May", 6430 }
                },
                DistribucionInventario = new Dictionary<string, decimal>
                {
                    { "Res", 48 }, { "Cerdo", 24 }, { "Pollo", 18 }, { "Insumos", 10 }
                }
            };

            resumen.Detalle = CrearDetalle(tipo);
            foreach (DataRow row in resumen.Detalle.Rows)
            {
                if (resumen.Detalle.Columns.Contains("Total") && row["Total"] != DBNull.Value)
                    resumen.ValorTotal += Convert.ToDecimal(row["Total"]);
            }
            return resumen;
        }

        private static DataTable CrearDetalle(string tipo)
        {
            switch (tipo)
            {
                case "Ventas": return Ventas();
                case "Compras": return Compras();
                case "Inventario": return Inventario();
                case "Producción": return Produccion();
                case "Mermas y rendimiento": return Mermas();
                case "Trazabilidad por lote": return Trazabilidad();
                case "Productos próximos a vencer": return Vencimientos();
                default: return new DataTable();
            }
        }

        private static DataTable Tabla(params string[] columnas)
        {
            var tabla = new DataTable();
            foreach (string columna in columnas) tabla.Columns.Add(columna);
            return tabla;
        }

        private static DataTable Ventas()
        {
            var t = Tabla("Fecha", "Número de venta", "Producto", "Lote", "Cantidad", "Precio unitario", "Total", "Cliente");
            t.Rows.Add("10/07/2026", "V-00125", "Lomo fino", "LT-260701", "18 kg", 8.90m, 160.20m, "Restaurante El Fogón");
            t.Rows.Add("12/07/2026", "V-00126", "Costilla de res", "LT-260704", "25 kg", 6.40m, 160.00m, "Parrillada Central");
            t.Rows.Add("14/07/2026", "V-00127", "Carne molida", "LT-260708", "30 kg", 4.75m, 142.50m, "Minimarket Norte");
            return t;
        }

        private static DataTable Compras()
        {
            var t = Tabla("Fecha", "Número de compra", "Proveedor", "Animal o insumo", "Cantidad", "Peso", "Costo unitario", "Total");
            t.Rows.Add("08/07/2026", "C-0048", "Ganadería San José", "Bovino", 3, "1380 kg", 2.15m, 2967.00m);
            t.Rows.Add("11/07/2026", "C-0049", "Empaques Andinos", "Fundas al vacío", 500, "12 kg", 0.18m, 90.00m);
            return t;
        }

        private static DataTable Inventario()
        {
            var t = Tabla("Producto", "Categoría", "Lote", "Stock actual", "Stock mínimo", "Fecha de vencimiento", "Estado");
            t.Rows.Add("Lomo fino", "Cortes premium", "LT-260701", "42 kg", "15 kg", "22/07/2026", "Disponible");
            t.Rows.Add("Costilla de res", "Cortes", "LT-260704", "18 kg", "20 kg", "20/07/2026", "Stock bajo");
            return t;
        }

        private static DataTable Produccion()
        {
            var t = Tabla("Fecha", "Lote de origen", "Proceso", "Producto obtenido", "Peso inicial", "Peso final", "Merma", "Rendimiento");
            t.Rows.Add("09/07/2026", "LT-260701", "Desposte", "Cortes de res", "460 kg", "356 kg", "104 kg", "77.4 %");
            t.Rows.Add("13/07/2026", "LT-260708", "Molienda", "Carne molida", "85 kg", "80 kg", "5 kg", "94.1 %");
            return t;
        }

        private static DataTable Mermas()
        {
            var t = Tabla("Fecha", "Lote", "Proceso", "Peso inicial", "Peso final", "Merma", "Rendimiento", "Responsable");
            t.Rows.Add("09/07/2026", "LT-260701", "Desposte", "460 kg", "356 kg", "104 kg", "77.4 %", "Carlos M.");
            t.Rows.Add("13/07/2026", "LT-260708", "Molienda", "85 kg", "80 kg", "5 kg", "94.1 %", "Ana P.");
            return t;
        }

        private static DataTable Trazabilidad()
        {
            var t = Tabla("Código de lote", "Proveedor", "Fecha de ingreso", "Producto obtenido", "Existencia actual", "Destino o venta", "Estado del lote");
            t.Rows.Add("LT-260701", "Ganadería San José", "07/07/2026", "Cortes de res", "128 kg", "Ventas locales", "Activo");
            t.Rows.Add("LT-260704", "Finca El Prado", "09/07/2026", "Costilla y pulpa", "76 kg", "Restaurantes", "Activo");
            return t;
        }

        private static DataTable Vencimientos()
        {
            var t = Tabla("Producto", "Lote", "Fecha de vencimiento", "Días restantes", "Cantidad disponible", "Estado");
            t.Rows.Add("Costilla de res", "LT-260704", "20/07/2026", 5, "18 kg", "Próximo a vencer");
            t.Rows.Add("Lomo fino", "LT-260701", "22/07/2026", 7, "42 kg", "Atención");
            return t;
        }
    }
}
