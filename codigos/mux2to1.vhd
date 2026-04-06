library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

entity mux2to1 is
    Port ( d0   : in  STD_LOGIC;
           d1   : in  STD_LOGIC;
           sel  : in  STD_LOGIC;
           y    : out STD_LOGIC);
end mux2to1;

architecture Dataflow of mux2to1 is
begin
    -- Si sel es '0' pasa d0, si es '1' pasa d1
    y <= d0 when sel = '0' else d1;
end Dataflow;