import '@mantine/core/styles.css';

import { MantineProvider } from '@mantine/core';
import { BrowserRouter } from 'react-router';
import Button from './components/Button';

export default function App() {
  return (
    <BrowserRouter>
      <MantineProvider>
        <Button />
      </MantineProvider>
    </BrowserRouter>
  );
}
