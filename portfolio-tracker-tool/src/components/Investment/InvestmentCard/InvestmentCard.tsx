interface CardProps {
  id: number;
  name: string;
  assetType: string;
  totalValue: number;
}

export const InvestmentCard = ({ investment }: { investment: CardProps }) => {
  const fields = [
    { label: "Name", value: investment.name },
    { label: "Type of Asset", value: investment.assetType },
    {
      label: "Value",
      value: `$${investment.totalValue.toLocaleString()}`,
    },
  ];

  return (
    <div key={investment.id} className="p-4 bg-white rounded-xl space-y-2">
      {fields.map((field) => (
        <div key={field.label} className="flex gap-1">
          <span className="font-bold">{field.label}:</span>
          <span className="text-gray-700">{field.value}</span>
        </div>
      ))}
    </div>
  );
};
