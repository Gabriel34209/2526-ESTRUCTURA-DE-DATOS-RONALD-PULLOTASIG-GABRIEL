library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

entity tb_compuerta_and is
-- Un testbench no tiene puertos (está vacío)
end tb_compuerta_and;

architecture sim of tb_compuerta_and is
    signal a, b, y : std_logic; -- Señales de prueba
begin
    -- Conectamos el componente real
    UUT: entity work.compuerta_and port map (a => a, b => b, y => y);

    process
    begin
        -- Caso 1: 0 and 0
        a <= '0'; b <= '0'; wait for 10 ns;
        -- Caso 2: 0 and 1
        a <= '0'; b <= '1'; wait for 10 ns;
        -- Caso 3: 1 and 0
        a <= '1'; b <= '0'; wait for 10 ns;
        -- Caso 4: 1 and 1
        a <= '1'; b <= '1'; wait for 10 ns;
        wait;
    end process;
end sim;