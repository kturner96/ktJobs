import { useEffect, useState } from 'react';

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
    <div>
      <div>
        {jobs.map((job) => (
          <div key={job.jobId}>
            <h1>{job.title}</h1>
            <h2>{job.company}</h2>
            <h3>{job.location}</h3>
          </div>
        ))}
      </div>
      {fetchError && <p>{fetchError}</p>}
    </div>
  );
}
