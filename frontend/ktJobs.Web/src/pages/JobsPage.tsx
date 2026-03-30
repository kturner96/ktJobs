import { useEffect, useState } from 'react';
import JobCard from '../components/JobCard';
import { Grid, ScrollArea } from '@mantine/core';

type JobListing = {
  jobId: number;
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

  useEffect(() => {
    const fetchJobs = async () => {
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
      }
    };
    fetchJobs();
  }, []);

  return (
    <div className='h-screen'>
      <Grid>
        <Grid.Col span={4}>
          <ScrollArea.Autosize mah={900} type='never'>
            {jobs.map((job: JobListing) => (
              <div key={job.jobId} onClick={() => setSelectedJob(job)}>
                <JobCard job={job} />
              </div>
            ))}
          </ScrollArea.Autosize>
        </Grid.Col>
        <Grid.Col span={4}>
          <div>
            <div className='border rounded-xl p-4'>
              {selectedJob ? (
                <div>
                  <h1>{selectedJob.title}</h1>
                  <h2>{selectedJob.location}</h2>
                  <h2>{selectedJob.company}</h2>
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
