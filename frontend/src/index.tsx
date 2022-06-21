import React from 'react';
import ReactDOM from 'react-dom/client';
import ThemeProvider from 'providers/theme-provider';
import App from './app';
import './styles.scss';

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(
  <React.StrictMode>
    <ThemeProvider>
      <App />
    </ThemeProvider>
  </React.StrictMode>
);
