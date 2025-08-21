import { useAppSelector } from "../../../hooks";
import { InvestmentCard } from "../InvestmentCard";

export const InvestmentTable = () => {
  const investments = useAppSelector((state) => state.investments.items);

  return (
    <div className="grid grid-cols-4 gap-5 mt-6">
      {investments.map((investment) => (
        <InvestmentCard investment={investment} />
      ))}
    </div>
  );
};
