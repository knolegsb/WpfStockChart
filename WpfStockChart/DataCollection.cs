using System.Collections.Generic;

namespace WpfStockChart
{
    public class DataCollection
    {
        private List<DataSeries> dataList = new List<DataSeries>();
        private StockChartTypeEnum stockChartType = StockChartTypeEnum.HiLoOpenClose;

        public StockChartTypeEnum StockChartType
        {
            get { return stockChartType; }
            set { stockChartType = value; }
        }

        public List<DataSeries> DataList
        {
            get { return dataList; }
            set { dataList = value; }
        }

        //public void AddStockChart(ChartStyle cs)
        //{

        //}
        public enum StockChartTypeEnum
        {
            HiLo = 0,
            HiLoOpenClose = 1,
            Candle = 2, 
            Line = 3
        }
    }
}