import { Link } from 'react-router';

export default function Header() {
  return (
    <>
      <div className='flex flex-row justify-center items-center p-4'>
        <div className='flex flex-row gap-4'>
          <Link to='/'>Home</Link>
          <Link to='/jobs'>Jobs</Link>
        </div>
      </div>
    </>
  );
}
