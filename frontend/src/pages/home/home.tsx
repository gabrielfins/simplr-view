import { useState } from 'react';
import { MdVisibility, MdVisibilityOff } from 'react-icons/md';
import { useTitle } from 'hooks/use-title';
import FormField from 'components/form-field/form-field';
import IconButton from 'components/icon-button/icon-button';

export default function Home() {
  useTitle('Simplr View • Vendas');
  const [showPassword, setShowPassword] = useState(false);

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
    </main>
  );
}
