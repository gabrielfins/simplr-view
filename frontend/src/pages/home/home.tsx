import { useState } from 'react';
import { MdLightMode, MdDarkMode, MdVisibility, MdVisibilityOff } from 'react-icons/md';
import { useTitle } from 'hooks/use-title';
import { useTheme } from 'hooks/use-theme';
import FormField from 'components/form-field/form-field';
import IconButton from 'components/icon-button/icon-button';

export default function Home() {
  useTitle('Simplr View • Vendas');
  const { theme, setTheme } = useTheme();
  const [showPassword, setShowPassword] = useState(false);

  function toggleTheme() {
    if (theme.theme === 'dark') {
      setTheme({ theme: 'light' });
    } else if (theme.theme === 'light') {
      setTheme({ theme: 'dark' });
    }
  }

  return (
    <main>
      <FormField>
        <FormField.Label htmlFor="teste">Senha</FormField.Label>
        <FormField.Input type={showPassword ? 'text' : 'password'} id="teste" placeholder="Senha" />
        <FormField.Icon>
          <IconButton onClick={() => setShowPassword(c => !c)}>
            {showPassword && <MdVisibility fontSize="2.4rem" />}
            {!showPassword && <MdVisibilityOff fontSize="2.4rem" />}
          </IconButton>
        </FormField.Icon>
      </FormField>
      <IconButton onClick={toggleTheme}>
        {theme.theme === 'light' && <MdLightMode fontSize="2.4rem" />}
        {theme.theme === 'dark' && <MdDarkMode fontSize="2.4rem" />}
      </IconButton>
    </main>
  );
}
