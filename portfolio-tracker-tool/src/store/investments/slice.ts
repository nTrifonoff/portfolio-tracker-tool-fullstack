import { createSlice } from "@reduxjs/toolkit";
import { loadInvestments, loadInvestmentsSummary } from "./thunks";
import type { InvestmentState } from "./types";

const initialState: InvestmentState = {
  items: [],
  summary: [],
  loading: false,
  error: undefined,
};

const investmentsSlice = createSlice({
  name: "investments",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(loadInvestments.pending, (state) => {
        state.loading = true;
      })
      .addCase(loadInvestments.fulfilled, (state, action) => {
        state.loading = false;
        state.items = action.payload;
      })
      .addCase(loadInvestments.rejected, (state, action) => {
        state.loading = false;
        state.error = action.error.message;
      })

      .addCase(loadInvestmentsSummary.pending, (state) => {
        state.loading = true;
      })
      .addCase(loadInvestmentsSummary.fulfilled, (state, action) => {
        state.loading = false;
        state.summary = action.payload;
      })
      .addCase(loadInvestmentsSummary.rejected, (state, action) => {
        state.loading = false;
        state.error = action.error.message;
      });
  },
});

export default investmentsSlice.reducer;
