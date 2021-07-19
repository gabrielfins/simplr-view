import { NavLink } from 'react-router-dom';
import { FaDollarSign, FaUserAlt, FaTruck, FaUserTie, FaCog, FaInfo } from 'react-icons/fa';
import logoImg from '../../images/simplr-view-logo.svg';
import s from './styles.module.scss';

export default function Navbar() {
    return (
        <nav className={s['navbar']}>
            <img src={logoImg} alt="Logo" />
            <div className={s['nav-links-container']}>
                <NavLink className={s['nav-link']} activeClassName="active" exact to="/"><FaDollarSign size="2rem" />Vendas</NavLink>
                <NavLink className={s['nav-link']} activeClassName="active" exact to="/clients"><FaUserAlt size="2rem" />Clientes</NavLink>
                <NavLink className={s['nav-link']} activeClassName="active" exact to="/suppliers"><FaTruck size="2rem" />Fornecedores</NavLink>
                <NavLink className={s['nav-link']} activeClassName="active" exact to="/employees"><FaUserTie size="2rem" />Funcionários</NavLink>
                <div>
                    <NavLink className={s['nav-link']} activeClassName="active" exact to="/options"><FaCog size="2rem" />Opções</NavLink>
                    <NavLink className={s['nav-link']} activeClassName="active" exact to="/about"><FaInfo size="2rem" />Sobre</NavLink>
                </div>
            </div>
        </nav>
    );
}
