
using System;
using System.Collections.Generic;

namespace 学生管理系统
{

    public class Class
    {
        private string name;

        /*
         *  学生人数
         */
        private int amount;
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        public Class(string name)
        {
            this.name = name;
            amount = 0;
        }

        public string getName()
        {
            return name;
        }

        public int getAmount()
        {
            return amount;
        }

        public bool addStudent(Student student)
        {
            if (!students.ContainsKey(student.getName()))
            {
                students.Add(student.getName(), student);
                amount++;
                return true;
            }

            return false;
        }

        /**
         *  根据学生名字来获取学生信息
         *
         *  若没有该学生，则返回null 
         */
        public Student getStudentByName(string name)
        {
            Student student;
            if (students.TryGetValue(name, out student))
            {
                return student;
            }

            return null;
        }

        public bool deleteStudentByName(string name)
        {
            return students.Remove(name);
        }

        public Dictionary<string, Student> getAllStudents()
        {
            return students;
        }

        public double[,] showAllScore()
        {
            double[,] scores = new double[amount, 3];

            int i = 0;

            foreach (var student in students)
            {
                scores[i, 0] = student.Value.getChinese().getScore();
                scores[i, 1] = student.Value.getMathematics().getScore();
                scores[i++, 2] = student.Value.getEnglish().getScore();
            }

            return scores;
        }

        public double[] showAverages()
        {
            double averageCh, averageMa, averageEn;

            double[,] scores = showAllScore();

            double sumCh, sumMa, sumEn;
            sumCh = sumMa = sumEn = 0;
            /*
             *  计算平均分
             */
            for (int i = 0; i < amount; i++)
            {
                sumCh += scores[i, 0];
                sumMa += scores[i, 1];
                sumEn += scores[i, 2];
            }

            averageCh = sumCh / amount;
            averageMa = sumMa / amount;
            averageEn = sumEn / amount;

            return new double[] { averageCh, averageMa, averageEn };
        }

        public double[] showVariance()
        {
            double varianceCh, varianceMa, varianceEn;

            double[,] scores = showAllScore();

            double[] averages = showAverages();

            double sumCh, sumMa, sumEn;
            sumCh = sumMa = sumEn = 0;

            for (int i = 0; i < amount; i++)
            {
                sumCh += Math.Pow((scores[i, 0] - averages[0]), 2);
                sumMa += Math.Pow((scores[i, 1] - averages[1]), 2);
                sumEn += Math.Pow((scores[i, 2] - averages[2]), 2);
            }

            varianceCh = sumCh / amount;
            varianceMa = sumMa / amount;
            varianceEn = sumEn / amount;

            return new double[] { varianceCh, varianceMa, varianceEn };
        }

        public double[] showRange()
        {
            double[,] scores = showAllScore();

            double rangeCh, rangeMa, rangeEn;

            double maxScoreCh, maxScoreMa, maxScoreEn, minScoreCh, minScoreMa, minScoreEn;
            maxScoreCh = minScoreCh = scores[0, 0];
            maxScoreMa = minScoreMa = scores[0, 1];
            maxScoreEn = minScoreEn = scores[0, 2];

            for (int i = 0; i < amount; i++)
            {
                if (scores[i, 0] > maxScoreCh)
                {
                    maxScoreCh = scores[i, 0];
                }
                else if (scores[i, 0] < minScoreCh)
                {
                    minScoreCh = scores[i, 0];
                }

                if (scores[i, 1] > maxScoreMa)
                {
                    maxScoreMa = scores[i, 1];
                }
                else if (scores[i, 1] < minScoreMa)
                {
                    minScoreMa = scores[i, 1];
                }

                if (scores[i, 2] > maxScoreEn)
                {
                    maxScoreEn = scores[i, 2];
                }
                else if (scores[i, 2] < minScoreEn)
                {
                    minScoreEn = scores[i, 2];
                }
            }

            rangeCh = maxScoreCh - minScoreCh;
            rangeMa = maxScoreMa - minScoreMa;
            rangeEn = maxScoreEn - minScoreEn;

            return new double[] { rangeCh, rangeMa, rangeEn };
        }
    }
}
