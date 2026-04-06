library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL; -- Esta librería permite hacer sumas matemáticas

entity sumador_2bits is
    Port ( a : in  STD_LOGIC_VECTOR (1 downto 0);
           b : in  STD_LOGIC_VECTOR (1 downto 0);
           suma : out STD_LOGIC_VECTOR (2 downto 0));
end sumador_2bits;

architecture Behavioral of sumador_2bits is
begin
    -- Sumamos a y b convirtiéndolos a números sin signo
    suma <= std_logic_vector(unsigned('0' & a) + unsigned('0' & b));
end Behavioral;