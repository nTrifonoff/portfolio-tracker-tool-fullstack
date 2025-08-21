import { InvestmentPieChart, InvestmentValue } from "../../Investment";

export const DashboardWidgets = () => {
  return (
    <div className="grid grid-cols-2 gap-4">
      <InvestmentValue />
      <InvestmentPieChart />
    </div>
  );
};
