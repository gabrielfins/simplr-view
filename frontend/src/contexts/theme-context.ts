import { createContext } from 'react';
import { Theme } from 'interfaces/theme';

interface ThemeContextType {
  theme: Theme,
  setTheme: (theme: Partial<Theme>) => void;
}

export const ThemeContext = createContext<ThemeContextType>({} as ThemeContextType);
