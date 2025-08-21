import { createAsyncThunk } from "@reduxjs/toolkit";
import {
  fetchInvestments,
  fetchInvestmentsSummary,
} from "../../api/investments";

export const loadInvestments = createAsyncThunk(
  "investments/loadInvestments",
  async () => {
    return await fetchInvestments();
  }
);

export const loadInvestmentsSummary = createAsyncThunk(
  "investments/loadInvestmentsSummary",
  async () => {
    return await fetchInvestmentsSummary();
  }
);
