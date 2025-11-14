using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3702 - .
/// </summary>
public class F3702 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QSQREV.
        /// </summary>
        public const string QSQREV = "QSQREV";

        /// <summary>
        /// QSMCU.
        /// </summary>
        public const string QSMCU = "QSMCU";

        /// <summary>
        /// QSDSC1.
        /// </summary>
        public const string QSDSC1 = "QSDSC1";

        /// <summary>
        /// QSEFFF.
        /// </summary>
        public const string QSEFFF = "QSEFFF";

        /// <summary>
        /// QSQSPC.
        /// </summary>
        public const string QSQSPC = "QSQSPC";

        /// <summary>
        /// QSEFFT.
        /// </summary>
        public const string QSEFFT = "QSEFFT";

        /// <summary>
        /// QSSTAW.
        /// </summary>
        public const string QSSTAW = "QSSTAW";

        /// <summary>
        /// QSQTSN.
        /// </summary>
        public const string QSQTSN = "QSQTSN";

        /// <summary>
        /// QSQSC1.
        /// </summary>
        public const string QSQSC1 = "QSQSC1";

        /// <summary>
        /// QSQSC2.
        /// </summary>
        public const string QSQSC2 = "QSQSC2";

        /// <summary>
        /// QSQSC3.
        /// </summary>
        public const string QSQSC3 = "QSQSC3";

        /// <summary>
        /// QSQSC4.
        /// </summary>
        public const string QSQSC4 = "QSQSC4";

        /// <summary>
        /// QSQSC5.
        /// </summary>
        public const string QSQSC5 = "QSQSC5";

        /// <summary>
        /// QSMMCU.
        /// </summary>
        public const string QSMMCU = "QSMMCU";

        /// <summary>
        /// QSURCD.
        /// </summary>
        public const string QSURCD = "QSURCD";

        /// <summary>
        /// QSURDT.
        /// </summary>
        public const string QSURDT = "QSURDT";

        /// <summary>
        /// QSURAT.
        /// </summary>
        public const string QSURAT = "QSURAT";

        /// <summary>
        /// QSURRF.
        /// </summary>
        public const string QSURRF = "QSURRF";

        /// <summary>
        /// QSURAB.
        /// </summary>
        public const string QSURAB = "QSURAB";

        /// <summary>
        /// QSUKID.
        /// </summary>
        public const string QSUKID = "QSUKID";

        /// <summary>
        /// QSACTN.
        /// </summary>
        public const string QSACTN = "QSACTN";

        /// <summary>
        /// QSUSER.
        /// </summary>
        public const string QSUSER = "QSUSER";

        /// <summary>
        /// QSPID.
        /// </summary>
        public const string QSPID = "QSPID";

        /// <summary>
        /// QSUPMJ.
        /// </summary>
        public const string QSUPMJ = "QSUPMJ";

        /// <summary>
        /// QSTDAY.
        /// </summary>
        public const string QSTDAY = "QSTDAY";

        /// <summary>
        /// QSJOBN.
        /// </summary>
        public const string QSJOBN = "QSJOBN";

        /// <summary>
        /// QSQMRF2.
        /// </summary>
        public const string QSQMRF2 = "QSQMRF2";

        /// <summary>
        /// QSQMCD2.
        /// </summary>
        public const string QSQMCD2 = "QSQMCD2";

        /// <summary>
        /// QSQMAB2.
        /// </summary>
        public const string QSQMAB2 = "QSQMAB2";

        /// <summary>
        /// QSQMNUM2.
        /// </summary>
        public const string QSQMNUM2 = "QSQMNUM2";

        /// <summary>
        /// QSQMDT2.
        /// </summary>
        public const string QSQMDT2 = "QSQMDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F3702";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QSQREV", "QSQREV", JdeDataType.String, 6),
        new JdeField("QSMCU", "QSMCU", JdeDataType.String, 24, true, true),
        new JdeField("QSDSC1", "QSDSC1", JdeDataType.String, 60),
        new JdeField("QSEFFF", "QSEFFF", JdeDataType.Numeric),
        new JdeField("QSQSPC", "QSQSPC", JdeDataType.String, 50, true, true),
        new JdeField("QSEFFT", "QSEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("QSSTAW", "QSSTAW", JdeDataType.String, 2, true, true),
        new JdeField("QSQTSN", "QSQTSN", JdeDataType.Numeric, null, true, true),
        new JdeField("QSQSC1", "QSQSC1", JdeDataType.String, 6),
        new JdeField("QSQSC2", "QSQSC2", JdeDataType.String, 6),
        new JdeField("QSQSC3", "QSQSC3", JdeDataType.String, 6),
        new JdeField("QSQSC4", "QSQSC4", JdeDataType.String, 6),
        new JdeField("QSQSC5", "QSQSC5", JdeDataType.String, 6),
        new JdeField("QSMMCU", "QSMMCU", JdeDataType.String, 24),
        new JdeField("QSURCD", "QSURCD", JdeDataType.String, 4),
        new JdeField("QSURDT", "QSURDT", JdeDataType.Numeric),
        new JdeField("QSURAT", "QSURAT", JdeDataType.Numeric),
        new JdeField("QSURRF", "QSURRF", JdeDataType.String, 30),
        new JdeField("QSURAB", "QSURAB", JdeDataType.Numeric),
        new JdeField("QSUKID", "QSUKID", JdeDataType.Numeric),
        new JdeField("QSACTN", "QSACTN", JdeDataType.String, 2),
        new JdeField("QSUSER", "QSUSER", JdeDataType.String, 20),
        new JdeField("QSPID", "QSPID", JdeDataType.String, 20),
        new JdeField("QSUPMJ", "QSUPMJ", JdeDataType.Numeric),
        new JdeField("QSTDAY", "QSTDAY", JdeDataType.Numeric),
        new JdeField("QSJOBN", "QSJOBN", JdeDataType.String, 20),
        new JdeField("QSQMRF2", "QSQMRF2", JdeDataType.String, 60),
        new JdeField("QSQMCD2", "QSQMCD2", JdeDataType.String, 6),
        new JdeField("QSQMAB2", "QSQMAB2", JdeDataType.Numeric),
        new JdeField("QSQMNUM2", "QSQMNUM2", JdeDataType.Numeric),
        new JdeField("QSQMDT2", "QSQMDT2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3702_0", "Primary Key on QSQSPC, QSMCU, QSSTAW, QSEFFT, QSQTSN", new[] { "QSQSPC", "QSMCU", "QSSTAW", "QSEFFT", "QSQTSN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3702_4", "Index on QSQSPC, QSQREV, QSMCU", new[] { "QSQSPC", "QSQREV", "QSMCU" }),
        new JdeIndex("F3702_5", "Index on QSQSPC, QSMCU, QSSTAW, QSUKID", new[] { "QSQSPC", "QSMCU", "QSSTAW", "QSUKID" })
    };
}
