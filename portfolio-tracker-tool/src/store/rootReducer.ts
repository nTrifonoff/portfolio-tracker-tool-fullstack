import { combineReducers } from "@reduxjs/toolkit";
import { investmentsReducer } from "./investments";

const rootReducer = combineReducers({
  investments: investmentsReducer,
});

export default rootReducer;
