using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class SGAChromosome
    {
        private BitArray chromosomeBit;

        public BitArray ChromosomeBit
        {
            get { return chromosomeBit; }
        }

        protected static Random rand = new Random((int)DateTime.Now.Ticks);

        public SGAChromosome(int length)
        {
            chromosomeBit = new BitArray(length);
        }

        public void GenerateRandomChromosome()
        {
            for (int i = 0; i < chromosomeBit.Length; i++)
            {
                chromosomeBit[i] = rand.NextDouble() > 0.5;
            }
        }

        public void GenerateChromosomeFromInt(int numeral)
        {
            this.chromosomeBit = new BitArray(new[] { numeral });
        }

        public void CreateChromosomeFromCrossing(SGAChromosome parentLeft, SGAChromosome parentRight)
        {
            int position = rand.Next(0, chromosomeBit.Length);
            for (int i = 0; i < position; i++)
            {
                this.chromosomeBit[i] = parentLeft.ChromosomeBit[i];
            }

            for (int i = position; i < chromosomeBit.Length; i++)
            {
                this.chromosomeBit[i] = parentRight.ChromosomeBit[i]; 
            }
        }

        public void CreateChromosomeFromMutation(SGAChromosome parent)
        {
            for (int i = 0; i < chromosomeBit.Length; i++)
            {
                this.chromosomeBit[i] = parent.ChromosomeBit[i];
            }
            int position = rand.Next(chromosomeBit.Length);
            chromosomeBit[position] = !chromosomeBit[position];
        }

        public void CreateChromosomeFromReproduction(SGAChromosome parent)
        {
            for (int i = 0; i < chromosomeBit.Length; i++)
            {
                this.chromosomeBit[i] = parent.ChromosomeBit[i];
            }
        }

        public String ChromosomeString()
        {
            return ChromosomeToInt().ToString();
        }

        public int ChromosomeToInt()
        {
            var result = new int[1];
            chromosomeBit.CopyTo(result, 0);
            return result[0];
        }

        public double ChromosomeToDouble()
        {
            return Convert.ToDouble(this.ChromosomeToInt());
        }
    }
}
