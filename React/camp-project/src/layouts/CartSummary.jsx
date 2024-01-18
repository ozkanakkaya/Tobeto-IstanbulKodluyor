import React from "react";
import { NavLink } from "react-router-dom";
import { Dropdown, DropdownDivider } from "semantic-ui-react";

export default function CartSummary() {
  return (
    <div>
      <Dropdown item text="Sepetiniz">
        <Dropdown.Menu>
          <Dropdown.Item>Asus Laptop</Dropdown.Item>
          <Dropdown.Item>MSI Laptop</Dropdown.Item>
          <Dropdown.Item>Lenovo Laptop</Dropdown.Item>
          <Dropdown.Divider/>
          <Dropdown.Item as={NavLink} to="/cart">Sepete Git</Dropdown.Item>
        </Dropdown.Menu>
      </Dropdown>
    </div>
  );
}
