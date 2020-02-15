#include <pthread.h>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>


typedef struct phil

{
  	int Philoindex;
	pthread_t thread;
	pthread_mutex_t *fork_left, *fork_right;
	int MealProg;
	double hungryM0de_total;
	int hungryMode_times;
	int Threpriority;
} philosopher;



int philosophers;

const char * GetTime()
{
time_t rawtime;
rawtime = time(NULL);

return ctime(&rawtime);
}

int next(int i)
{
	int x = (i+1)%philosophers;
	if (x==0){x=philosophers;}
	return x;
}

int previous(int i)
{
	int x = (i-1)%philosophers;
	if (x==0){x=philosophers;}
	return x;
}

double hungry(int Philosopher,int hungryModeTimes,double hungryModeTotal)
{
	printf("Philosopher %d has been on READY(HUNGRY) mode for %f seconds on average! \n",Philosopher,(hungryModeTotal/hungryModeTimes) );
	return hungryModeTotal/hungryModeTimes;
}





void *Philo(void *p)
{
	philosopher *philo = (philosopher *)p;

	pthread_mutex_t *leftFork, *rightFork;
	int get_leftfork, get_rightfork;
	int exTime =0;
	time_t hungry_start,hungry_end;

	while (exTime< 20)
	{
		printf("Philosopher %d is thinking at: %s \n", philo->Philoindex,GetTime());

		sleep(1+ rand()%6);
		leftFork = philo->fork_left;
		rightFork = philo->fork_right;
		printf("Philosopher %d is hungry at %s  \n", philo->Philoindex,GetTime());
		hungry_start = time(NULL);
		get_leftfork = pthread_mutex_trylock(leftFork);
    	if (get_leftfork != 0)

    	{
		  printf("Philosopher %d failed to take fork %d ,because philosopher %d  was using it at: %s \n",philo->Philoindex,philo->Philoindex,previous(philo->Philoindex), GetTime());
    	pthread_mutex_lock(leftFork);

    	}
    	get_rightfork= pthread_mutex_trylock(rightFork);

    	if (get_rightfork != 0)

    	{
      	printf("Philosopher %d failed to take fork %d , cause philosopher %d was using it at: %s \n",philo->Philoindex,next(philo->Philoindex),next(philo->Philoindex),GetTime());
      	pthread_mutex_lock(rightFork);
    	}

    	hungry_end = time(NULL);
		philo->hungryM0de_total += difftime(hungry_end,hungry_start);
		philo->hungryMode_times++;
		printf("Philosopher %d is eating at: %s  \n",philo->Philoindex,GetTime());
		sleep(philo->Threpriority);
		exTime += philo->Threpriority;
		pthread_mutex_unlock(rightFork);
		pthread_mutex_unlock(leftFork);

 	}
	printf("Philosopher %d finished eating and is leaving the table at: %s \n",philo->Philoindex,GetTime());
	philo->MealProg = 1;

return NULL;
}


void Selector(int N)
{
	pthread_mutex_t forks[N];
	philosopher philosophers[N];
	philosopher *philo;
	int i;


	for (i =0; i< N ; i++)
	{
		pthread_mutex_init(&forks[i],NULL);
	}
	for (i =0; i< N; i++)
	{
		philo = &philosophers[i];
		philo->Philoindex = i+1;
		philo->fork_left = &forks[i];
		philo->fork_right = &forks[(i+1)%N];
		philo->MealProg = 0;
		philo->hungryM0de_total=0.0;
		philo->hungryMode_times=0;
		philo->Threpriority = rand()%3 +1;
		pthread_create(&philo->thread,NULL,Philo,philo);
	}
	int dining = 1;
	while (dining)
	{
		int c=0;
		for (i=0; i<N; i++)
		{
			philo = &philosophers[i];
			if(philo->MealProg){c +=1;}
		}
		if (c == N)
		{
			for (i=0; i<N; i++)
			{
				philo = &philosophers[i];
				pthread_join(philo->thread,NULL);
			}
			printf("All philosophers have finished! \n");
			double AllPhilosophersHungryTime;
			for (i=0; i<N; i++)
			{
				pthread_mutex_destroy(&forks[i]);
				philo = &philosophers[i];
				AllPhilosophersHungryTime +=hungry(philo->Philoindex,philo->hungryMode_times,philo->hungryM0de_total);
			}
			printf("The average time spent on READY(HUNGRY) mode for all philosophers is %f seconds! \n",(AllPhilosophersHungryTime/N));


			dining = 0;
		}
	}




}



int main()
{
	printf("THE DINING PHILOSOPHERS\n");
	printf("Enter the number of philosophers you'd like to test my code on(Number|n| has to be n>=3 and n<=10 : ");
	scanf ("%d",&philosophers);
	while(philosophers<3 || philosophers >10)
	{

		printf("Please enter a number between 3 and 10 as asked above: ");
		scanf ("%d",&philosophers);
		if (philosophers >=3 && philosophers <=10){break;}
	}

	Selector(philosophers);

	return 0;
}
