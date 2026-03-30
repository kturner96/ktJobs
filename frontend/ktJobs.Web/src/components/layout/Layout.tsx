import { Outlet } from 'react-router';
import Header from './Header';

export default function Layout() {
  return (
    <>
      <header>
        <Header />
      </header>
      <main className='p-10 items-center text-center'>
        <Outlet />
      </main>
    </>
  );
}
