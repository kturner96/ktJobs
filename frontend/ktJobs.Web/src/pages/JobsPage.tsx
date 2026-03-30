import { useEffect, useState } from 'react';
import JobCard from '../components/JobCard';
import { Grid, ScrollArea, Space, Modal, LoadingOverlay } from '@mantine/core';
import Button from '../components/Button';

type JobListing = {
  id: number;
  title: string;
  description: string;
  status: string;
  company: string;
  location: string;
  salary: string;
  url: string;
};

export default function JobsPage() {
  const [jobs, setJobs] = useState<JobListing[]>([]);
  const [fetchError, setFetchError] = useState('');
  const [selectedJob, setSelectedJob] = useState<JobListing | null>(null);
  const [opened, setOpened] = useState(false);
  const [isUpdating, setIsUpdating] = useState(false);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    const fetchJobs = async () => {
      setIsLoading(true);
      try {
        const response = await fetch('http://localhost:5027/api/jobs');

        if (!response.ok) {
          setFetchError('Error fetching jobs.');
          return;
        }

        const data = await response.json();
        setJobs(data);
        setFetchError('');
      } catch {
        setFetchError('Something went wrong.');
      } finally {
        setIsLoading(false);
      }
    };
    fetchJobs();
  }, []);

  const updateJobStatus = async (jobId: number, newStatus: string) => {
    setIsUpdating(true);
    try {
      const response = await fetch(
        `http://localhost:5027/api/jobs/${jobId}/status`,
        {
          method: 'PATCH',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({ Status: newStatus }),
        },
      );

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Server Error Detail:', errorText);
        throw Error('Failed to update status');
      }
      const updatedJob = await response.json(); // Your backend returns the job object

      setJobs((prevJobs) =>
        prevJobs.map((job) => (job.id === jobId ? updatedJob : job)),
      );
      setSelectedJob(updatedJob);
      setOpened(false);
    } catch (err) {
      console.error(err);
    } finally {
      setIsUpdating(false);
    }
  };

  return (
    <div className='h-screen'>
      <Grid>
        <Grid.Col span={4}>
          {isLoading ? (
            <LoadingOverlay />
          ) : (
            <ScrollArea.Autosize mah={900} type='never'>
              {jobs.map((job: JobListing) => (
                <div key={job.id} onClick={() => setSelectedJob(job)}>
                  <JobCard job={job} />
                </div>
              ))}
            </ScrollArea.Autosize>
          )}
        </Grid.Col>
        <Grid.Col span={4}>
          <div>
            <div className='border rounded-xl p-4'>
              {selectedJob ? (
                <div className='flex flex-col items-center'>
                  <div>
                    <section>
                      <h1 className='text-2xl font-bold'>
                        {selectedJob.title}
                      </h1>
                    </section>
                    <section className='flex flex-row justify-center'>
                      <h2>{selectedJob.location}</h2>
                      <Space w='lg' />
                      <p>|</p>
                      <Space w='lg' />
                      <h2>{selectedJob.company}</h2>
                    </section>
                    <p>{selectedJob.salary}</p>
                  </div>
                  <div className='my-10'>{selectedJob.description}</div>
                  <div className='flex flex-row gap-6'>
                    <Button
                      buttonText='Original Posting'
                      url={selectedJob.url}
                    />
                    <Button
                      buttonText='Update Status'
                      url='#'
                      onClick={() => {
                        setOpened(true);
                      }}
                    />
                  </div>
                  <Modal
                    opened={opened}
                    onClose={() => setOpened(false)}
                    centered
                    title='Update Status'
                  >
                    {selectedJob && (
                      <div>
                        <h1 className='text-lg font-semibold'>
                          Update Status for {selectedJob.title}
                        </h1>
                        <p className='text-sm text-gray-500'>
                          Current status: {selectedJob.status}
                        </p>
                        <Button
                          buttonText='Applied'
                          url='#'
                          isUpdating
                          onClick={() => {
                            if (selectedJob?.id) {
                              updateJobStatus(selectedJob.id, 'Applied');
                            } else {
                              console.error('No Job ID found!');
                            }
                          }}
                        />
                      </div>
                    )}
                  </Modal>
                </div>
              ) : (
                <p>Select a job</p>
              )}
            </div>
          </div>
        </Grid.Col>
      </Grid>

      {fetchError && <p>{fetchError}</p>}
    </div>
  );
}
