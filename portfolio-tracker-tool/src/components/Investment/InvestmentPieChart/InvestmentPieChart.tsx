import Highcharts from "highcharts";
import HighchartsReact from "highcharts-react-official";
import { useAppSelector } from "../../../hooks";

export const InvestmentPieChart = () => {
  const investmentsSummary = useAppSelector(
    (state) => state.investments.summary
  );

  const chartOptions = {
    chart: { type: "pie" },
    title: { text: "Portfolio Distribution" },
    series: [
      {
        name: "Value",
        data: investmentsSummary.map((i) => ({
          name: i.assetType,
          y: i.totalValue,
        })),
      },
    ],
    plotOptions: {
      pie: {
        dataLabels: {
          format: "{point.name}: {point.percentage:.1f}%",
        },
      },
    },
    credits: {
      enabled: false,
    },
  };

  return (
    <div className="p-6 bg-white shadow rounded-xl">
      <HighchartsReact highcharts={Highcharts} options={chartOptions} />
    </div>
  );
};
