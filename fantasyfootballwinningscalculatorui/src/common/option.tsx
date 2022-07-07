import React from "react";

export interface SelectOptionProps {
  id: string;
  label: string;
}

function SelectOption(props: SelectOptionProps) {
  return (
    <option key={props.id} value={props.id}>
      {props.label}
    </option>
  );
}

export default SelectOption;
