import { NavLink, NavLinkProps } from 'react-router-dom';
import styles from './nav-button.module.scss';


export default function NavButton(props: NavLinkProps) {
  return (
    <NavLink className={({ isActive }) => `${styles.navButton}${isActive ? ' active' : ''}`} {...props} />
  );
}
