using DesignPrinciples.DataDAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesignPricipleTesting
{
    [TestClass]
    public class UnitTest1
    {
        string stateCodePath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\IndiaStateCode.csv";
        string stateCensusPath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\IndiaStateCensusData.csv";
        string wrongCensusPath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\WrongIndiaStateCensusData.csv";
        string wrongCensusCodePath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\WrongIndiaStateCode.csv";
        string wrongHeaderStateCodePath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\WrongIndiaStateCode.csv";
        string delimiterStateCodePath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\DelimiterIndiaStateCode.csv";
        string delimiterStateCensusPath = @"E:\VisualBasic Problems\DesignPrinciples\DesignPrinciples\CSVFiles\DelimiterIndiaStateCensusData.csv";
        //IndiaCensusDataDemo

        Dictionary<string, CensusDataDAO> stateRecords;

        
        public void SetUp()
        {
            stateRecords = new Dictionary<string, CensusDataDAO>();

        }




        [TestMethod]
        public void GivenStateCensusCSVShouldReturnRecords()
        {
            //stateRecords=
        }
    }
}
