using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800602 - .
/// </summary>
public class F0800602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCJCC.
        /// </summary>
        public const string JCJCC = "JCJCC";

        /// <summary>
        /// JCDL01.
        /// </summary>
        public const string JCDL01 = "JCDL01";

        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";

        /// <summary>
        /// JCCAT01.
        /// </summary>
        public const string JCCAT01 = "JCCAT01";

        /// <summary>
        /// JCCAT02.
        /// </summary>
        public const string JCCAT02 = "JCCAT02";

        /// <summary>
        /// JCCAT03.
        /// </summary>
        public const string JCCAT03 = "JCCAT03";

        /// <summary>
        /// JCCAT04.
        /// </summary>
        public const string JCCAT04 = "JCCAT04";

        /// <summary>
        /// JCCAT05.
        /// </summary>
        public const string JCCAT05 = "JCCAT05";

        /// <summary>
        /// JCCAT06.
        /// </summary>
        public const string JCCAT06 = "JCCAT06";

        /// <summary>
        /// JCCAT07.
        /// </summary>
        public const string JCCAT07 = "JCCAT07";

        /// <summary>
        /// JCCAT08.
        /// </summary>
        public const string JCCAT08 = "JCCAT08";

        /// <summary>
        /// JCCAT09.
        /// </summary>
        public const string JCCAT09 = "JCCAT09";

        /// <summary>
        /// JCCAT10.
        /// </summary>
        public const string JCCAT10 = "JCCAT10";

        /// <summary>
        /// JCUSER.
        /// </summary>
        public const string JCUSER = "JCUSER";

        /// <summary>
        /// JCPID.
        /// </summary>
        public const string JCPID = "JCPID";

        /// <summary>
        /// JCJOBN.
        /// </summary>
        public const string JCJOBN = "JCJOBN";

        /// <summary>
        /// JCUPMJ.
        /// </summary>
        public const string JCUPMJ = "JCUPMJ";

        /// <summary>
        /// JCUPMT.
        /// </summary>
        public const string JCUPMT = "JCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0800602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20, true, true),
        new JdeField("JCDL01", "JCDL01", JdeDataType.String, 60),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric),
        new JdeField("JCCAT01", "JCCAT01", JdeDataType.String, 6),
        new JdeField("JCCAT02", "JCCAT02", JdeDataType.String, 6),
        new JdeField("JCCAT03", "JCCAT03", JdeDataType.String, 6),
        new JdeField("JCCAT04", "JCCAT04", JdeDataType.String, 6),
        new JdeField("JCCAT05", "JCCAT05", JdeDataType.String, 6),
        new JdeField("JCCAT06", "JCCAT06", JdeDataType.String, 6),
        new JdeField("JCCAT07", "JCCAT07", JdeDataType.String, 6),
        new JdeField("JCCAT08", "JCCAT08", JdeDataType.String, 6),
        new JdeField("JCCAT09", "JCCAT09", JdeDataType.String, 6),
        new JdeField("JCCAT10", "JCCAT10", JdeDataType.String, 6),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800602_0", "Primary Key on JCJCC", new[] { "JCJCC" }, isUnique: true, isPrimaryKey: true)
    };
}
