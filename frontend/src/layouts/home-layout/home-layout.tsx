import { Outlet } from 'react-router-dom';
import Navbar from 'components/navbar/navbar';
import styles from './home-layout.module.scss';

export default function HomeLayout() {
  return (
    <div className={styles.homeLayout}>
      <Navbar />
      <Outlet />
    </div>
  );
}
