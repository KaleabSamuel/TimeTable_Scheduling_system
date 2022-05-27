using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System
{
    class GeneticAlgorithm
    {
        BatchCourseTeacher[] batchCourse;
        Schedule[] timeTable;
        Room[] rooms;
        DayTime[] dayTime;
        Unavailable[] unavailable;
        Random rnd;
        Schedule fittest, secondFittest;
        int populationSize = 200;
       public GeneticAlgorithm()
        {
        batchCourse = BatchCourseTeacher.getBatchCourses();
        dayTime = DayTime.getDayTime();
        unavailable = Unavailable.getUnavailable();
        rooms = Room.getRooms();
        timeTable = new Schedule[populationSize];
        rnd = new Random();
        }

        public void generatePopulation()
        {
            Class tmp = null;
            int rndDayTimeIndex;
            for(int i=0; i<populationSize; i++)
            {
                timeTable[i] = new Schedule();
                for(int j=0; j<batchCourse.Length; j++)
                {
                    for (int k = 0; k < batchCourse[j].Times; k++)
                    {
                            rndDayTimeIndex = rnd.Next(dayTime.Length);
                            tmp = new Class(batchCourse[j].CCode, batchCourse[j].BName, dayTime[rndDayTimeIndex].DayID + "" + dayTime[rndDayTimeIndex].TimeID, rooms[rnd.Next(rooms.Length)].Name, batchCourse[j].Tid);
                            timeTable[i].Classes.Add(tmp);
                    }
                }
                setContradition(timeTable[i]);
                setFitness(timeTable[i]);
            }
        }

        public Schedule selectFittest()
        {
            List<Schedule> l = new List<Schedule>();
            for(int i=0; i<3; i++)
            l.Add(new Schedule(timeTable[rnd.Next(timeTable.Length)]));
            l.Sort((a, b) => (a.Contradiction.CompareTo(b.Contradiction)));
            return l[0];
        }

        public void crossOver()
        {
            Schedule offspring;
            for (int i = 1; i <populationSize; i++)
            {
                fittest = selectFittest();
                secondFittest = selectFittest();
                offspring = new Schedule();
                for (int j = 0; j < fittest.Classes.Count; j++)
                    if (rnd.Next(2) == 0)
                        offspring.Classes.Add(fittest.Classes[j]);
                    else
                        offspring.Classes.Add(secondFittest.Classes[j]);
                 timeTable[i] = offspring;
                
            }

        }
       public void mutate()
        {
            int rndIdx;
            for (int i = 1; i < populationSize; i++)
            {
                for (int j = 0; j < timeTable[i].Contradiction; j++)
                {
                    if (rnd.Next() % 7 > 5)
                    {
                        rndIdx = rnd.Next(rooms.Length);
                        timeTable[i].Classes[j].Room = rooms[rndIdx].Name;
                    }
                    if (rnd.Next() % 8 > 6)
                    {
                        rndIdx = rnd.Next(dayTime.Length);
                        timeTable[i].Classes[j].Schedule = dayTime[rndIdx].DayID+""+ dayTime[rndIdx].TimeID;
                    }
                }
                setContradition(timeTable[i]);
                setFitness(timeTable[i]);
            }
                
        }

        public void setFitness(Schedule a)
        {
            if (a.Contradiction == 0)
                a.Fitness = 1.0;
            else
                a.Fitness = 1.0 / (a.Contradiction+1);
        }

        void setContradition(Schedule a)
        {
            a.Contradiction = 0;
            for(int i=0; i<a.Classes.Count; i++)
            {
                for (int j = i; j < a.Classes.Count; j++)
                {
                    if (i == j)
                        continue;
                    else
                    {
                        if (a.Classes[i].Schedule == a.Classes[j].Schedule && a.Classes[j].Course == a.Classes[i].Course)
                        {
                            a.Contradiction++;
                        }
                        if (a.Classes[i].Schedule == a.Classes[j].Schedule && a.Classes[j].Tid == a.Classes[i].Tid)
                        {
                            a.Contradiction++;
                        }
                        if (a.Classes[i].Schedule == a.Classes[j].Schedule && a.Classes[j].Room == a.Classes[i].Room)
                        {
                            a.Contradiction++;
                        }
                    }
                }

                for(int j=0; j<unavailable.Length; j++)
                {
                    if(unavailable[j].TeacherID == a.Classes[i].Tid && a.Classes[i].Schedule== unavailable[j].DayID+""+ unavailable[j].TimeID)
                        a.Contradiction++;
                }
            }
        }
        
        public void display()
        {
            for(int i=0; i<populationSize; i++)
            {
                Console.WriteLine(timeTable[i].Contradiction + "\t" + timeTable[i].Fitness);
                for(int j=0; j<timeTable[i].Classes.Count; j++)
                {
                Console.WriteLine(timeTable[i].Classes[j].Batch + " " + timeTable[i].Classes[j].Course + " " + timeTable[i].Classes[j].Schedule + " " + timeTable[i].Classes[j].Room);
                }
                Console.WriteLine();
            }
        }
        
        public Schedule test()
        {
            generatePopulation();
            HeapSort.sort(timeTable);
            int generation = 0;
            //display();
             while (timeTable[0].Fitness < 1.0)
             {
                //generation++;
                crossOver();
                  mutate();
                 HeapSort.sort(timeTable);
                //Console.WriteLine("generation: "+ generation+"\tFittest: "+timeTable[0].Fitness);
                // display();
            }
            /*for (int j = 0; j < timeTable[0].Classes.Count; j++)
            {
                Console.WriteLine(timeTable[0].Classes[j].Batch + " " + timeTable[0].Classes[j].Course + " " + timeTable[0].Classes[j].Schedule + " " + timeTable[0].Classes[j].Room);
            }
            Console.ReadKey();*/

            return timeTable[0];
        }

    }
}
