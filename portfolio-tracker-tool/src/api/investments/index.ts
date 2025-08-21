import { apiClient } from "../axios";

export const fetchInvestments = async () => {
  const { data } = await apiClient.get("/investments");
  return data;
};

export const fetchInvestmentsSummary = async () => {
  const { data } = await apiClient.get("/investments/summary");
  return data;
};
