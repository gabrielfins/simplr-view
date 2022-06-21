import { ButtonHTMLAttributes } from 'react';
import styles from './icon-button.module.scss';

export default function IconButton(props: ButtonHTMLAttributes<HTMLButtonElement>) {
  return (
    <button className={styles.iconButton} {...props} />
  );
}