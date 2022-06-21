import { ReactComponent as Logo } from 'assets/images/logo.svg';
import { ReactComponent as MdHome } from 'assets/icons/md-home.svg';
import { ReactComponent as MdAccount } from 'assets/icons/md-account.svg';
import { ReactComponent as MdEngineer } from 'assets/icons/md-engineer.svg';
import { ReactComponent as MdTruck } from 'assets/icons/md-truck.svg';
import { ReactComponent as MdArchive } from 'assets/icons/md-archive.svg';
import { ReactComponent as MdCurrency } from 'assets/icons/md-currency.svg';
import { ReactComponent as MdCog } from 'assets/icons/md-cog.svg';
import NavButton from 'components/nav-button/nav-button';
import styles from './navbar.module.scss';

export default function Navbar() {
  return (
    <nav className={styles.navbar}>
      <div className={styles.logoContainer}>
        <Logo />
      </div>
      <div className={styles.navLinks}>
        <NavButton to="/">
          <MdHome />
          <span>Início</span>
        </NavButton>
        <NavButton to="/customers">
          <MdAccount />
          <span>Clientes</span>
        </NavButton>
        <NavButton to="/employees">
          <MdEngineer />
          <span>Funcionários</span>
        </NavButton>
        <NavButton to="/suppliers">
          <MdTruck />
          <span>Fornecedores</span>
        </NavButton>
        <NavButton to="/products">
          <MdArchive />
          <span>Produtos</span>
        </NavButton>
        <NavButton to="/sales-history">
          <MdCurrency />
          <span>Histórico de Vendas</span>
        </NavButton>
        <NavButton to="/settings">
          <MdCog />
          <span>Configurações</span>
        </NavButton>
      </div>
    </nav>
  );
}
