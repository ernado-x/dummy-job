# dummy-job

Dummy job which can run to configured period

# Build docker image

1. Go to directory ./src/Dummy.App
2. Run command `docker build --pull --rm -f Dockerfile -t dummyjob:latest .`
3. Run command `docker image tag dummyjob:latest ernadox/dummy-job:latest`
4. Run command `docker push ernadox/dummy-job:latest`
5. Run command `docker run -e "WORKING_TIME=5" -d dummyjob:latest`