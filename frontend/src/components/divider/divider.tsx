import styles from './divider.module.scss';

interface DividerProps {
  direction?: 'vertical' | 'horizontal';
}

export default function Divider({ direction='horizontal' }: DividerProps) {
  return (
    <div className={`${styles.divider} ${direction}`} />
  );
}
