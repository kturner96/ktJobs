import { useDisclosure } from '@mantine/hooks';
import type { JobListing } from '../Types';
import { Modal } from '@mantine/core';

type Props = {
  job: JobListing;
};

export default function StatusModal({ job }: Props) {
  const [opened, { open, close }] = useDisclosure(false);

  return (
    <>
      <Modal opened={opened} onClose={close} centered>
        <div>
          <h1>Update Status for {job.title}</h1>
          <p>Current status is {job.status}</p>
        </div>
      </Modal>
    </>
  );
}
