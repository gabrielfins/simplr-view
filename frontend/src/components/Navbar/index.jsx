import { NavLink } from 'react-router-dom';

export default function Navbar() {
    return (
        <nav className="sidebar">
            <div className="logo-container">
                <img className="logo" src="" alt=""/>
            </div>
            <div className="nav-links">
                <NavLink exact to="/">Início</NavLink>
                <NavLink exact to="/">Início</NavLink>
                <NavLink exact to="/">Início</NavLink>
            </div>
        </nav>
    );
}