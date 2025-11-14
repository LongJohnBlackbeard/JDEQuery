using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1609 - .
/// </summary>
public class F1609 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCUKID.
        /// </summary>
        public const string CCUKID = "CCUKID";

        /// <summary>
        /// CCCO01.
        /// </summary>
        public const string CCCO01 = "CCCO01";

        /// <summary>
        /// CCCO02.
        /// </summary>
        public const string CCCO02 = "CCCO02";

        /// <summary>
        /// CCCO03.
        /// </summary>
        public const string CCCO03 = "CCCO03";

        /// <summary>
        /// CCCO04.
        /// </summary>
        public const string CCCO04 = "CCCO04";

        /// <summary>
        /// CCCO05.
        /// </summary>
        public const string CCCO05 = "CCCO05";

        /// <summary>
        /// CCCO06.
        /// </summary>
        public const string CCCO06 = "CCCO06";

        /// <summary>
        /// CCCO07.
        /// </summary>
        public const string CCCO07 = "CCCO07";

        /// <summary>
        /// CCCO08.
        /// </summary>
        public const string CCCO08 = "CCCO08";

        /// <summary>
        /// CCCO09.
        /// </summary>
        public const string CCCO09 = "CCCO09";

        /// <summary>
        /// CCCO10.
        /// </summary>
        public const string CCCO10 = "CCCO10";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCITH.
        /// </summary>
        public const string CCITH = "CCITH";
    }

    /// <inheritdoc />
    public override string TableName => "F1609";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCUKID", "CCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCO01", "CCCO01", JdeDataType.String, 2),
        new JdeField("CCCO02", "CCCO02", JdeDataType.String, 2),
        new JdeField("CCCO03", "CCCO03", JdeDataType.String, 2),
        new JdeField("CCCO04", "CCCO04", JdeDataType.String, 2),
        new JdeField("CCCO05", "CCCO05", JdeDataType.String, 2),
        new JdeField("CCCO06", "CCCO06", JdeDataType.String, 2),
        new JdeField("CCCO07", "CCCO07", JdeDataType.String, 2),
        new JdeField("CCCO08", "CCCO08", JdeDataType.String, 2),
        new JdeField("CCCO09", "CCCO09", JdeDataType.String, 2),
        new JdeField("CCCO10", "CCCO10", JdeDataType.String, 2),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCITH", "CCITH", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1609_0", "Primary Key on CCUKID", new[] { "CCUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
