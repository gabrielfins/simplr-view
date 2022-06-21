import { useState, FormEvent } from 'react';
import { useNavigate } from 'react-router-dom';
import { MdVisibility, MdVisibilityOff } from 'react-icons/md';
import { ReactComponent as Logo } from 'assets/images/logo.svg';
import Button from 'components/button/button';
import Divider from 'components/divider/divider';
import FormField from 'components/form-field/form-field';
import IconButton from 'components/icon-button/icon-button';
import styles from './login.module.scss';

export default function Login() {
  const [login, setLogin] = useState('');
  const [password, setPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const navigate = useNavigate();

  function handleFormSubmit(e: FormEvent) {
    e.preventDefault();
    if (login === 'admin' && password === 'admin') {
      navigate('/');
    }
  }

  return (
    <div className={styles.login}>
      <aside className={styles.aside}>
        <Logo />
      </aside>
      <div className={styles.divider}>
        <Divider direction="vertical" />
      </div>
      <main className={styles.main}>
        <div className={styles.loginContainer}>
          <h1>Login</h1>
          <form className={styles.loginForm} onSubmit={handleFormSubmit}>
            <FormField>
              <FormField.Label htmlFor="login">Login</FormField.Label>
              <FormField.Input id="login" placeholder="Login" value={login} onChange={(e) => setLogin(e.target.value)} />
            </FormField>
            <FormField>
              <FormField.Label htmlFor="password">Senha</FormField.Label>
              <FormField.Input type={showPassword ? 'text' : 'password'} id="password" placeholder="Senha" value={password} onChange={(e) => setPassword(e.target.value)} />
              <FormField.Icon>
                <IconButton type="button" onClick={() => setShowPassword(c => !c)}>
                  {showPassword && <MdVisibility fontSize="2.4rem" />}
                  {!showPassword && <MdVisibilityOff fontSize="2.4rem" />}
                </IconButton>
              </FormField.Icon>
            </FormField>
            <Button className={styles.loginButton}>Entrar</Button>
          </form>
        </div>
      </main>
    </div>
  );
}
