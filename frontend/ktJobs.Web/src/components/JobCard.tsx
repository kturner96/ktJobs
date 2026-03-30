import { Card, Text, Stack, Group } from '@mantine/core';
import type { JobListing } from '../Types';

type Props = {
  job: JobListing;
  onClick?: () => void;
};

export default function JobCard({ job, onClick }: Props) {
  return (
    <Card
      shadow='sm'
      padding='md'
      radius='md'
      withBorder
      onClick={onClick}
      style={{ cursor: 'pointer' }}
    >
      <Stack gap={6}>
        <Text fw={600} size='lg'>
          {job.title}
        </Text>

        <div>
          <Group gap='xs'>
            <Text size='sm' c='dimmed'>
              {job.company}
            </Text>
            <Text size='sm' c='dimmed'>
              • {job.location}
            </Text>
          </Group>
        </div>

        <Text size='sm' lineClamp={2}>
          {job.description}
        </Text>

        {job.salary && (
          <Text size='sm' fw={500}>
            {job.salary}
          </Text>
        )}
      </Stack>
    </Card>
  );
}
