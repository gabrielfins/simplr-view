import { NavLink } from 'react-router-dom';
import styles from './navbar.module.scss';
import Logo from '../../images/simplr-view-icon@2x.png';
import { MdHome, MdPerson, MdAssignmentInd, MdAttachMoney, MdSettings, MdInfoOutline } from 'react-icons/md';
import { FaTruck } from 'react-icons/fa';

export default function Navbar() {
    return (
        <nav className={styles.navbar}>
            <div className={styles.logoContainer}>
                <img className={styles.logo} src={ Logo } alt="logo" draggable={ false }/>
            </div>
            <div className={styles.navLinks}>
                <NavLink className={styles.navLink} exact to="/"><MdHome className={styles.linkIcon} size="2.4rem" />Início</NavLink>
                <NavLink className={styles.navLink} to="/clients"><MdPerson className={styles.linkIcon} size="2.4rem" />Clientes</NavLink>
                <NavLink className={styles.navLink} to="/suppliers"><FaTruck className={styles.linkIcon} size="2.4rem" />Fornecedores</NavLink>
                <NavLink className={styles.navLink} to="/employees"><MdAssignmentInd className={styles.linkIcon} size="2.4rem" />Funcionários</NavLink>
                <NavLink className={styles.navLink} to="/sales"><MdAttachMoney className={styles.linkIcon} size="2.4rem" />Vendas</NavLink>
                <div className={styles.bottomLinks}>
                    <NavLink className={styles.navLink} to="/options"><MdSettings className={styles.linkIcon} size="2.4rem" />Opções</NavLink>
                    <NavLink className={styles.navLink} to="/about"><MdInfoOutline className={styles.linkIcon} size="2.4rem" />Sobre</NavLink>
                </div>
            </div>
        </nav>
    );
}
