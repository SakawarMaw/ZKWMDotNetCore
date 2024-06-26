﻿namespace ZKWMDotNetCore.PizzaApi.Queries
{
    public class PizzaQuery
    {
        public static string PizzaOrderQuery { get; } =
            @"SELECT po.*, p.Pizza, p.Price from Tbl_PizzaOrder po
                INNER JOIN Tbl_Pizza p on p.PizzaId = po.PizzaId
                WHERE PizzaOrderInvoiceNo = @PizzaOrderInvoiceNo";

        public static string PizzaOrderDetailQuery { get; } =
            @"SELECT pod.*, pe.PizzaExtraName, pe.Price from Tbl_PizzaOrderDetail pod
            INNER JOIN Tbl_PizzaExtra pe on pod.PizzaExtraId = pe.PizzaExtraId
            WHERE PizzaOrderInvoiceNo = @PizzaOrderInvoiceNo";
    }
}
