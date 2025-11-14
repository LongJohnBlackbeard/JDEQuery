using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI13 - .
/// </summary>
public class F75IUI13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCPYID.
        /// </summary>
        public const string TCPYID = "TCPYID";

        /// <summary>
        /// TCI75TSCT.
        /// </summary>
        public const string TCI75TSCT = "TCI75TSCT";

        /// <summary>
        /// TCI75TSAPF.
        /// </summary>
        public const string TCI75TSAPF = "TCI75TSAPF";

        /// <summary>
        /// TCJOBS.
        /// </summary>
        public const string TCJOBS = "TCJOBS";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCPYID", "TCPYID", JdeDataType.Numeric),
        new JdeField("TCI75TSCT", "TCI75TSCT", JdeDataType.String, 4),
        new JdeField("TCI75TSAPF", "TCI75TSAPF", JdeDataType.String, 2),
        new JdeField("TCJOBS", "TCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20, true, true),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI13_0", "Primary Key on TCJOBS, TCUSER", new[] { "TCJOBS", "TCUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
