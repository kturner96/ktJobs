import { Button as MantineButton } from '@mantine/core';
import { Link } from 'react-router';

type Props = {
  buttonText: string;
  url: string;
  onClick?: () => void;
  isUpdating: boolean;
};

export default function Button({
  buttonText,
  url,
  onClick,
  isUpdating,
}: Props) {
  return (
    <div>
      <MantineButton onClick={onClick} loading={false}>
        <Link to={url}>
          <p>{buttonText}</p>
        </Link>
      </MantineButton>
    </div>
  );
}
