import { Button as MantineButton } from '@mantine/core';

export default function Button({ buttonText }: { buttonText: string }) {
  return (
    <div>
      <MantineButton onClick={alert}>
        <p className='underline'>{buttonText}</p>
      </MantineButton>
    </div>
  );
}
