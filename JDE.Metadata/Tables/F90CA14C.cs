using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA14C - .
/// </summary>
public class F90CA14C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCTERRID.
        /// </summary>
        public const string TCTERRID = "TCTERRID";

        /// <summary>
        /// TCSTDRKY.
        /// </summary>
        public const string TCSTDRKY = "TCSTDRKY";

        /// <summary>
        /// TCCNDRKY.
        /// </summary>
        public const string TCCNDRKY = "TCCNDRKY";

        /// <summary>
        /// TCSTSUDT.
        /// </summary>
        public const string TCSTSUDT = "TCSTSUDT";

        /// <summary>
        /// TCACTIND.
        /// </summary>
        public const string TCACTIND = "TCACTIND";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCVID.
        /// </summary>
        public const string TCVID = "TCVID";

        /// <summary>
        /// TCMKEY.
        /// </summary>
        public const string TCMKEY = "TCMKEY";

        /// <summary>
        /// TCUDTTM.
        /// </summary>
        public const string TCUDTTM = "TCUDTTM";

        /// <summary>
        /// TCENTDBY.
        /// </summary>
        public const string TCENTDBY = "TCENTDBY";

        /// <summary>
        /// TCEDATE.
        /// </summary>
        public const string TCEDATE = "TCEDATE";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA14C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCTERRID", "TCTERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TCSTDRKY", "TCSTDRKY", JdeDataType.String, 20, true, true),
        new JdeField("TCCNDRKY", "TCCNDRKY", JdeDataType.String, 20),
        new JdeField("TCSTSUDT", "TCSTSUDT", JdeDataType.Date),
        new JdeField("TCACTIND", "TCACTIND", JdeDataType.String, 2),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCVID", "TCVID", JdeDataType.String, 20),
        new JdeField("TCMKEY", "TCMKEY", JdeDataType.String, 30),
        new JdeField("TCUDTTM", "TCUDTTM", JdeDataType.Date),
        new JdeField("TCENTDBY", "TCENTDBY", JdeDataType.Numeric),
        new JdeField("TCEDATE", "TCEDATE", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA14C_0", "Primary Key on TCTERRID, TCSTDRKY", new[] { "TCTERRID", "TCSTDRKY" }, isUnique: true, isPrimaryKey: true)
    };
}
