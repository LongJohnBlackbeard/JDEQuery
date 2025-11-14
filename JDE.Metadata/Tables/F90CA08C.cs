using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA08C - .
/// </summary>
public class F90CA08C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UCCUAN8.
        /// </summary>
        public const string UCCUAN8 = "UCCUAN8";

        /// <summary>
        /// UCPRAN8.
        /// </summary>
        public const string UCPRAN8 = "UCPRAN8";

        /// <summary>
        /// UCSTSUDT.
        /// </summary>
        public const string UCSTSUDT = "UCSTSUDT";

        /// <summary>
        /// UCACTIND.
        /// </summary>
        public const string UCACTIND = "UCACTIND";

        /// <summary>
        /// UCUSER.
        /// </summary>
        public const string UCUSER = "UCUSER";

        /// <summary>
        /// UCPID.
        /// </summary>
        public const string UCPID = "UCPID";

        /// <summary>
        /// UCVID.
        /// </summary>
        public const string UCVID = "UCVID";

        /// <summary>
        /// UCMKEY.
        /// </summary>
        public const string UCMKEY = "UCMKEY";

        /// <summary>
        /// UCUDTTM.
        /// </summary>
        public const string UCUDTTM = "UCUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA08C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UCCUAN8", "UCCUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UCPRAN8", "UCPRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UCSTSUDT", "UCSTSUDT", JdeDataType.Date),
        new JdeField("UCACTIND", "UCACTIND", JdeDataType.String, 2),
        new JdeField("UCUSER", "UCUSER", JdeDataType.String, 20),
        new JdeField("UCPID", "UCPID", JdeDataType.String, 20),
        new JdeField("UCVID", "UCVID", JdeDataType.String, 20),
        new JdeField("UCMKEY", "UCMKEY", JdeDataType.String, 30),
        new JdeField("UCUDTTM", "UCUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA08C_0", "Primary Key on UCCUAN8, UCPRAN8", new[] { "UCCUAN8", "UCPRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
