import { ButtonHTMLAttributes } from 'react';
import styles from './button.module.scss';

interface ButtonProps extends ButtonHTMLAttributes<HTMLButtonElement> {
  variant?: 'outlined' | 'text';
}

export default function Button({ className, ...props }: ButtonProps) {
  return (
    <button className={`${styles.button}${props.variant ? ` ${props.variant}` : ''}${className ? ` ${className}` : ''}`} {...props} />
  );
}
