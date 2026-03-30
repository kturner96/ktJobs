import '@mantine/core/styles.css';

import { MantineProvider } from '@mantine/core';
import { BrowserRouter } from 'react-router';
import { Route, Routes } from 'react-router';
import Home from './pages/Home';
import Layout from './components/layout/Layout';
import JobsPage from './pages/JobsPage';

export default function App() {
  return (
    <BrowserRouter>
      <MantineProvider defaultColorScheme='dark'>
        <Routes>
          <Route path='/' element={<Layout />}>
            <Route index element={<Home />} />
            <Route path='jobs' element={<JobsPage />} />
          </Route>
        </Routes>
      </MantineProvider>
    </BrowserRouter>
  );
}
