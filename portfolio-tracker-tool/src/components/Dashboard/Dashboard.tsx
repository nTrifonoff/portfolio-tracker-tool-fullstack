import { useEffect } from "react";
import {
  loadInvestments,
  loadInvestmentsSummary,
} from "../../store/investments/thunks";
import { DashboardWidgets } from "./DashboardWidgets";
import { InvestmentTable } from "../Investment";
import { useAppDispatch } from "../../hooks";

export const Dashboard = () => {
  const dispatch = useAppDispatch();

  useEffect(() => {
    dispatch(loadInvestments());
    dispatch(loadInvestmentsSummary());
  }, [dispatch]);

  return (
    <div className="p-6">
      <DashboardWidgets />
      <InvestmentTable />
    </div>
  );
};
