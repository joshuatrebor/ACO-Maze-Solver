using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ACO_Maze_Solver {
    class ACO {
        private int[,] mazeMatrix;
        private double[,] solnMatrix;
        private int[] nest = new int[2];
        private List<int[]> food = new List<int[]>();
        private List<Ant> colony = new List<Ant>();
        private double evaporationRate;
        public static Random rnd = new Random();
        public static int maxPath = 0;
        

        public ACO(int[,] mazeMatrix, int antCount, double evaporationRate) {
            this.mazeMatrix = (int[,])mazeMatrix.Clone();
            init_soln();
            for (int i = 0; i < antCount; i++)
                colony.Add(new Ant(nest[0], nest[1], food, nest, solnMatrix));
            this.evaporationRate = evaporationRate;
            ACO.maxPath = 0;
        }

        private void init_soln() {
            //copy mazeMatrix to solnMatrix
            solnMatrix = new double[mazeMatrix.GetLength(0),mazeMatrix.GetLength(1)];
            List<int[]> nestValues = new List<int[]>();
            for (int y = 0; y < mazeMatrix.GetLength(0); y++) {
                for (int x = 0; x < mazeMatrix.GetLength(1); x++) {
                    if (mazeMatrix[y, x] == 4) {
                        solnMatrix[y, x] = -4;
                        int[] pos = new int[] { y, x };
                        nestValues.Add(pos);
                    } else if (mazeMatrix[y, x] == 5) {
                        solnMatrix[y, x] = -5;
                        food.Add(new int[] { y, x });
                    } else if (mazeMatrix[y, x] == 0)
                        solnMatrix[y, x] = 0;
                    else
                        solnMatrix[y, x] = 1;
                }
            }
            //get nest
            int sum_x = 0;
            int sum_y = 0;
            foreach (int[] pos in nestValues) {
                sum_x += pos[1];
                sum_y += pos[0];
            }
            int[] nest = new int[]{sum_y / nestValues.Count,sum_x / nestValues.Count};
            this.nest = nest;
        }
        public void disp_soln() {
            for (int y = 0; y < solnMatrix.GetLength(0); y++) {
                for (int x = 0; x < solnMatrix.GetLength(1); x++) {
                    Console.Write(solnMatrix[y, x]+" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Nest Y:" + nest[0] + "  X:" + nest[1]);
        }

        public void step_time(int timeStep, out int[,] mazeMatrix, out double[,] solnMatrix) {
            for (int i = 0; i < timeStep; i++) { 
                foreach(Ant ant in colony){
                    this.mazeMatrix[ant.y_pos, ant.x_pos] = 1;
                    ant.move(get_adjacent_pos(ant.y_pos,ant.x_pos));
                    this.mazeMatrix[ant.y_pos, ant.x_pos] = ant.backward_mode?3:2;
                }
                evaporate();
            }

            this.mazeMatrix[nest[0], nest[1]] = 4;
            this.solnMatrix[nest[0], nest[1]] = -4;
            foreach (int[] f in food) {
                this.mazeMatrix[f[0], f[1]] = 5;
                this.solnMatrix[f[0], f[1]] = -5;
            }

            mazeMatrix = this.mazeMatrix;
            solnMatrix = this.solnMatrix;
        }

        public double[] get_adjacent_pos(int y_pos, int x_pos) {
            double[] adj_pos = new double[4];

            adj_pos[0] = solnMatrix[y_pos - 1, x_pos]>=0?solnMatrix[y_pos - 1, x_pos]:1;
            adj_pos[1] = solnMatrix[y_pos + 1, x_pos]>=0?solnMatrix[y_pos + 1, x_pos]:1;
            adj_pos[2] = solnMatrix[y_pos, x_pos - 1]>=0?solnMatrix[y_pos, x_pos - 1]:1;
            adj_pos[3] = solnMatrix[y_pos, x_pos + 1]>=0?solnMatrix[y_pos, x_pos + 1]:1;


            return adj_pos;
        }

        public void evaporate() {
            for (int i = 0; i < solnMatrix.GetLength(0); i++) {
                for (int j = 0; j < solnMatrix.GetLength(1); j++) {
                    if (solnMatrix[i, j] > 1) {
                        solnMatrix[i, j] = solnMatrix[i,j]*(1-evaporationRate); //Evaporation
                        if (solnMatrix[i, j] == -1 || (solnMatrix[i,j] < 1 && solnMatrix[i,j] > 0))
                            solnMatrix[i, j] = 1;
                    }
                }
            }
        }

        public void show_ants() {
            foreach (Ant ant in colony) { 
                Console.WriteLine(ant.x_pos + " " + ant.x_pos);
            }
        }
    }

    class Ant {
        public int y_pos;
        public int x_pos;
        public double p_density;
        public bool backward_mode;
        private int m = -1;
        private int prev_m = -1;
        private List<int[]> food;
        private int[] nest;
        private double[,] solnMatrix;
        private double pheromone;

        public List<int[]> path = new List<int[]>();

        public Ant(int y_pos, int x_pos, List<int[]> food, int[] nest, double[,] solnMatrix) {
            this.x_pos = x_pos;
            this.y_pos = y_pos;
            p_density = 0;
            backward_mode = false;
            this.food = food;
            this.nest = nest;
            this.solnMatrix = solnMatrix;
        }

        public void move(double[] moves) {
            if (m == -1 || moves.Average() != moves[0] || ACO.rnd.Next(100) >= 80) {
                List<int> possibleMoves = new List<int>();
                for (int i = 0; i < 4; i++) {
                    int proba = (int)Math.Floor(Math.Pow(moves[i],2) / Math.Pow((moves[0] + moves[1] + moves[2] + moves[3]),2) * 100);
                    if (i == 0 && prev_m == 1)
                        proba = 0;
                    else if (i == 1 && prev_m == 0)
                        proba = 0;
                    else if (i == 2 && prev_m == 3)
                        proba = 0;
                    else if (i == 3 && prev_m == 2)
                        proba = 0;
                    for (int j = 0; j < proba; j++) {
                        possibleMoves.Add(i);
                    }
                }
                if (possibleMoves.Count == 0) {
                    if (prev_m == 1)
                        m = 0;
                    else if (prev_m == 0)
                        m = 1;
                    else if (prev_m == 2)
                        m = 3;
                    else if (prev_m == 3)
                        m = 2;
                }
                else
                    m = possibleMoves.ElementAt(ACO.rnd.Next(possibleMoves.Count));
            }
            if (!backward_mode) {
                if (m == 0)
                    y_pos--;
                else if (m == 1)
                    y_pos++;
                else if (m == 2)
                    x_pos--;
                else if (m == 3)
                    x_pos++;
                path.Add(new int[] { y_pos, x_pos });
                prev_m = m;
            } 
            else {
                solnMatrix[y_pos, x_pos] += pheromone; //Add Pheromone
                if (path.Count > 0) {
                    y_pos = path.ElementAt(path.Count - 1)[0];
                    x_pos = path.ElementAt(path.Count - 1)[1];
                    path.RemoveAt(path.Count - 1);
                } 
                else {
                    backward_mode = false;    
                }
            }
            check_food_nest();
        }

        public void check_food_nest() {
            foreach (int[] f in food) {
                if (y_pos == f[0] && x_pos == f[1]) {
                    backward_mode = true;
                    shorten_path();
                    //ACO.maxPath = path.Count > ACO.maxPath ? path.Count : ACO.maxPath;
                    //pheromone = path.Count * 10000 / ACO.maxPath; //Compute Pheromone
                    pheromone = 1000 / (path.Count+1);
                }
            }
            if (y_pos == nest[0] && x_pos == nest[1])
                backward_mode = false;
        }

        public void shorten_path(){
            for (int i = 0; i < path.Count; i++) {
                for (int j = path.Count - 1; j >= 0; j--) {
                    if (path.ElementAt(i)[0] == path.ElementAt(j)[0] && path.ElementAt(i)[1] == path.ElementAt(j)[1] && j > i) {
                        path.RemoveRange(i + 1, j - i);
                        break;
                    }
                }
            }
        }

    }
}
