import { useState, ReactNode } from 'react';
import { Theme } from 'interfaces/theme';
import { ThemeContext } from 'contexts/theme-context';

interface ThemeProviderProps {
  children: ReactNode;
}

export default function ThemeProvider(props: ThemeProviderProps) {
  const [theme, setNewTheme] = useState<Theme>({theme: 'dark', color: 'blue'});

  function setTheme(newTheme: Partial<Theme>) {
    setNewTheme({ ...theme, ...newTheme });
  }

  return (
    <ThemeContext.Provider value={{ theme, setTheme }}>
      { props.children }
    </ThemeContext.Provider>
  );
}
