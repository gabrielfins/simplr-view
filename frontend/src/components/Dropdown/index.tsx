import { forwardRef, ReactNode, ButtonHTMLAttributes } from 'react';
import './styles.scss';
import '@gabrielfins/ripple-effect';

type DropdownProps = {
    children: ReactNode | Array<ReactNode>;
}

export const Dropdown = forwardRef<HTMLDivElement, DropdownProps>((props, ref) => {
    return (
        <div ref={ref} className="dropdown">
            {props.children}
        </div>
    );
});

type DropdownButtonProps = ButtonHTMLAttributes<HTMLButtonElement>;

export function DropdownButton(props: DropdownButtonProps) {
    return (
        <button type="button" className="md-ripples dropdown-button" {...props}>{props.children}</button>
    );
}

export function DropdownDivider() {
    return (
        <div className="dropdown-divider"></div>
    );
}
