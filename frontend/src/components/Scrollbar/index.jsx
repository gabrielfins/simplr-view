import styles from './scrollbar.module.scss';

export default function Scrollbar(props) {
    
    return (
        <div className={styles.scrollbar}>
            {props.hasButtons && <button className={`${styles.scrollBtn} ${styles.scrollUpBtn}`}></button> }
            <div className={styles.scrollTrack}>
                <button className={styles.scroll}></button>
            </div>
            {props.hasButtons && <button className={`${styles.scrollBtn} ${styles.scrollUpBtn}`}></button>}
        </div>
    );
}