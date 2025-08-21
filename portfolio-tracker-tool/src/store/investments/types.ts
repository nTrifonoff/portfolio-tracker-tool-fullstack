export type AssetType = "Crypto" | "Property" | "Rare Metals" | "Stock";
export type TransactionType = "Buy" | "Sell";

export interface Investment {
  id: number;
  name: string;
  assetType: AssetType;
  transactionType: TransactionType;
  amount: number;
  pricePerUnit: number;
  totalValue: number;
}

export interface InvestmentSummary {
  assetType: AssetType;
  totalValue: number;
}

export interface InvestmentState {
  items: Investment[];
  summary: InvestmentSummary[];
  loading: boolean;
  error: string | undefined;
}
