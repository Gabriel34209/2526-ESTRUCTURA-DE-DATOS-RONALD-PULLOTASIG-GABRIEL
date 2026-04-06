library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

entity compuerta_and is
    Port ( a : in  STD_LOGIC;
           b : in  STD_LOGIC;
           y : out STD_LOGIC);
end compuerta_and;

architecture Behavioral of compuerta_and is
begin
    y <= a and b;
end Behavioral;