using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8304 - .
/// </summary>
public class F8304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R4PID.
        /// </summary>
        public const string R4PID = "R4PID";

        /// <summary>
        /// R4VERS.
        /// </summary>
        public const string R4VERS = "R4VERS";

        /// <summary>
        /// R4CNBR.
        /// </summary>
        public const string R4CNBR = "R4CNBR";

        /// <summary>
        /// R4CH01.
        /// </summary>
        public const string R4CH01 = "R4CH01";

        /// <summary>
        /// R4CH02.
        /// </summary>
        public const string R4CH02 = "R4CH02";

        /// <summary>
        /// R4CH03.
        /// </summary>
        public const string R4CH03 = "R4CH03";

        /// <summary>
        /// R4CH04.
        /// </summary>
        public const string R4CH04 = "R4CH04";

        /// <summary>
        /// R4CSIZ.
        /// </summary>
        public const string R4CSIZ = "R4CSIZ";

        /// <summary>
        /// R4PCOL.
        /// </summary>
        public const string R4PCOL = "R4PCOL";

        /// <summary>
        /// R4LT.
        /// </summary>
        public const string R4LT = "R4LT";

        /// <summary>
        /// R4FIYR.
        /// </summary>
        public const string R4FIYR = "R4FIYR";

        /// <summary>
        /// R4COLT.
        /// </summary>
        public const string R4COLT = "R4COLT";

        /// <summary>
        /// R4CINC.
        /// </summary>
        public const string R4CINC = "R4CINC";

        /// <summary>
        /// R4OR01.
        /// </summary>
        public const string R4OR01 = "R4OR01";

        /// <summary>
        /// R4OR02.
        /// </summary>
        public const string R4OR02 = "R4OR02";

        /// <summary>
        /// R4OR03.
        /// </summary>
        public const string R4OR03 = "R4OR03";

        /// <summary>
        /// R4OR04.
        /// </summary>
        public const string R4OR04 = "R4OR04";

        /// <summary>
        /// R4OR05.
        /// </summary>
        public const string R4OR05 = "R4OR05";

        /// <summary>
        /// R4OR06.
        /// </summary>
        public const string R4OR06 = "R4OR06";

        /// <summary>
        /// R4OR07.
        /// </summary>
        public const string R4OR07 = "R4OR07";

        /// <summary>
        /// R4OR08.
        /// </summary>
        public const string R4OR08 = "R4OR08";

        /// <summary>
        /// R4OR09.
        /// </summary>
        public const string R4OR09 = "R4OR09";

        /// <summary>
        /// R4OR10.
        /// </summary>
        public const string R4OR10 = "R4OR10";

        /// <summary>
        /// R4OR11.
        /// </summary>
        public const string R4OR11 = "R4OR11";

        /// <summary>
        /// R4OR12.
        /// </summary>
        public const string R4OR12 = "R4OR12";

        /// <summary>
        /// R4OR13.
        /// </summary>
        public const string R4OR13 = "R4OR13";

        /// <summary>
        /// R4OR14.
        /// </summary>
        public const string R4OR14 = "R4OR14";

        /// <summary>
        /// R4OR15.
        /// </summary>
        public const string R4OR15 = "R4OR15";

        /// <summary>
        /// R4OR16.
        /// </summary>
        public const string R4OR16 = "R4OR16";

        /// <summary>
        /// R4OR17.
        /// </summary>
        public const string R4OR17 = "R4OR17";

        /// <summary>
        /// R4OR18.
        /// </summary>
        public const string R4OR18 = "R4OR18";

        /// <summary>
        /// R4OR19.
        /// </summary>
        public const string R4OR19 = "R4OR19";

        /// <summary>
        /// R4OR20.
        /// </summary>
        public const string R4OR20 = "R4OR20";

        /// <summary>
        /// R4OR21.
        /// </summary>
        public const string R4OR21 = "R4OR21";

        /// <summary>
        /// R4OR22.
        /// </summary>
        public const string R4OR22 = "R4OR22";

        /// <summary>
        /// R4OR23.
        /// </summary>
        public const string R4OR23 = "R4OR23";

        /// <summary>
        /// R4OR24.
        /// </summary>
        public const string R4OR24 = "R4OR24";

        /// <summary>
        /// R4DECI.
        /// </summary>
        public const string R4DECI = "R4DECI";

        /// <summary>
        /// R4DBA.
        /// </summary>
        public const string R4DBA = "R4DBA";

        /// <summary>
        /// R4CRA.
        /// </summary>
        public const string R4CRA = "R4CRA";

        /// <summary>
        /// R4UNTC.
        /// </summary>
        public const string R4UNTC = "R4UNTC";

        /// <summary>
        /// R4DBCC.
        /// </summary>
        public const string R4DBCC = "R4DBCC";

        /// <summary>
        /// R4CRCC.
        /// </summary>
        public const string R4CRCC = "R4CRCC";

        /// <summary>
        /// R4DBSL.
        /// </summary>
        public const string R4DBSL = "R4DBSL";

        /// <summary>
        /// R4CRSL.
        /// </summary>
        public const string R4CRSL = "R4CRSL";

        /// <summary>
        /// R4DSLT.
        /// </summary>
        public const string R4DSLT = "R4DSLT";

        /// <summary>
        /// R4CSLT.
        /// </summary>
        public const string R4CSLT = "R4CSLT";

        /// <summary>
        /// R4JELT.
        /// </summary>
        public const string R4JELT = "R4JELT";

        /// <summary>
        /// R4TOT.
        /// </summary>
        public const string R4TOT = "R4TOT";

        /// <summary>
        /// R4PNRF.
        /// </summary>
        public const string R4PNRF = "R4PNRF";

        /// <summary>
        /// R4EC.
        /// </summary>
        public const string R4EC = "R4EC";

        /// <summary>
        /// R4FLCY.
        /// </summary>
        public const string R4FLCY = "R4FLCY";
    }

    /// <inheritdoc />
    public override string TableName => "F8304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R4PID", "R4PID", JdeDataType.String, 20, true, true),
        new JdeField("R4VERS", "R4VERS", JdeDataType.String, 20, true, true),
        new JdeField("R4CNBR", "R4CNBR", JdeDataType.String, 4, true, true),
        new JdeField("R4CH01", "R4CH01", JdeDataType.String, 20),
        new JdeField("R4CH02", "R4CH02", JdeDataType.String, 20),
        new JdeField("R4CH03", "R4CH03", JdeDataType.String, 20),
        new JdeField("R4CH04", "R4CH04", JdeDataType.String, 20),
        new JdeField("R4CSIZ", "R4CSIZ", JdeDataType.Numeric),
        new JdeField("R4PCOL", "R4PCOL", JdeDataType.String, 4),
        new JdeField("R4LT", "R4LT", JdeDataType.String, 4),
        new JdeField("R4FIYR", "R4FIYR", JdeDataType.String, 4),
        new JdeField("R4COLT", "R4COLT", JdeDataType.String, 4),
        new JdeField("R4CINC", "R4CINC", JdeDataType.String, 4),
        new JdeField("R4OR01", "R4OR01", JdeDataType.String, 30),
        new JdeField("R4OR02", "R4OR02", JdeDataType.String, 30),
        new JdeField("R4OR03", "R4OR03", JdeDataType.String, 30),
        new JdeField("R4OR04", "R4OR04", JdeDataType.String, 30),
        new JdeField("R4OR05", "R4OR05", JdeDataType.String, 30),
        new JdeField("R4OR06", "R4OR06", JdeDataType.String, 30),
        new JdeField("R4OR07", "R4OR07", JdeDataType.String, 30),
        new JdeField("R4OR08", "R4OR08", JdeDataType.String, 30),
        new JdeField("R4OR09", "R4OR09", JdeDataType.String, 30),
        new JdeField("R4OR10", "R4OR10", JdeDataType.String, 30),
        new JdeField("R4OR11", "R4OR11", JdeDataType.String, 30),
        new JdeField("R4OR12", "R4OR12", JdeDataType.String, 30),
        new JdeField("R4OR13", "R4OR13", JdeDataType.String, 30),
        new JdeField("R4OR14", "R4OR14", JdeDataType.String, 30),
        new JdeField("R4OR15", "R4OR15", JdeDataType.String, 30),
        new JdeField("R4OR16", "R4OR16", JdeDataType.String, 30),
        new JdeField("R4OR17", "R4OR17", JdeDataType.String, 30),
        new JdeField("R4OR18", "R4OR18", JdeDataType.String, 30),
        new JdeField("R4OR19", "R4OR19", JdeDataType.String, 30),
        new JdeField("R4OR20", "R4OR20", JdeDataType.String, 30),
        new JdeField("R4OR21", "R4OR21", JdeDataType.String, 30),
        new JdeField("R4OR22", "R4OR22", JdeDataType.String, 30),
        new JdeField("R4OR23", "R4OR23", JdeDataType.String, 30),
        new JdeField("R4OR24", "R4OR24", JdeDataType.String, 30),
        new JdeField("R4DECI", "R4DECI", JdeDataType.String, 2),
        new JdeField("R4DBA", "R4DBA", JdeDataType.String, 30),
        new JdeField("R4CRA", "R4CRA", JdeDataType.String, 30),
        new JdeField("R4UNTC", "R4UNTC", JdeDataType.String, 4),
        new JdeField("R4DBCC", "R4DBCC", JdeDataType.String, 24),
        new JdeField("R4CRCC", "R4CRCC", JdeDataType.String, 24),
        new JdeField("R4DBSL", "R4DBSL", JdeDataType.String, 16),
        new JdeField("R4CRSL", "R4CRSL", JdeDataType.String, 16),
        new JdeField("R4DSLT", "R4DSLT", JdeDataType.String, 2),
        new JdeField("R4CSLT", "R4CSLT", JdeDataType.String, 2),
        new JdeField("R4JELT", "R4JELT", JdeDataType.String, 4),
        new JdeField("R4TOT", "R4TOT", JdeDataType.String, 2),
        new JdeField("R4PNRF", "R4PNRF", JdeDataType.String, 6),
        new JdeField("R4EC", "R4EC", JdeDataType.String, 2),
        new JdeField("R4FLCY", "R4FLCY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8304_0", "Primary Key on R4PID, R4VERS, R4CNBR", new[] { "R4PID", "R4VERS", "R4CNBR" }, isUnique: true, isPrimaryKey: true)
    };
}
