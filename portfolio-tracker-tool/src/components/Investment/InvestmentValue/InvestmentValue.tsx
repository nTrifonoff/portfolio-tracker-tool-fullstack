import { useMemo } from "react";
import { useAppSelector } from "../../../hooks";

export const InvestmentValue = () => {
  const investmentsSummary = useAppSelector(
    (state) => state.investments.summary
  );

  const totalInvested = useMemo(
    () => investmentsSummary.reduce((sum, inv) => sum + inv.totalValue, 0),
    [investmentsSummary]
  );
  return (
    <div className="p-4 bg-white rounded-xl text-center content-center">
      <h2 className="text-3xl font-semibold pb-2">INVESTED VALUE</h2>
      <p className="text-3xl font-semibold">${totalInvested}</p>
    </div>
  );
};
