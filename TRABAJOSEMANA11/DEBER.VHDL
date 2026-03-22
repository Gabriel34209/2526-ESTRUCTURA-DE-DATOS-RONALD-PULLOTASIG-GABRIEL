library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Entidad del Semisumador
entity HalfAdder is
    Port ( a, b : in STD_LOGIC;
           s, c : out STD_LOGIC);
end HalfAdder;

architecture Behavioral of HalfAdder is
begin
    s <= a xor b; -- Suma parcial
    c <= a and b; -- Acarreo parcial
end Behavioral;