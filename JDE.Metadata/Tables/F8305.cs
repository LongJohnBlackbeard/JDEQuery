using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8305 - .
/// </summary>
public class F8305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R5PID.
        /// </summary>
        public const string R5PID = "R5PID";

        /// <summary>
        /// R5VERS.
        /// </summary>
        public const string R5VERS = "R5VERS";

        /// <summary>
        /// R5RNBR.
        /// </summary>
        public const string R5RNBR = "R5RNBR";

        /// <summary>
        /// R5DSCR.
        /// </summary>
        public const string R5DSCR = "R5DSCR";

        /// <summary>
        /// R5DTX1.
        /// </summary>
        public const string R5DTX1 = "R5DTX1";

        /// <summary>
        /// R5PRTI.
        /// </summary>
        public const string R5PRTI = "R5PRTI";

        /// <summary>
        /// R5LT.
        /// </summary>
        public const string R5LT = "R5LT";

        /// <summary>
        /// R5FIYR.
        /// </summary>
        public const string R5FIYR = "R5FIYR";

        /// <summary>
        /// R5RINC.
        /// </summary>
        public const string R5RINC = "R5RINC";

        /// <summary>
        /// R5OR01.
        /// </summary>
        public const string R5OR01 = "R5OR01";

        /// <summary>
        /// R5OR02.
        /// </summary>
        public const string R5OR02 = "R5OR02";

        /// <summary>
        /// R5OR03.
        /// </summary>
        public const string R5OR03 = "R5OR03";

        /// <summary>
        /// R5OR04.
        /// </summary>
        public const string R5OR04 = "R5OR04";

        /// <summary>
        /// R5OR05.
        /// </summary>
        public const string R5OR05 = "R5OR05";

        /// <summary>
        /// R5OR06.
        /// </summary>
        public const string R5OR06 = "R5OR06";

        /// <summary>
        /// R5OR07.
        /// </summary>
        public const string R5OR07 = "R5OR07";

        /// <summary>
        /// R5OR08.
        /// </summary>
        public const string R5OR08 = "R5OR08";

        /// <summary>
        /// R5OR09.
        /// </summary>
        public const string R5OR09 = "R5OR09";

        /// <summary>
        /// R5OR10.
        /// </summary>
        public const string R5OR10 = "R5OR10";

        /// <summary>
        /// R5OR11.
        /// </summary>
        public const string R5OR11 = "R5OR11";

        /// <summary>
        /// R5OR12.
        /// </summary>
        public const string R5OR12 = "R5OR12";

        /// <summary>
        /// R5OR13.
        /// </summary>
        public const string R5OR13 = "R5OR13";

        /// <summary>
        /// R5OR14.
        /// </summary>
        public const string R5OR14 = "R5OR14";

        /// <summary>
        /// R5OR15.
        /// </summary>
        public const string R5OR15 = "R5OR15";

        /// <summary>
        /// R5OR16.
        /// </summary>
        public const string R5OR16 = "R5OR16";

        /// <summary>
        /// R5OR17.
        /// </summary>
        public const string R5OR17 = "R5OR17";

        /// <summary>
        /// R5OR18.
        /// </summary>
        public const string R5OR18 = "R5OR18";

        /// <summary>
        /// R5OR19.
        /// </summary>
        public const string R5OR19 = "R5OR19";

        /// <summary>
        /// R5OR20.
        /// </summary>
        public const string R5OR20 = "R5OR20";

        /// <summary>
        /// R5OR21.
        /// </summary>
        public const string R5OR21 = "R5OR21";

        /// <summary>
        /// R5OR22.
        /// </summary>
        public const string R5OR22 = "R5OR22";

        /// <summary>
        /// R5OR23.
        /// </summary>
        public const string R5OR23 = "R5OR23";

        /// <summary>
        /// R5OR24.
        /// </summary>
        public const string R5OR24 = "R5OR24";

        /// <summary>
        /// R5OR25.
        /// </summary>
        public const string R5OR25 = "R5OR25";

        /// <summary>
        /// R5OR26.
        /// </summary>
        public const string R5OR26 = "R5OR26";

        /// <summary>
        /// R5VA01.
        /// </summary>
        public const string R5VA01 = "R5VA01";

        /// <summary>
        /// R5VA02.
        /// </summary>
        public const string R5VA02 = "R5VA02";

        /// <summary>
        /// R5VA03.
        /// </summary>
        public const string R5VA03 = "R5VA03";

        /// <summary>
        /// R5VA04.
        /// </summary>
        public const string R5VA04 = "R5VA04";

        /// <summary>
        /// R5VA05.
        /// </summary>
        public const string R5VA05 = "R5VA05";

        /// <summary>
        /// R5VA06.
        /// </summary>
        public const string R5VA06 = "R5VA06";

        /// <summary>
        /// R5VA07.
        /// </summary>
        public const string R5VA07 = "R5VA07";

        /// <summary>
        /// R5VA08.
        /// </summary>
        public const string R5VA08 = "R5VA08";

        /// <summary>
        /// R5VA09.
        /// </summary>
        public const string R5VA09 = "R5VA09";

        /// <summary>
        /// R5VA10.
        /// </summary>
        public const string R5VA10 = "R5VA10";

        /// <summary>
        /// R5VA11.
        /// </summary>
        public const string R5VA11 = "R5VA11";

        /// <summary>
        /// R5VA12.
        /// </summary>
        public const string R5VA12 = "R5VA12";

        /// <summary>
        /// R5VA13.
        /// </summary>
        public const string R5VA13 = "R5VA13";

        /// <summary>
        /// R5VA14.
        /// </summary>
        public const string R5VA14 = "R5VA14";

        /// <summary>
        /// R5VA15.
        /// </summary>
        public const string R5VA15 = "R5VA15";

        /// <summary>
        /// R5VA16.
        /// </summary>
        public const string R5VA16 = "R5VA16";

        /// <summary>
        /// R5VA17.
        /// </summary>
        public const string R5VA17 = "R5VA17";

        /// <summary>
        /// R5VA18.
        /// </summary>
        public const string R5VA18 = "R5VA18";

        /// <summary>
        /// R5VA19.
        /// </summary>
        public const string R5VA19 = "R5VA19";

        /// <summary>
        /// R5VA20.
        /// </summary>
        public const string R5VA20 = "R5VA20";

        /// <summary>
        /// R5VA21.
        /// </summary>
        public const string R5VA21 = "R5VA21";

        /// <summary>
        /// R5VA22.
        /// </summary>
        public const string R5VA22 = "R5VA22";

        /// <summary>
        /// R5VA23.
        /// </summary>
        public const string R5VA23 = "R5VA23";

        /// <summary>
        /// R5VA24.
        /// </summary>
        public const string R5VA24 = "R5VA24";

        /// <summary>
        /// R5RSGN.
        /// </summary>
        public const string R5RSGN = "R5RSGN";

        /// <summary>
        /// R5DECI.
        /// </summary>
        public const string R5DECI = "R5DECI";

        /// <summary>
        /// R5OPTM.
        /// </summary>
        public const string R5OPTM = "R5OPTM";
    }

    /// <inheritdoc />
    public override string TableName => "F8305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R5PID", "R5PID", JdeDataType.String, 20, true, true),
        new JdeField("R5VERS", "R5VERS", JdeDataType.String, 20, true, true),
        new JdeField("R5RNBR", "R5RNBR", JdeDataType.String, 8, true, true),
        new JdeField("R5DSCR", "R5DSCR", JdeDataType.String, 80),
        new JdeField("R5DTX1", "R5DTX1", JdeDataType.String, 150),
        new JdeField("R5PRTI", "R5PRTI", JdeDataType.String, 2),
        new JdeField("R5LT", "R5LT", JdeDataType.String, 4),
        new JdeField("R5FIYR", "R5FIYR", JdeDataType.String, 4),
        new JdeField("R5RINC", "R5RINC", JdeDataType.String, 4),
        new JdeField("R5OR01", "R5OR01", JdeDataType.String, 30),
        new JdeField("R5OR02", "R5OR02", JdeDataType.String, 30),
        new JdeField("R5OR03", "R5OR03", JdeDataType.String, 30),
        new JdeField("R5OR04", "R5OR04", JdeDataType.String, 30),
        new JdeField("R5OR05", "R5OR05", JdeDataType.String, 30),
        new JdeField("R5OR06", "R5OR06", JdeDataType.String, 30),
        new JdeField("R5OR07", "R5OR07", JdeDataType.String, 30),
        new JdeField("R5OR08", "R5OR08", JdeDataType.String, 30),
        new JdeField("R5OR09", "R5OR09", JdeDataType.String, 30),
        new JdeField("R5OR10", "R5OR10", JdeDataType.String, 30),
        new JdeField("R5OR11", "R5OR11", JdeDataType.String, 30),
        new JdeField("R5OR12", "R5OR12", JdeDataType.String, 30),
        new JdeField("R5OR13", "R5OR13", JdeDataType.String, 30),
        new JdeField("R5OR14", "R5OR14", JdeDataType.String, 30),
        new JdeField("R5OR15", "R5OR15", JdeDataType.String, 30),
        new JdeField("R5OR16", "R5OR16", JdeDataType.String, 30),
        new JdeField("R5OR17", "R5OR17", JdeDataType.String, 30),
        new JdeField("R5OR18", "R5OR18", JdeDataType.String, 30),
        new JdeField("R5OR19", "R5OR19", JdeDataType.String, 30),
        new JdeField("R5OR20", "R5OR20", JdeDataType.String, 30),
        new JdeField("R5OR21", "R5OR21", JdeDataType.String, 30),
        new JdeField("R5OR22", "R5OR22", JdeDataType.String, 30),
        new JdeField("R5OR23", "R5OR23", JdeDataType.String, 30),
        new JdeField("R5OR24", "R5OR24", JdeDataType.String, 30),
        new JdeField("R5OR25", "R5OR25", JdeDataType.String, 30),
        new JdeField("R5OR26", "R5OR26", JdeDataType.String, 30),
        new JdeField("R5VA01", "R5VA01", JdeDataType.String, 24),
        new JdeField("R5VA02", "R5VA02", JdeDataType.String, 24),
        new JdeField("R5VA03", "R5VA03", JdeDataType.String, 24),
        new JdeField("R5VA04", "R5VA04", JdeDataType.String, 24),
        new JdeField("R5VA05", "R5VA05", JdeDataType.String, 24),
        new JdeField("R5VA06", "R5VA06", JdeDataType.String, 24),
        new JdeField("R5VA07", "R5VA07", JdeDataType.String, 24),
        new JdeField("R5VA08", "R5VA08", JdeDataType.String, 24),
        new JdeField("R5VA09", "R5VA09", JdeDataType.String, 24),
        new JdeField("R5VA10", "R5VA10", JdeDataType.String, 24),
        new JdeField("R5VA11", "R5VA11", JdeDataType.String, 24),
        new JdeField("R5VA12", "R5VA12", JdeDataType.String, 24),
        new JdeField("R5VA13", "R5VA13", JdeDataType.String, 24),
        new JdeField("R5VA14", "R5VA14", JdeDataType.String, 24),
        new JdeField("R5VA15", "R5VA15", JdeDataType.String, 24),
        new JdeField("R5VA16", "R5VA16", JdeDataType.String, 24),
        new JdeField("R5VA17", "R5VA17", JdeDataType.String, 24),
        new JdeField("R5VA18", "R5VA18", JdeDataType.String, 24),
        new JdeField("R5VA19", "R5VA19", JdeDataType.String, 24),
        new JdeField("R5VA20", "R5VA20", JdeDataType.String, 24),
        new JdeField("R5VA21", "R5VA21", JdeDataType.String, 24),
        new JdeField("R5VA22", "R5VA22", JdeDataType.String, 24),
        new JdeField("R5VA23", "R5VA23", JdeDataType.String, 24),
        new JdeField("R5VA24", "R5VA24", JdeDataType.String, 24),
        new JdeField("R5RSGN", "R5RSGN", JdeDataType.String, 2),
        new JdeField("R5DECI", "R5DECI", JdeDataType.String, 2),
        new JdeField("R5OPTM", "R5OPTM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8305_0", "Primary Key on R5PID, R5VERS, R5RNBR", new[] { "R5PID", "R5VERS", "R5RNBR" }, isUnique: true, isPrimaryKey: true)
    };
}
