import { BrowserRouter, Routes, Route } from 'react-router-dom';
import HomeLayout from 'layouts/home-layout/home-layout';
import Home from 'pages/home/home';
import Customers from 'pages/customers/customers';
import Employees from 'pages/employees/employees';
import Suppliers from 'pages/suppliers/suppliers';
import Products from 'pages/products/products';
import SalesHistory from 'pages/sales-history/sales-history';
import Settings from 'pages/settings/settings';
import Login from 'pages/login/login';

export default function Router() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<HomeLayout />}>
          <Route index element={<Home />} />
          <Route path="customers" element={<Customers />} />
          <Route path="employees" element={<Employees />} />
          <Route path="suppliers" element={<Suppliers />} />
          <Route path="products" element={<Products />} />
          <Route path="sales-history" element={<SalesHistory />} />
          <Route path="settings" element={<Settings />} />
        </Route>
        <Route path="/login" element={<Login />} />
      </Routes>
    </BrowserRouter>
  );
}
