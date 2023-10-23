import { Routes, Route } from 'react-router-dom';
import { HomeLayout } from './layouts/home-layout/home-layout';
import { Home } from './pages/home/home';

export function Router() {
  return (
    <Routes>
      <Route path="/" element={<HomeLayout />}>
        <Route path="/" element={<Home />} />
      </Route>
    </Routes>
  );
}
