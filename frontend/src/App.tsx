import { useTheme } from 'hooks/use-theme';
import { useEffect } from 'react';
import Router from './router';

export default function App() {
  const { theme } = useTheme();

  useEffect(() => {
    document.body.classList.add(theme.theme, theme.color)

    return () => {
      document.body.classList.remove(theme.theme, theme.color);
    }
  }, [theme]);

  return (
    <Router />
  );
}
