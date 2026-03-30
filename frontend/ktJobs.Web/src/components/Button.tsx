import { Button as MantineButton } from '@mantine/core';
import { Link } from 'react-router';

type Props = {
  buttonText: string;
  url: string;
  onClick?: () => void;
};

export default function Button({ buttonText, url, onClick }: Props) {
  return (
    <div>
      <MantineButton onClick={onClick}>
        <Link to={url}>
          <p>{buttonText}</p>
        </Link>
      </MantineButton>
    </div>
  );
}
